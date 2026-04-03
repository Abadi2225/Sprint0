using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Character;
using Sprint.Sound;

namespace Sprint.Item;

public class ItemManager
{
    private List<AbstractItem> spawnedItems = new();
    private List<AbstractItem> justFinishedItems = new();

    internal IReadOnlyList<AbstractItem> SpawnedItems => spawnedItems;
    internal IReadOnlyList<AbstractItem> JustFinished => justFinishedItems;

    public void UseItem(ILink link, Inventory inventory, int slot)
    {
        if (slot < 0 || slot >= inventory.Count) return;

        link.StartUseItem();
        Vector2 pos = link.Position;
        Directions facing = link.Facing;
        IItem used = inventory.Get(slot);

        if (used is Boomerang)
        {
            float velocity = 5;
            float maxDistance = 160;
            SpawnItem(ItemFactory.CreateBoomerang(
                        pos,
                        DirectionsUtils.CreateVector(facing, velocity),
                        maxDistance
                        ).StartMoving());
            SoundPlayer.Play(SoundType.ARROW_BOOMERANG);
        }
        else if (used.Name == "Bow")
        {
            float velocity = 5;
            float maxDistance = 160;
            float arrowRotation = facing switch
            {
                Directions.Up => 0f,
                Directions.Down => MathF.PI,
                Directions.Right => MathF.PI / 2f,
                Directions.Left => -MathF.PI / 2f,
                _ => 0f
            };
            SpawnItem(ItemFactory.CreateArrow(
                        pos,
                        DirectionsUtils.CreateVector(facing, velocity),
                        rotation: arrowRotation,
                        scale: 2f,
                        maxDistance
                        ).StartMoving());
            SoundPlayer.Play(SoundType.ARROW_BOOMERANG);
        }
        else if (used.Name == "Bomb" || used.Name == "TimeBomb")
        {
            float reach = 30f;
            double explodeDelayMillis = 3000;
            SpawnItem(ItemFactory.CreateTimeBomb(
                        explodeDelayMillis,
                        Vector2.Add(pos, DirectionsUtils.CreateVector(facing, reach)),
                        scale: 2f
                        ));
            SoundPlayer.Play(SoundType.BOMB_PLACE);
        }
    }

    internal void SpawnItem(AbstractItem item) => spawnedItems.Add(item);

    public void Update(GameTime time)
    {
        foreach (AbstractItem item in spawnedItems)
            item.Update(time);
        justFinishedItems = spawnedItems.Where(item => item.IsFinished).ToList();
        spawnedItems.RemoveAll(item => item.IsFinished);
    }

    public void Draw(SpriteBatch sb)
    {
        foreach (AbstractItem item in spawnedItems)
            item.Draw(sb, Vector2.Zero);
    }
}
