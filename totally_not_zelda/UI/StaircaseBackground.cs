using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.UI;

public class StaircaseBackground : IUIElement
{
    private readonly Texture2D texture;
    private readonly float scale;
    private readonly float hudHeight;

    public StaircaseBackground(Texture2D texture)
    {
        this.texture = texture;
        scale = GameServices.ScaleFactor;
        hudHeight = 48 * scale;
    }

    public Rectangle InnerBounds => new Rectangle(
        (int)(49 * scale),
        (int)(0 * scale + hudHeight),
        (int)((192 - 49) * scale),
        (int)(129 * scale)
    );

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture, new Vector2(0, hudHeight), null,
            Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
    }

    public void Update(GameTime gameTime) { }
}