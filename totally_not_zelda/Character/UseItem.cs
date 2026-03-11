using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Character;

internal class UseItem : ISprite
{
	internal readonly struct Frame
	{
		public readonly Rectangle BodyRect;


		public Frame(Rectangle bodyRect)
		{
			BodyRect = bodyRect;
		}

	}

	private readonly Texture2D texture;
	private readonly SpriteEffects effect;
	private readonly Frame[] frames;
	private readonly double secondsPerFrame;

	// Total time to stay in using item state (can be longer than frames*spf if you want)
	private readonly double totalItemSeconds;

	// onFinished is called once using item completes (Link will swap back to Idle)
	private readonly System.Action onFinished;

	private int currentFrame;
	private double timer;
	private double totalTimer;
	private bool finished;

	public UseItem(
		Texture2D texture,
		SpriteEffects effect,
		Frame[] frames,
		double secondsPerFrame,
		double totalItemSeconds,
		System.Action onFinished)
	{
		this.texture = texture;
		this.effect = effect;
		this.frames = frames;
		this.secondsPerFrame = secondsPerFrame;
		this.totalItemSeconds = totalItemSeconds;
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

		if (totalTimer >= totalItemSeconds)
		{
			finished = true;
			onFinished?.Invoke();
		}
	}

	public void Draw(SpriteBatch spriteBatch, Vector2 location)
	{
		Frame frame = frames[currentFrame];

		spriteBatch.Draw(texture, location, frame.BodyRect, Color.White, 0f, Vector2.Zero, GameServices.ScaleFactor, effect, 0f);
	}
}
