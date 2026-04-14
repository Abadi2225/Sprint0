using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Character
{
	internal class DeathSparkle : ISprite
	{
		private readonly Texture2D texture;
		private readonly Rectangle sourceRect;
		private readonly double switchInterval;

		private int currentState;
		private double timer;

		public Vector2 Position { get; set; }

		public DeathSparkle(Texture2D texture, Rectangle sourceRect, double switchInterval)
		{
			this.texture = texture;
			this.sourceRect = sourceRect;
			this.switchInterval = switchInterval;

			currentState = 0;
			timer = 0;
		}

		public void Reset()
		{
			currentState = 0;
			timer = 0;
		}

		public void Update(GameTime gameTime)
		{
			timer += gameTime.ElapsedGameTime.TotalSeconds;

			if (timer >= switchInterval)
			{
				currentState = 1 - currentState;
				timer = 0;
			}

		}

		public void Draw(SpriteBatch spriteBatch, Vector2 location)
		{
			float scale = currentState == 0 ? 2f : 4f;

			Color tint = currentState == 0
				? new Color(180, 220, 255)
				: Color.White;

			Vector2 origin = new Vector2(sourceRect.Width / 2f, sourceRect.Height / 2f);

			spriteBatch.Draw(
				texture,
				location,
				sourceRect,
				tint,
				0f,
				origin,
				scale,
				SpriteEffects.None,
				0f
			);
		}
	}
}