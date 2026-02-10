using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Interfaces;

namespace sprint0.Sprites
{
    public class AnimatedSprite: ISprite
    {
        private Rectangle[] frames;
        private int currentFrame;
        private float timer;
        private float frameTime;

        public AnimatedSprite()
        {
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
            timer += gameTime.ElapsedGameTime.Milliseconds;
            if (timer > frameTime)
            {
                currentFrame = (currentFrame + 1) % frames.Length;
                timer = 0;
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D image, Vector2 window, SpriteFont font)
        {
            spriteBatch.Draw(
                image,
                window * 0.5f,
                frames[currentFrame],
                Color.White,
                0f,
                new Vector2(frames[currentFrame].Width,
                            frames[currentFrame].Height) * 0.5f,
                5f,
                SpriteEffects.None,
                0f
            );
        }
    }
}