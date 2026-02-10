using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Interfaces;

namespace sprint0.Sprites
{
    public class StaticSprite: ISprite
    {
        private Rectangle sourceRect;

        public StaticSprite()
        {
            sourceRect = new Rectangle(35, 11, 15, 15);
        }

        public void Update(GameTime gameTime)
        {
            // Static so no Update
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D image, Vector2 window, SpriteFont font)
        {
            spriteBatch.Draw(
                image,
                window * 0.5f,
                sourceRect,
                Color.White,
                0f,
                new Vector2(sourceRect.Width,
                            sourceRect.Height) * 0.5f,
                5f,
                SpriteEffects.None,
                0f
            );
        }
    }
}