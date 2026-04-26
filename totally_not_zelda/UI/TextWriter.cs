using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.UI
{
	internal class TextWriter : IUIElement
	{
		private const int CharWidth = 8;
		private const int CharSpacing = 1;

		private int printedCharacters;
		private double timer;

		private readonly Texture2D fontsheet;
		private readonly LetterFactory letterFactory;
		private readonly string text;
		private readonly Vector2 position;
		private readonly float scale;
		private readonly bool effect;

		public TextWriter(Texture2D sheet, string text, Vector2 position, float scale, bool effect)
		{
			this.fontsheet = sheet;
			this.text = text;
			this.position = position;
			this.scale = scale;
			this.effect = effect;

			letterFactory = new LetterFactory();
			printedCharacters = effect ? 0 : text.Length;
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			Vector2 drawPos = position;

			for (int i = 0; i < printedCharacters; i++)
			{

				char c = text[i];

				if (c == ' ')
				{
					drawPos.X += (CharWidth + CharSpacing) * scale;
					continue;
				}

				if (c != ' ')
				{
					Rectangle charSprite = letterFactory.GetLetter(c);

					if (charSprite != Rectangle.Empty)
					{
						spriteBatch.Draw(
							fontsheet,
							drawPos,
							charSprite,
							Color.White,
							0f,
							Vector2.Zero,
							scale,
							SpriteEffects.None,
							0f
						);
					}
					drawPos.X += (CharWidth + CharSpacing) * scale;
				}

			}
		}

		public void Update(GameTime gameTime)
		{
			if (!effect) return;

			if (printedCharacters >= text.Length) return;

			timer += gameTime.ElapsedGameTime.TotalSeconds;

			if (timer >= 0.05)
			{
				printedCharacters++;
				timer = 0;
			}
		}

		public static TextWriter CreateGameOverText(Texture2D fontSheet)
		{
			return new TextWriter(
				fontSheet,
				"GAME OVER",
				new Vector2(260f, 300f),
				3f,
				false
			);
		}

		public static TextWriter CreateNPCText1(Texture2D fontSheet)
		{
			return new TextWriter(
				fontSheet,
				"EASTMOST PENNINSULA",
				new Vector2(140f, 250f),
				3f,
				true
			);
		}

		public static TextWriter CreateNPCText2(Texture2D fontSheet)
		{
			return new TextWriter(
				fontSheet,
				"IS THE SECRET",
				new Vector2(220f, 290f),
				3f,
				true
			);
		}
	}
}