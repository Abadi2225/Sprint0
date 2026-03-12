using Microsoft.Xna.Framework;

namespace Sprint.Item;

internal class TimeBomb : AbstractItem
{
    private double millisUntilExplode;

    public TimeBomb(double explodeDelayMillis, string name, Vector2 pos, Rectangle mask, float rotation, float scale) : base(name, GameServices.ItemSheet, pos)
    {
        millisUntilExplode = explodeDelayMillis;
        sprite = new StillItemSprite(Position, texture, mask, rotation, scale);
    }

    public override void Update(GameTime time)
    {
        millisUntilExplode -= time.ElapsedGameTime.TotalMilliseconds;
    }

    public override bool IsFinished => millisUntilExplode <= 0;
}
