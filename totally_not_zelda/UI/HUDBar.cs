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
    private Texture2D texture;
    private StaticSprite background;
    private Rectangle sourceRect;

    private HeartDisplay hearts = new HeartDisplay(new Vector2(505, 100), 10);

    private TwoDigitDisplay rupees;
    private TwoDigitDisplay keys;
    private TwoDigitDisplay bombs;

    public HUDBar(Texture2D backgroundTexture)
    {
        texture = backgroundTexture;

        sourceRect = new Rectangle(258, 19, 256, 48);
        background = new StaticSprite(texture, new Vector2(0, 0), sourceRect);

        rupees = new TwoDigitDisplay(
                new Vector2(96 * GameServices.ScaleFactor, 8 * GameServices.ScaleFactor),
                new Vector2(104 * GameServices.ScaleFactor, 8 * GameServices.ScaleFactor),
                new Vector2(112 * GameServices.ScaleFactor, 8 * GameServices.ScaleFactor),
                texture
                );
        keys = new TwoDigitDisplay(
                new Vector2(96 * GameServices.ScaleFactor, 24 * GameServices.ScaleFactor),
                new Vector2(104 * GameServices.ScaleFactor, 24 * GameServices.ScaleFactor),
                new Vector2(112 * GameServices.ScaleFactor, 24 * GameServices.ScaleFactor),
                texture
                );
        bombs = new TwoDigitDisplay(
                new Vector2(96 * GameServices.ScaleFactor, 32 * GameServices.ScaleFactor),
                new Vector2(104 * GameServices.ScaleFactor, 32 * GameServices.ScaleFactor),
                new Vector2(112 * GameServices.ScaleFactor, 32 * GameServices.ScaleFactor),
                texture
                );
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, Vector2.Zero);
        // todo use Link's hearts
        hearts.Draw(GameServices.Link.Health, GameServices.Link.MaxHealth, spriteBatch);
        rupees.Draw(spriteBatch);
        keys.Draw(spriteBatch);
        bombs.Draw(spriteBatch);
    }

    public void Update(GameTime gameTime)
    {
        int linkRupees = GameServices.Link.Rubies;
        rupees.SetNumber(GameServices.Link.Rubies);
        // keys.SetNumber(GameServices.Link.Keys);
        // bombs.SetNumber(GameServices.Link.Bombs);
    }
}
