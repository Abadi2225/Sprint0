using Microsoft.Xna.Framework;

using Sprint.Sprites;

namespace Sprint.Item;

internal class TimeBomb : AbstractItem
{
    private double millisUntilExplode;

    public TimeBomb(double explodeDelayMillis, string name, Vector2 pos, Rectangle sourceRect, float scale) : base(name, GameServices.ItemSheet, pos)
    {
        millisUntilExplode = explodeDelayMillis;
        sprite = new StaticSprite(texture, Position, sourceRect, scale);
    }

    public override void Update(GameTime time)
    {
        millisUntilExplode -= time.ElapsedGameTime.TotalMilliseconds;
    }

    public override bool IsFinished => millisUntilExplode <= 0;
}
