using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal class StillItem : AbstractItem
{
    private const string ResourceName = "items/sheet";
    public StillItem(string name, ContentManager contentManager, Vector2 drawPos, Rectangle mask, float rotation, float scale) : base(name, contentManager, ResourceName, drawPos)
    {
        sprite = new StillItemSprite(
                DrawPos,
                texture,
                mask,
                rotation,
                scale
                );
    }
}
