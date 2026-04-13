using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Sound;
using Sprint.Sprites;

namespace Sprint.Item;

internal class TimeBomb : AbstractItem
{
    private static readonly int[] CloudFrameX = [138, 155, 172];
    private const int CloudFrameY = 185;
    private const int CloudFrameW = 15;
    private const int CloudFrameH = 15;
    private const float CloudFrameTime = 0.12f;
    private const double CloudDurationMillis = 600;

    private double millisUntilExplode;
    private bool exploded = false;
    private bool cloudDone = false;

    private ProjectileSprite projectile;
    private StaticSprite still;
    private AnimatedSprite cloud;
    private double cloudElapsed = 0;
    private Rectangle sourceRect;
    private float scale;
    private bool landed = false;

    public TimeBomb(double explodeDelayMillis, string name, Vector2 pos, Vector2 velocity, float throwDistance, Rectangle sourceRect, float scale) : base(name, GameServices.ItemSheet, pos)
    {
        millisUntilExplode = explodeDelayMillis;
        this.sourceRect = sourceRect;
        this.scale = scale;

        projectile = new ProjectileSprite(texture, sourceRect, pos, velocity, throwDistance, 0f, Vector2.Zero, scale);
        projectile.StartMoving();
        sprite = projectile;

        Rect = new Rectangle((int)pos.X, (int)pos.Y, (int)(sourceRect.Width * scale), (int)(sourceRect.Height * scale));
    }

    public override void Update(GameTime time)
    {
        base.Update(time);

        if (!landed)
        {
            Position = projectile.Position;
            if (projectile.ReachedMaxDistance)
            {
                landed = true;
                still = new StaticSprite(texture, Position, sourceRect, scale);
                sprite = still;
            }
        }
        else if (!exploded)
        {
            millisUntilExplode -= time.ElapsedGameTime.TotalMilliseconds;
            if (millisUntilExplode <= 0)
            {
                exploded = true;
                SoundPlayer.Play(SoundType.BOMB_EXPLODE);
                cloud = new AnimatedSprite(GameServices.LinkSheet, Position, CloudFrameX, CloudFrameY, CloudFrameW, CloudFrameH, CloudFrameTime);
                sprite = cloud;
                Rect = Rectangle.Empty;
            }
        }
        else if (!cloudDone)
        {
            cloudElapsed += time.ElapsedGameTime.TotalMilliseconds;
            if (cloudElapsed >= CloudDurationMillis)
                cloudDone = true;
        }
    }

    public override void Draw(SpriteBatch sb, Vector2 location)
    {
        if (exploded && cloud != null)
        {
            float s = GameServices.ScaleFactor;
            Vector2 cloudPos = Position + new Vector2(
                (sourceRect.Width - CloudFrameW) * s / 2f,
                (sourceRect.Height - CloudFrameH) * s / 2f);
            cloud.Draw(sb, cloudPos);
        }
        else
        {
            base.Draw(sb, location);
        }
    }

    public override bool IsFinished => exploded && cloudDone;
}
