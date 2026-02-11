using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TheLegendOfZilda
{
    internal class MovingSprite : ISprite
{
		private Texture2D texture;
		private Rectangle destRect;
		private Rectangle sourceRect;
        private float speed;
        private int windowHeight;

		public MovingSprite(Texture2D texture, Viewport viewport)
        {
            this.texture = texture;
			
			sourceRect = new Rectangle(175, 48, 22, 37);
            speed = -50f;
			windowHeight = viewport.Height;

			destRect = new Rectangle(
			viewport.Width / 2 - sourceRect.Width / 2,
			viewport.Height / 2 - sourceRect.Height / 2,
			sourceRect.Width,
			sourceRect.Height
			);


		}
		public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, destRect, sourceRect, Color.White);
        }

        public void Update(GameTime gameTime)
        {
			float time = (float)gameTime.ElapsedGameTime.TotalSeconds;
			destRect.Y -= 1;

			if (destRect.Y < 0)
			{
				destRect.Y = windowHeight / 2 - destRect.Height / 2;
			}
		}
}
}
