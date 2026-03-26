using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint.Interfaces;
namespace Sprint.UI.Hud;

internal class TwoDigitDisplay : IUIElement
{
    private Texture2D spriteSheet;
    // private Vector2 symbolPos;
    private Vector2 tensPos;
    private Vector2 onesPos;

    private NumberDisplay symbol;
    private NumberDisplay tens;
    private NumberDisplay ones;

    public TwoDigitDisplay(Vector2 symbolPos, Vector2 tensPos, Vector2 onesPos, Texture2D spriteSheet)
    {
        this.spriteSheet = spriteSheet;
        this.tensPos = tensPos;
        this.onesPos = onesPos;

        this.symbol = new NumberDisplay(this.spriteSheet, symbolPos, -1);
        this.tens = new NumberDisplay(this.spriteSheet, tensPos, -1);
        this.ones = new NumberDisplay(this.spriteSheet, onesPos, -1);
    }

    public void Draw(SpriteBatch sb)
    {
        symbol.Draw(sb);
        tens.Draw(sb);
        ones.Draw(sb);
    }

    public void SetNumber(int newNumber)
    {
        int newTens = MathHelper.Min(newNumber, 99) / 10;
        int newOnes = MathHelper.Min(newNumber, 99) % 10;
        if (tens.Num != newTens)
        {
            tens = new NumberDisplay(spriteSheet, tensPos, newTens);
        }
        if (ones.Num != newOnes)
        {
            ones = new NumberDisplay(spriteSheet, onesPos, newOnes);
        }
    }

    public void Update(GameTime time) { }
}
