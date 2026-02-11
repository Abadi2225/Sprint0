using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegendOfZilda
{
    internal class MovingAnimatedSprite : ISprite
{
		private Texture2D texture;
		private float speed;
		private int windowHeight;

		private Rectangle destRect;
		private List<Rectangle> frames;
		private int currentFrame;

		private double timeCounter;
		private double secondsPerFrame = 0.10;

		public MovingAnimatedSprite(Texture2D texture, Viewport viewport)
		{
			this.texture = texture;
			speed = -50f;
			windowHeight = viewport.Height;
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


		}
		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(texture, destRect, frames[currentFrame], Color.White);
		}

		public void Update(GameTime gameTime)
		{
			float time = (float)gameTime.ElapsedGameTime.TotalSeconds;
			destRect.Y -= 1;

			timeCounter += time;

			if (timeCounter >= secondsPerFrame)
			{
				timeCounter -= secondsPerFrame;
				currentFrame += 1;
				if(currentFrame == 2)
				{
					currentFrame = 0;
				}
			}
			if (destRect.Y < 0)
			{
				destRect.Y = windowHeight / 2 - destRect.Height / 2;
			}
		}
	}
}
