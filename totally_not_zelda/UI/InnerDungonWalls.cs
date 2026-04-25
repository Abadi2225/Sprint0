using Sprint.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Microsoft.Xna.Framework;
using Sprint.Block;

namespace Sprint.UI;

class InnerDungeonWalls : IUIElement
{
    private StaticSprite background;
    private Rectangle sourceRect;

    private int XOffset = (int)(20 * GameServices.ScaleFactor);
    private int YOffset = (int)(68 * GameServices.ScaleFactor);
    
    public InnerDungeonWalls(Texture2D backgroundTexture)
    {
        sourceRect = new Rectangle(0, 0, 216, 136);
        background = new StaticSprite(backgroundTexture, new Vector2(0, 0), sourceRect, BlockFactory.tileColors[GameServices.CurrentDungeon]);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, new Vector2(XOffset, YOffset));
    }

    public void Update(GameTime gameTime)
    {
    }
}