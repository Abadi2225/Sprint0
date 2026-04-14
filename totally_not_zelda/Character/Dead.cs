using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.Character
{
	internal class Dead : ISprite
	{
		private readonly Texture2D texture;
		private readonly Frame[] frames;
		private readonly double secondsPerFrame;
		private int currentFrame;
		private double timer;
		private double totalTimer;
		private bool finished;
		private double totalDeathSeconds = 0.8;

		public bool Finished => finished;

		public readonly struct Frame
		{
			public Rectangle Source { get; }
			public SpriteEffects Effect { get; }

			public Frame(Rectangle source, SpriteEffects effect)
			{
				Source = source;
				Effect = effect;
			}
		}

		public Dead(Texture2D texture, Frame[] frames, double secondsPerFrame)
		{
			this.texture = texture;
			this.frames = frames;
			this.secondsPerFrame = secondsPerFrame;
			currentFrame = 0;
			timer = 0;
		}

		public void Reset()
		{
			currentFrame = 0;
			timer = 0;
			totalTimer = 0;
			finished = false;
		}
		public void Draw(SpriteBatch spriteBatch, Vector2 location)
		{
			spriteBatch.Draw(
				texture,
				location,
				frames[currentFrame].Source,
				Color.White,
				0f,
				Vector2.Zero,
				GameServices.ScaleFactor,
				frames[currentFrame].Effect,
				0f
			);

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

				if (currentFrame >= frames.Length)
				{
					currentFrame = (currentFrame + 1) % frames.Length;
				}
					timer = 0;
			}

			if(totalTimer >= totalDeathSeconds){
				finished = true;
			}
		}
	}
}
