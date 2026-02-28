using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Character;

internal class Attacking : ISprite
{
    private readonly Texture2D texture;
    private readonly SpriteEffects effect;
    private readonly Rectangle[] frames;
    private readonly double secondsPerFrame;

    // Total time to stay in attack state (can be longer than frames*spf if you want)
    private readonly double totalAttackSeconds;
    
    // onFinished is called once the attack completes (Link will swap back to Idle)
    private readonly System.Action onFinished;
    private readonly bool anchorBottom;
    private readonly int baseSize;

    private int currentFrame;
    private double timer;
    private double totalTimer;
    private bool finished;

    public Attacking(
        Texture2D texture,
        SpriteEffects effect,
        Rectangle[] frames,
        double secondsPerFrame,
        double totalAttackSeconds,
        System.Action onFinished,
        bool anchorBottom = false,
        int baseSize = 0)
    {
        this.texture = texture;
        this.effect = effect;
        this.frames = frames;
        this.secondsPerFrame = secondsPerFrame;
        this.totalAttackSeconds = totalAttackSeconds;
        this.onFinished = onFinished;
        this.anchorBottom = anchorBottom;
        this.baseSize = baseSize > 0 ? baseSize : frames[0].Height;

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

    public void Draw(SpriteBatch spriteBatch, Vector2 location)
    {
        Rectangle frame = frames[currentFrame];
        Vector2 drawPos = location;

        // Keep the character body anchored as the sprite grows
        if (effect == SpriteEffects.FlipHorizontally)
            drawPos.X -= (frame.Width - frames[0].Width) * 2f;  // anchor right edge (left attack)
        else if (anchorBottom)
            drawPos.Y -= (frame.Height - baseSize) * 2f;        // anchor bottom edge (up attack)

        spriteBatch.Draw(texture, drawPos, frame, Color.White, 0f, Vector2.Zero, 2f, effect, 0f);
    }
}