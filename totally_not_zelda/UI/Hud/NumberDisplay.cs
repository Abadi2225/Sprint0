using Sprint.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Microsoft.Xna.Framework;

namespace Sprint.UI;

class NumberDisplay : IUIElement
{
    private static readonly Texture2D spriteSheet = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
    private static readonly int MASK_BASE_X = 519; // Starting X coordinate for the 'X' sprite in the UI sheet
    private static readonly int MASK_Y = 117;

    private StaticSprite sprite;
    public Vector2 Position;
    public int Num { get; }


    public NumberDisplay(Vector2 pos, int num)
    {
        Num = num;
        int sourceX = (MASK_BASE_X + 9) + 9 * num;

        Position = pos;
        sprite = new StaticSprite(spriteSheet, Position, new Rectangle(sourceX, MASK_Y, 8, 8));
    }

    public void Draw(SpriteBatch sb)
    {
        sprite.Draw(sb, Position);
    }

    public void Update(GameTime gameTime)
    {
    }
}
