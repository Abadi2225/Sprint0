using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Item;

internal class ItemManager
{
    private List<AbstractItem> Inventory { get; }
    public int ActiveItem { get; set; }
    private List<AbstractItem> SpawnedItems = new List<AbstractItem>();

    public ItemManager()
    {
        Inventory = new List<AbstractItem>();
    }

    public void Add(AbstractItem item)
    {
        Inventory.Add(item);
    }

    public void SpawnItem(AbstractItem item)
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
        // for testing
        if (GetActiveItem() is Boomerang b)
        {
            b.StartMoving();
        }
        if (GetActiveItem() is Arrow a)
        {
            a.StartMoving();
        }
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
