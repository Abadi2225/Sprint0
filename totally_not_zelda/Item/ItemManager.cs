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

    private static Vector2 ProjectileOrigin(ILink link)
    {
        // link.Rect is the lower half of the sprite; reconstruct full bounds from Position
        float scale = GameServices.ScaleFactor;
        int spriteSize = (int)(16 * scale);
        Vector2 pos = link.Position;
        float cx = pos.X + spriteSize / 2f;
        float cy = pos.Y + spriteSize / 2f;
        return link.Facing switch
        {
            Directions.Up => new Vector2(cx, pos.Y),
            Directions.Down => new Vector2(cx, pos.Y + spriteSize),
            Directions.Left => new Vector2(pos.X, cy),
            Directions.Right => new Vector2(pos.X + spriteSize, cy),
            _ => new Vector2(cx, cy)
        };
    }

    public void UseItem(ILink link, Inventory inventory, int slot)
    {
        if (slot < 0 || slot >= inventory.Count) return;

        IItem used = inventory.Get(slot);
        Vector2 pos = ProjectileOrigin(link);
        Directions facing = link.Facing;

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
                        scale: GameServices.ScaleFactor,
                        maxDistance
                        ).StartMoving());
            SoundPlayer.Play(SoundType.ARROW_BOOMERANG);
        }
        else if (used.Name == "Bomb" || used.Name == "TimeBomb")
        {
            if (!GameServices.Link.UseBomb()) return;

            float throwSpeed = 3f;
            float throwDistance = 72f;
            double explodeDelayMillis = 1500;
            float bombW = 8 * GameServices.ScaleFactor;
            float bombH = 14 * GameServices.ScaleFactor;
            Vector2 bombPos = pos - new Vector2(bombW / 2f, bombH / 2f);
            SpawnItem(ItemFactory.CreateTimeBomb(
                        explodeDelayMillis,
                        bombPos,
                        DirectionsUtils.CreateVector(facing, throwSpeed),
                        throwDistance,
                        scale: GameServices.ScaleFactor
                        ));
            SoundPlayer.Play(SoundType.BOMB_PLACE);
        }

        link.StartUseItem();
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
