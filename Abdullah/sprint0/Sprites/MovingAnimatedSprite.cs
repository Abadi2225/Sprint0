using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Interfaces;

namespace sprint0.Sprites
{
    public class MovingAnimatedSprite: ISprite
    {
        private float speed;
        private int direction;
        private Vector2 position;
        private bool initialized;
        private float maxWidth;
        private Rectangle[] frames;
        private int currentFrame;
        private float timer;
        private float frameTime;
        private SpriteEffects flip;

        public MovingAnimatedSprite()
        {
            speed = 150f;
            direction = 1;   // 1 = right, -1 = left
            initialized = false;
            flip = SpriteEffects.None;

            frames = new Rectangle[]
            {
                new Rectangle(35, 11, 15, 15),
                new Rectangle(52, 11, 15, 15),
            };
            
            currentFrame = 0;
            timer = 0f;
            frameTime = 150;
        }

        public void Update(GameTime gameTime)
        {
            if (!initialized) return;

            position.X += speed * direction * (float)gameTime.ElapsedGameTime.TotalSeconds;
            timer += gameTime.ElapsedGameTime.Milliseconds;

            if (position.X < 27 || position.X > maxWidth - 27)
            {
                direction *= -1;
                flip = flip == SpriteEffects.None ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
            }

            if (timer > frameTime)
            {
                currentFrame = (currentFrame + 1) % frames.Length;
                timer = 0;
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D image, Vector2 window, SpriteFont font)
        {
            if (!initialized) // To start at a the center of the screen
            {
                position = window * 0.5f;
                maxWidth = window.X;
                initialized = true;
            }

            spriteBatch.Draw(
                image,
                position,
                frames[currentFrame],
                Color.White,
                0f,
                new Vector2(frames[currentFrame].Width,
                            frames[currentFrame].Height) * 0.5f,
                5f,
                flip,
                0f
            );
        }
    }
}