using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.UI
{
	internal class GameOverText
	{
		private readonly Texture2D sheet;

		private const int CharWidth = 8;
		private const int CharHeight = 8;
		private const int CharSpacing = 1;

		private readonly Rectangle GRect = new Rectangle(336, 40, CharWidth, CharHeight);
		private readonly Rectangle ARect = new Rectangle(496, 24, CharWidth, CharHeight);
		private readonly Rectangle MRect = new Rectangle(432, 40, CharWidth, CharHeight);
		private readonly Rectangle ERect = new Rectangle(560, 24, CharWidth, CharHeight);
		private readonly Rectangle ORect = new Rectangle(464, 40, CharWidth, CharHeight);
		private readonly Rectangle VRect = new Rectangle(576, 40, CharWidth, CharHeight);
		private readonly Rectangle RRect = new Rectangle(512, 40, CharWidth, CharHeight);

		public GameOverText(Texture2D sheet)
		{
			this.sheet = sheet;
		}

		public void Draw(SpriteBatch spriteBatch, Vector2 position, float scale)
		{
			Vector2 drawPos = position;

			DrawLetter(spriteBatch, GRect, drawPos, scale);
			drawPos.X += (CharWidth + CharSpacing) * scale;

			DrawLetter(spriteBatch, ARect, drawPos, scale);
			drawPos.X += (CharWidth + CharSpacing) * scale;

			DrawLetter(spriteBatch, MRect, drawPos, scale);
			drawPos.X += (CharWidth + CharSpacing) * scale;

			DrawLetter(spriteBatch, ERect, drawPos, scale);
			drawPos.X += (CharWidth + CharSpacing) * scale;

			drawPos.X += (CharWidth + CharSpacing) * scale; 

			DrawLetter(spriteBatch, ORect, drawPos, scale);
			drawPos.X += (CharWidth + CharSpacing) * scale;

			DrawLetter(spriteBatch, VRect, drawPos, scale);
			drawPos.X += (CharWidth + CharSpacing) * scale;

			DrawLetter(spriteBatch, ERect, drawPos, scale);
			drawPos.X += (CharWidth + CharSpacing) * scale;

			DrawLetter(spriteBatch, RRect, drawPos, scale);
		}

		private void DrawLetter(SpriteBatch spriteBatch, Rectangle source, Vector2 position, float scale)
		{
			spriteBatch.Draw(
				sheet,
				position,
				source,
				Color.White,
				0f,
				Vector2.Zero,
				scale,
				SpriteEffects.None,
				0f
			);
		}
	}
}