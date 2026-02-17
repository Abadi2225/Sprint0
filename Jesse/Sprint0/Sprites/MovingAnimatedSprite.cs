using System;
using System.Diagnostics.Contracts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Sprites
{
    public class MovingAnimatedSprite : ISprite
    {
        public Texture2D texture;
        public Vector2 pos;
        public Rectangle rect;
        private int frameCount;
        private int curFrame;
        private int[] sheetXPositions;
        private float frameTime;
        private float elapsedTime;
        private int frameWidth;
        private int frameHeight;
        private int frameY;
        private float speed;
        private float minX;
        private float maxX;
        private bool movingRight;

        public Vector2 Position
        {
            get => pos;
            set
            {
                pos = value;
                UpdateRect();
            }
        }

        public Texture2D Texture => texture;

        public Rectangle Rect => rect;

        public MovingAnimatedSprite(
            Texture2D texture, 
            Vector2 startPosition, 
            int[] sheetXPositions,
            int frameY,
            int spriteWidth,
            int spriteHeight,
            float frameDuration,
            float moveSpeed = 150f, 
            float range = 300f)
        {
            this.texture = texture;
            pos = startPosition;
            this.frameCount = sheetXPositions.Length;
            this.sheetXPositions = sheetXPositions;
            this.frameTime = frameDuration;
            curFrame = 0;
            elapsedTime = 0f;
            frameWidth = spriteWidth;
            frameHeight = spriteHeight;
            this.frameY = frameY;
            this.speed = moveSpeed;
            minX = startPosition.X - range / 2;
            maxX = startPosition.X + range / 2;
            movingRight = true;

            UpdateRect();
        }

        private void UpdateRect()
        {
            rect = new Rectangle(
                (int)(pos.X - frameWidth /2),
                (int)(pos.Y - frameHeight / 2),
                frameWidth,
                frameHeight
            );
        }

        public int Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            elapsedTime += deltaTime;
            if (elapsedTime >= frameTime)
            {
                curFrame = (curFrame + 1) % frameCount;
                elapsedTime = 0f;
            }

            if (movingRight)
            {
                pos.X += speed * deltaTime;
                if (pos.X >= maxX)
                {
                    pos.X = maxX;
                    movingRight = false;
                }
            }
            else
            {
                pos.X -= speed * deltaTime;
                if (pos.X <= minX)
                {
                    pos.Y = minX;
                    movingRight = true;
                }
            }
            
            UpdateRect();
            return curFrame;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(
                sheetXPositions[curFrame],
                frameY,
                frameWidth,
                frameHeight
            );

            SpriteEffects effect = movingRight ? SpriteEffects.None : SpriteEffects.FlipHorizontally;

            Vector2 drawPos = new Vector2(location.X - frameWidth / 2, location.Y - frameHeight / 2);
            spriteBatch.Draw(texture, drawPos, sourceRectangle, Color.White, 0f, Vector2.Zero, 2f, effect, 0f);
        }
    }
}