using Microsoft.Xna.Framework;

using Sprint.Sound;
using Sprint.Sprites;

namespace Sprint.Item;

internal class TimeBomb : AbstractItem
{
    private double millisUntilExplode;
    private bool exploded = false;

    public TimeBomb(double explodeDelayMillis, string name, Vector2 pos, Rectangle sourceRect, float scale) : base(name, GameServices.ItemSheet, pos)
    {
        millisUntilExplode = explodeDelayMillis;
        sprite = new StaticSprite(texture, Position, sourceRect, scale);
        Rect = new Rectangle((int)pos.X, (int)pos.Y, (int)(sourceRect.Width * scale), (int)(sourceRect.Height * scale));
    }

    public override void Update(GameTime time)
    {
        millisUntilExplode -= time.ElapsedGameTime.TotalMilliseconds;
        if (millisUntilExplode <= 0 && !exploded)
        {
            exploded = true;
            // run explode triggers
            SoundPlayer.Play(SoundType.BOMB_EXPLODE);
        }
    }

    public override bool IsFinished => millisUntilExplode <= 0 && exploded;
}
