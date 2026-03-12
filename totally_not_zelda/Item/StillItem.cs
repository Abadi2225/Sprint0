using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Item;

internal class StillItem : AbstractItem
{
    public StillItem(string name, Texture2D texture, Vector2 pos, Rectangle mask, float rotation, float scale) : base(name, texture, pos)
    {
        sprite = new StillItemSprite(Position, texture, mask, rotation, scale);
        Rect = new Rectangle((int)Position.X, (int)Position.Y,
                (int)(mask.Width * scale * GameServices.ScaleFactor),
                (int)(mask.Height * scale * GameServices.ScaleFactor));
    }
}
