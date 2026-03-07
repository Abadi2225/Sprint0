using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Character;

internal class Attacking : ISprite
{
    internal readonly struct Frame
    {
        public readonly Rectangle BodyRect;
        public readonly Rectangle WeaponRect;

        // Offset from Link's position to the weapon draw origin, in texture-pixel units (pre-scale).
        public readonly Vector2 WeaponOffset;

        public bool HasWeapon => WeaponRect != Rectangle.Empty;

        public Frame(Rectangle bodyRect)
        {
            BodyRect = bodyRect;
            WeaponRect = Rectangle.Empty;
            WeaponOffset = Vector2.Zero;
        }

        public Frame(Rectangle bodyRect, Rectangle weaponRect, Vector2 weaponOffset)
        {
            BodyRect = bodyRect;
            WeaponRect = weaponRect;
            WeaponOffset = weaponOffset;
        }
    }

    private readonly Texture2D texture;
    private readonly SpriteEffects effect;
    private readonly Frame[] frames;
    private readonly double secondsPerFrame;

    // Total time to stay in attack state (can be longer than frames*spf if you want)
    private readonly double totalAttackSeconds;

    // onFinished is called once the attack completes (Link will swap back to Idle)
    private readonly System.Action onFinished;

    private int currentFrame;
    private double timer;
    private double totalTimer;
    private bool finished;

    public Attacking(
        Texture2D texture,
        SpriteEffects effect,
        Frame[] frames,
        double secondsPerFrame,
        double totalAttackSeconds,
        System.Action onFinished)
    {
        this.texture = texture;
        this.effect = effect;
        this.frames = frames;
        this.secondsPerFrame = secondsPerFrame;
        this.totalAttackSeconds = totalAttackSeconds;
        this.onFinished = onFinished;

        currentFrame = 0;
        timer = 0;
        totalTimer = 0;
        finished = false;
    }

    // The attack sprite needs to be reset before each use; otherwise on the second
    // attack it won't update because finished is already true.
    public void Reset()
    {
        currentFrame = 0;
        timer = 0;
        totalTimer = 0;
        finished = false;
    }

    public void Update(GameTime gameTime)
    {
        if (finished) return;

        double dt = gameTime.ElapsedGameTime.TotalSeconds;
        timer += dt;
        totalTimer += dt;

        if (timer >= secondsPerFrame)
        {
            currentFrame++;
            if (currentFrame >= frames.Length) currentFrame = frames.Length - 1; // hold last frame
            timer = 0;
        }

        if (totalTimer >= totalAttackSeconds)
        {
            finished = true;
            onFinished?.Invoke();
        }
    }

    // Returns the world-space hitbox of the sword for the current frame, or Empty if no weapon is shown.
    internal Rectangle GetWeaponWorldRect(Vector2 position)
    {
        Frame frame = frames[currentFrame];
        if (!frame.HasWeapon) return Rectangle.Empty;

        Vector2 weaponPos = position + frame.WeaponOffset * GameServices.ScaleFactor;
        return new Rectangle(
            (int)weaponPos.X,
            (int)weaponPos.Y,
            (int)(frame.WeaponRect.Width  * GameServices.ScaleFactor),
            (int)(frame.WeaponRect.Height * GameServices.ScaleFactor)
        );
    }

    public void Draw(SpriteBatch spriteBatch, Vector2 location)
    {
        Frame frame = frames[currentFrame];

        spriteBatch.Draw(texture, location, frame.BodyRect, Color.White, 0f, Vector2.Zero, GameServices.ScaleFactor, effect, 0f);

        if (frame.HasWeapon)
        {
            Vector2 weaponPos = location + frame.WeaponOffset * GameServices.ScaleFactor;
            spriteBatch.Draw(texture, weaponPos, frame.WeaponRect, Color.White, 0f, Vector2.Zero, GameServices.ScaleFactor, effect, 0f);
        }
    }
}
