using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Block;

internal class TileSprite : IPositionedSprite
{
    public Vector2 Position { get; set; }
    private readonly Texture2D texture;
    private readonly Rectangle textureMask;
    private readonly int width;

    public TileSprite(Texture2D texture, Rectangle texMask, Vector2 pos, int width)
    {
        this.texture = texture;
        Position = pos;
        this.width = width;
        this.textureMask = texMask;
    }

    public void Draw(SpriteBatch sb, Vector2 _)
    {
        sb.Draw(
                texture,
                Position,
                textureMask,
                Color.White,
                0f,
                Vector2.Zero,
                (float)width / textureMask.Width,
                SpriteEffects.None,
                0f
               );
    }

    public void Update(GameTime time)
    {
    }
}
