using Sprint.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Microsoft.Xna.Framework;

namespace Sprint.UI;

class OuterDungeonWalls : IUIElement
{
    private StaticSprite background;
    private Rectangle sourceRect;
    
    public OuterDungeonWalls(Texture2D backgroundTexture)
    {
        sourceRect = new Rectangle(0, 0, 256, 176);
        background = new StaticSprite(backgroundTexture, new Vector2(0, 0), sourceRect);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, new Vector2(0, 48 * GameServices.ScaleFactor));
    }

    public void Update(GameTime gameTime)
    {
    }
}