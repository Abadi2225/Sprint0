using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal class StillItemSprite : ISprite
{
    public Vector2 Position { get; set; }
    private Texture2D texture;
    private Rectangle textureMask;
    private float rotation = 0f;
    private float scale = 1f;

    public StillItemSprite(Vector2 position, Texture2D texture, Rectangle mask, float rotation, float scale)
    {
        Position = position;
        this.texture = texture;
        textureMask = mask;
        this.rotation = rotation;
        this.scale = scale;
    }

    public void Draw(SpriteBatch sb, Vector2 unused)
    {
        sb.Draw(
                texture,
                Position,
                textureMask,
                Color.White,
                rotation,
                origin: new Vector2(0, 0),
                scale,
                SpriteEffects.None,
                0f
               );
    }
    public int Update(GameTime time)
    {
        return 0;
    }
}
