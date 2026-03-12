using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal class Bow : AbstractItem
{
    public Bow(string name, Vector2 pos, Rectangle mask, float rotation, float scale) : base(name, GameServices.ItemSheet, pos)
    {
        sprite = new StillItemSprite(
                Position,
                texture,
                mask,
                rotation,
                scale
                );
    }
}
