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
    readonly int BASE_X = 519; // Starting X coordinate for the 'X' sprite in the UI sheet
    readonly int Y = 117;

    private StaticSprite background;
    private Rectangle sourceRect;
    private Vector2 pos;
    public int Num { get; }


    public NumberDisplay(Texture2D backgroundTexture, Vector2 pos, int num)
    {
        Num = num;
        int x = (BASE_X + 9) + 9 * num;

        sourceRect = new Rectangle(x, Y, 8, 8);
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
