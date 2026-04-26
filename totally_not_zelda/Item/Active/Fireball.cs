using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Sprites;

namespace Sprint.Item;

public class Fireball : AbstractItem
{
    private const float SPEED = 120f;
    private const float MAX_LIFETIME = 3f;
    private const int SOURCE_WIDTH = 8;
    private const int SOURCE_HEIGHT = 10;

    private static readonly int[] FrameX = [101, 110, 119, 128];
    private const int FrameY = 14;
    private const float FrameTime = 0.3f;

    private Vector2 velocity;
    private float lifetime;

    public Fireball(Texture2D texture, Vector2 pos, Vector2 direction)
        : base("Fireball", texture, pos)
    {
        sprite = new AnimatedSprite(texture, pos, FrameX, FrameY, SOURCE_WIDTH, SOURCE_HEIGHT, FrameTime);

        if (direction != Vector2.Zero)
            direction.Normalize();
        velocity = direction * SPEED;

        float scale = GameServices.ScaleFactor;
        Rect = new Rectangle((int)pos.X, (int)pos.Y,
            SOURCE_WIDTH * (int)scale, SOURCE_HEIGHT * (int)scale);
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
        float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
        lifetime += dt;
        Position += velocity * dt;
    }

    public override bool IsFinished => base.IsFinished || lifetime >= MAX_LIFETIME;
    public override bool DamagesPlayer => true;
}
