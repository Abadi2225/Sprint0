﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint.Interfaces;

namespace Sprint.Character
{
	internal class Walking : ISprite
	{
		private Texture2D texture;
		private SpriteEffects effect;
		private Rectangle[] frames;
		private int currentFrame;
		private double timer;
		private double secondsPerFrame;

		public Vector2 Position { get; set; }  // unused; added to resolve merge conflict

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
			spriteBatch.Draw(
				texture,
				location,
				frames[currentFrame],
				Color.White,
				0f,
				Vector2.Zero,
				2f,
				effect,
				0f
				);
		}
	}
}