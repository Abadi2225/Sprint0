using Sprint.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Microsoft.Xna.Framework;

namespace Sprint.UI;

class TitleScreen : IUIElement
{
    private StaticSprite background;
    private Rectangle sourceRect;

    public TitleScreen(Texture2D backgroundTexture)
    {
        sourceRect = new Rectangle(1, 11, 256, 224);
        background = new StaticSprite(backgroundTexture, Vector2.Zero, sourceRect);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, new Vector2(sourceRect.Width / 2, sourceRect.Height / 2));
    }

    public int Update(GameTime gameTime)
    {
        return 0;
    }
}