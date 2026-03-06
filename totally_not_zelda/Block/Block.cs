using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Sprint.Interfaces;

namespace Sprint.Block;

public class Block
{
    internal int tileWidth = (int)(16 * GameServices.ScaleFactor);
    private readonly StaticSprite sprite;
    private readonly bool walkable;
    private readonly Vector2 position;

    public Block(Texture2D texture, Vector2 pos, Rectangle sourceRect, bool walkable)
    {
        sprite = new StaticSprite(texture, pos, sourceRect);
        this.walkable = walkable;
        position = pos;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        sprite.Draw(spriteBatch, position);
    }

    public void Update(GameTime time)
    {
        if (walkable)
        {
            // Maybe add collision?
        }
    }
}
