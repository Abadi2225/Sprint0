using Sprint.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Microsoft.Xna.Framework;

namespace Sprint.UI;

class DungeonWalls : IUIElement
{
    private StaticSprite background;
    private Rectangle sourceRect;
    
    public DungeonWalls(Texture2D backgroundTexture)
    {
        sourceRect = new Rectangle(0, 0, 256, 176);
        background = new StaticSprite(backgroundTexture, new Vector2(0, (224-176)*GameServices.ScaleFactor), sourceRect);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, new Vector2(sourceRect.Width / 2, (224-176)*GameServices.ScaleFactor+sourceRect.Height / 2));
    }

    public void Update(GameTime gameTime)
    {
    }
}