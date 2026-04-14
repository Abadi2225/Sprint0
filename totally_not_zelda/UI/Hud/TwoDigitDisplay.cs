using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint.Interfaces;
namespace Sprint.UI.Hud;

internal class TwoDigitDisplay : IUIElement
{
    private Vector2 tensPos;
    private Vector2 onesPos;

    private NumberDisplay symbol;
    private NumberDisplay tens;
    private NumberDisplay ones;

    public TwoDigitDisplay(Vector2 symbolPos, Vector2 tensPos, Vector2 onesPos)
    {
        this.tensPos = tensPos;
        this.onesPos = onesPos;

        this.symbol = new NumberDisplay(symbolPos, -1);
        this.tens = new NumberDisplay(tensPos, -1);
        this.ones = new NumberDisplay(onesPos, -1);
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
            tens = new NumberDisplay(tensPos, newTens);
        }
        if (ones.Num != newOnes)
        {
            ones = new NumberDisplay(onesPos, newOnes);
        }
    }

    public void Update(GameTime time) { }
}
