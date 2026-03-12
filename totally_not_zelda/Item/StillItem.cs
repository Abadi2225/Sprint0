using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal class StillItem : AbstractItem
{
    private const string ResourceName = "items/sheet";
    public StillItem(string name, ContentManager contentManager, Vector2 pos, Rectangle mask, float rotation, float scale) : base(name, contentManager, ResourceName, pos)
    {
        sprite = new StillItemSprite(
                Position,
                texture,
                mask,
                rotation,
                scale
                );
        Rect = new Rectangle((int)Position.X, (int)Position.Y,
                (int)(mask.Width * scale * GameServices.ScaleFactor),
                (int)(mask.Height * scale * GameServices.ScaleFactor));
    }
}
