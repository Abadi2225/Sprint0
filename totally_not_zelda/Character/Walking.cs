using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Character;

internal class Walking : ISprite
{
    private readonly Texture2D texture;
    private readonly SpriteEffects effect;
    private readonly Rectangle[] frames;
    private readonly double secondsPerFrame;
    private int currentFrame;
    private double timer;

    public Walking(Texture2D texture, SpriteEffects effect, Rectangle[] frames, double secondsPerFrame)
    {
        this.texture = texture;
        this.frames = frames;
        this.effect = effect;
        this.secondsPerFrame = secondsPerFrame;
        currentFrame = 0;
        timer = 0;
    }

    public void Update(GameTime gameTime)
    {
        timer += gameTime.ElapsedGameTime.TotalSeconds;

        if (timer >= secondsPerFrame)
        {
            currentFrame = (currentFrame + 1) % frames.Length;
            timer = 0;
        }
    }

    public void Draw(SpriteBatch spriteBatch, Vector2 location)
    {
        spriteBatch.Draw(texture, location, frames[currentFrame], Color.White, 0f, Vector2.Zero, 2f, effect, 0f);
    }
}
