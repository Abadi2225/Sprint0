using Sprint.Interfaces;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Microsoft.Xna.Framework;
using Sprint.UI.Hud;
using System.Runtime.InteropServices;

namespace Sprint.UI;

class NumberDisplay : IUIElement
{
    private StaticSprite background;
    private Rectangle sourceRect;
    private Vector2 pos;

    int baseX = 117; // Starting X coordinate for the 'X' sprite in the UI sheet
    
    public NumberDisplay(Texture2D backgroundTexture, Vector2 pos, int id)
    {
        switch (id)
        {
            case 0: baseX = 117; break; // 'X' sprite
            case 1: baseX = 126; break; // '0' sprite
            case 2: baseX = 135; break; // '1' sprite
            case 3: baseX = 144; break; // '2' sprite
            case 4: baseX = 153; break; // '3' sprite
            case 5: baseX = 162; break; // '4' sprite
            case 6: baseX = 171; break; // '5' sprite
            case 7: baseX = 180; break; // '6' sprite
            case 8: baseX = 189; break; // '7' sprite
            case 9: baseX = 198; break; // '8' sprite
            case 10: baseX = 207; break; // '9' sprite
            default: baseX = 117; break; // Default to 'X' sprite if id is out of range
        }
        sourceRect = new Rectangle(519, baseX, 8, 8);
        this.pos = pos;
        background = new StaticSprite(backgroundTexture, pos, sourceRect);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, new Vector2(sourceRect.Width / 2 + pos.X, sourceRect.Height / 2 + pos.Y));
    }

    public void Update(GameTime gameTime)
    {
    }
}
