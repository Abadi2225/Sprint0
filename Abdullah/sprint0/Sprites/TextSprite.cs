using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Interfaces;

namespace sprint0.Sprites
{
    public class TextSprite: ISprite
    {
        private string text;

        public TextSprite()
        {
            text = "Credits\nProgram Made By: Abdullah Felemban\nSprites from: https://www.spriters-resource.com/nes/legendofzelda/asset/8366/";
        }

        public void Update(GameTime gameTime)
        {
            // No Update
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D image, Vector2 window, SpriteFont font)
        {
            Vector2 textSize = font.MeasureString(text);
            Vector2 position = new Vector2(
                (window.X - textSize.X) / 2,
                window.Y - textSize.Y - 30
            );
            spriteBatch.DrawString(font, text, position, Color.White);
        }
    }
}