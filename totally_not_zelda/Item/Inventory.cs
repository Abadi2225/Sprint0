using Microsoft.Xna.Framework;
using System;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using System.Collections.Generic;
using Sprint.UI.InventoryElements;

namespace Sprint.Item;

public class Inventory
{
    private readonly List<IItem> items = new();
    public int ActiveSlot { get; set; }
    public int Count => items.Count;

    public void Add(IItem item)
    {
        if (items.Count < InventoryBar.COLS * InventoryBar.ROWS)
        {
            Console.WriteLine("added " + item.Name + " to inventory");
            items.Add(item);
        }
        else
        {
            Console.WriteLine("inventory full");
        }
    }

    public IItem Get(int slot) => items[slot];

    // public void CycleNext()
    // {
    //     if (ActiveSlot < items.Count - 1) ActiveSlot++;
    // }
    //
    // public void CyclePrevious()
    // {
    //     if (ActiveSlot > 0) ActiveSlot--;
    // }

    public void Update(GameTime time)
    {
        foreach (var item in items)
            item.Update(time);
    }

    // public void Draw(SpriteBatch sb)
    // {
    //     if (items.Count > 0)
    //         items[ActiveSlot].Draw(sb, Vector2.Zero);
    // }
    public List<IItem> GetItems()
    {
        return items;
    }
}
