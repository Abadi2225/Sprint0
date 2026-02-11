using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegendOfZilda
{
    internal class AnimatedSprite : ISprite
{
		private Texture2D texture;

		private List<Rectangle> frames;
		private int currentFrame;

		private Rectangle destRect;

		private double timeCounter;
		private double secondsPerFrame = 0.10;

		public AnimatedSprite(Texture2D texture, Viewport viewport)
		{
			this.texture = texture;

			frames = new List<Rectangle> { 
				new Rectangle(145, 47, 21, 36), 
				new Rectangle(117, 48, 18, 35), 
				new Rectangle(85, 49, 21, 33) 
			};
			Rectangle firstFrame = frames[0];
			destRect = new Rectangle(
				viewport.Width / 2 - firstFrame.Width / 2,
				viewport.Height / 2 - firstFrame.Height / 2,
				firstFrame.Width,
				firstFrame.Height
			);

			currentFrame = 0;
			timeCounter = 0.0;
		}
		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, destRect, frames[currentFrame], Color.White);
		}

		public void Update(GameTime gameTime)
		{
			timeCounter += gameTime.ElapsedGameTime.TotalSeconds;

			if (timeCounter >= secondsPerFrame)
			{
				timeCounter -= secondsPerFrame;
				currentFrame = (currentFrame + 1) % frames.Count;
			}

		}
	}
}
