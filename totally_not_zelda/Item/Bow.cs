using Microsoft.Xna.Framework;

using Sprint.Sprites;

namespace Sprint.Item;

internal class Bow : AbstractItem
{
    public Bow(string name, Vector2 pos, Rectangle sourceRect, float scale) : base(name, GameServices.ItemSheet, pos)
    {
        sprite = new StaticSprite(texture, Position, sourceRect, scale);
    }
}
