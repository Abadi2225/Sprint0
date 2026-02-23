using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Character;

namespace Sprint.Item;

public class ItemManager
{
    private List<AbstractItem> Inventory { get; }
    public int ActiveItem { get; set; }
    private List<AbstractItem> SpawnedItems = new List<AbstractItem>();

    public ItemManager()
    {
        Inventory = new List<AbstractItem>();
    }

    public void UseItem(ILink link, int slot)
    {
        if (slot < 0 || slot >= Inventory.Count)
        {
            return;
        }
        link.StartAttack();
        Vector2 pos = link.Position;
        Directions facing = link.Facing;
        AbstractItem used = Inventory[slot];
        if (used is Boomerang)
        {
            float velocity = 5;
            float maxDistance = 500;
            SpawnItem(ItemFactory.CreateBoomerang(
                        pos,
                        DirectionsUtils.CreateVector(facing, velocity),
                        maxDistance
                        ).StartMoving());
        }
        else if (used.Name == "Bow")
        {
            float velocity = 5;
            float maxDistance = 500;
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
        }
        else if (used.Name == "Bomb" || used.Name == "TimeBomb")
        {
            float reach = 30;
            double explodeDelayMillis = 3000;
            SpawnItem(ItemFactory.CreateTimeBomb(
                        explodeDelayMillis,
                        Vector2.Add(pos, DirectionsUtils.CreateVector(facing, reach)),
                        scale: 2f,
                        rotation: 0f
                        ));
        }
    }

    internal void Add(AbstractItem item)
    {
        Inventory.Add(item);
    }

    internal void SpawnItem(AbstractItem item)
    {
        SpawnedItems.Add(item);
    }

    public void Draw(SpriteBatch sb)
    {
        Inventory[ActiveItem].Draw(sb, Vector2.Zero);
        foreach (AbstractItem item in SpawnedItems)
        {
            item.Draw(sb, Vector2.Zero);
        }
    }

    public void Update(GameTime time)
    {
        foreach (AbstractItem item in Inventory)
        {
            item.Update(time);
        }
        foreach (AbstractItem item in SpawnedItems)
        {
            item.Update(time);
        }
        SpawnedItems.RemoveAll(item => item.IsFinished);
    }

    internal AbstractItem GetActiveItem()
    {
        return Inventory[ActiveItem];
    }

    public void CycleNext()
    {
        if (ActiveItem < Inventory.Count - 1)
        {
            ActiveItem++;
        }
    }
    public void CyclePrevious()
    {
        if (ActiveItem > 0)
        {
            ActiveItem--;
        }
    }
}
