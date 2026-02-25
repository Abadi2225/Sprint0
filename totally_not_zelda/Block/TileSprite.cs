using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Block;

internal class TileSprite : ISprite
{
    public Vector2 Position { get; set; }
    private Texture2D texture;
    private Rectangle textureMask;
    private int width = 0;

    public TileSprite(Texture2D texture, Rectangle texMask, Vector2 pos, int width)
    {
        this.texture = texture;
        Position = pos;
        this.width = width;
        this.textureMask = texMask;
    }

    public void Draw(SpriteBatch sb, Vector2 unused)
    {
        sb.Draw(
                texture,
                Position,
                textureMask,
                Color.White,
                0f,
                Vector2.Zero,
                new Vector2((float)(width / textureMask.Width), (float)(width / textureMask.Width)),
                SpriteEffects.None,
                0f
               );
    }

    public int Update(GameTime time)
    {
        return 0;
    }
}
