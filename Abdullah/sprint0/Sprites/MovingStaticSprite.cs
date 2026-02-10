using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Interfaces;

namespace sprint0.Sprites
{
    public class MovingStaticSprite: ISprite
    {
        private Rectangle sourceRect;
        private float speed;
        private int direction;
        private Vector2 position;
        private bool initialized;
        private float maxHeight;
        
        public MovingStaticSprite()
        {
            sourceRect = new Rectangle(191, 185, 15, 15);
            speed = 150f;
            direction = 1;   // 1 = down, -1 = up
            initialized = false;
        }
        
        public void Update(GameTime gameTime)
        {
            if (!initialized) return;

            position.Y += speed * direction * (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (position.Y < 27 || position.Y > maxHeight - 27)
            {
                direction *= -1;
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D image, Vector2 window, SpriteFont font)
        {
            if (!initialized) // To start at a the center of the screen
            {
                position = window * 0.5f;
                maxHeight = window.Y;
                initialized = true;
            }

            spriteBatch.Draw(
                image,
                position,
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