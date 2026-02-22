using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Item;

public class ItemManager
{
    private List<ItemSprite> drawables = new List<ItemSprite>();

    public void CreateItem(AbstractItem item)
    {
        if (item is ItemSprite sprite)
        {
            drawables.Add(sprite);
        }
    }

    public void DrawAllItems(SpriteBatch sb)
    {
        foreach (ItemSprite sprite in drawables)
        {
            sprite.Draw(sb);
        }
    }
}
