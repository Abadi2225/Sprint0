using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Sprites;

namespace Sprint.Item;

internal class StillItem : AbstractItem
{
    public StillItem(string name, Texture2D texture, Vector2 pos, Rectangle sourceRect, float scale) : base(name, texture, pos)
    {
        sprite = new StaticSprite(texture, Position, sourceRect, scale);

        // removed GameServices.ScaleFactor from multiplication steps
        Rect = new Rectangle((int)Position.X, (int)Position.Y,
                (int)(sourceRect.Width * scale),
                (int)(sourceRect.Height * scale));
    }
}
