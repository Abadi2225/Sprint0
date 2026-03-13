using Microsoft.Xna.Framework;

using Sprint.Sprites;

namespace Sprint.Item;

internal class TimeBomb : AbstractItem
{
    private double millisUntilExplode;

    public bool IsExploding { get; private set; }

    public TimeBomb(double explodeDelayMillis, string name, Vector2 pos, Rectangle sourceRect, float scale) : base(name, GameServices.ItemSheet, pos)
    {
        millisUntilExplode = explodeDelayMillis;
        sprite = new StaticSprite(texture, Position, sourceRect, scale);
        Rect = new Rectangle((int)pos.X, (int)pos.Y, (int)(sourceRect.Width * scale), (int)(sourceRect.Height * scale));
    }

    public override void Update(GameTime time)
    {
        if (IsExploding)
        {
            IsExploding = false;
            return;
        }

        millisUntilExplode -= time.ElapsedGameTime.TotalMilliseconds;
        if (millisUntilExplode <= 0)
            IsExploding = true;
    }

    public override bool IsFinished => millisUntilExplode <= 0 && !IsExploding;
}
