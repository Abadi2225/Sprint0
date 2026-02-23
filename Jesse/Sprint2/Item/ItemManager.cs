using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Item;

public class ItemManager
{
    internal List<AbstractItem> Items { get; }
    public int ActiveItem { get; set; }

    public ItemManager()
    {
        Items = new List<AbstractItem>();
    }

    internal void Add(AbstractItem item)
    {
        Items.Add(item);
    }

    public void DrawAllItems(SpriteBatch sb)
    {
        foreach (AbstractItem item in Items)
        {
            item.Draw(sb, Vector2.Zero);
        }
    }

    public void DrawActiveItem(SpriteBatch sb)
    {
        Items[ActiveItem].Draw(sb, Vector2.Zero);
    }

    public void Update(GameTime time)
    {
        foreach (AbstractItem item in Items)
        {
            item.Update(time);
        }
        GetActiveItem().Use(null);
    }

    internal AbstractItem GetActiveItem()
    {
        return Items[ActiveItem];
    }

    public void CycleNext()
    {
        if (ActiveItem < Items.Count - 1)
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
