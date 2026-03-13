using Sprint.Interfaces;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Microsoft.Xna.Framework;
using Sprint.UI.Hud;

namespace Sprint.UI;

class HUDBar : IUIElement
{
    public enum State
    {
        UNFOCUSED,
    }
    private StaticSprite background;
    private Rectangle sourceRect;

    private HeartDisplay hearts = new HeartDisplay(new Vector2(505, 100), 10);
    
    private NumberDisplay rupeeCount;

    public HUDBar(Texture2D backgroundTexture)
    {
        sourceRect = new Rectangle(258, 19, 256, 48);
        background = new StaticSprite(backgroundTexture, new Vector2(0, 0), sourceRect);
        rupeeCount = new NumberDisplay(backgroundTexture, new Vector2(96 * GameServices.ScaleFactor, 8 * GameServices.ScaleFactor), 0);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, new Vector2(sourceRect.Width / 2, sourceRect.Height / 2));
        // todo use Link's hearts
        hearts.Draw(3, true, 6, spriteBatch);
        rupeeCount.Draw(spriteBatch);
    }

    public void Update(GameTime gameTime)
    {
    }
}
