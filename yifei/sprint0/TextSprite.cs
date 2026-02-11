using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TheLegendOfZilda
{
	internal class TextSprite : ISprite
	{
		private SpriteFont font;
		private string text;
		private Vector2 position;
		private Color color;

		public TextSprite(SpriteFont font)
		{
			this.font = font;
			this.text = "Program Made By: Yifei Yu\nSprite from: https://osu.instructure.com/courses/201924/files/folder/\nMario%20spritesheets%20in%20different%20formats?preview=85603363";
			this.position = new Vector2(150, 330);
			color = Color.Black;
		}

		public void Update(GameTime gameTime)
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.DrawString(font, text, position, color);
		}
	}
}
