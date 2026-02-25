using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Sprites
{
    public class MovingSprite : IPositionedSprite
    {
        public Texture2D texture;
        public Vector2 pos;
        public Rectangle rect;
        private int frameCount;
        private int curFrame;
        private int[] downFrameXPositions;
        private int[] upFrameXPositions;
        private float frameTime;
        private float elapsedTime;
        private int frameWidth;
        private int frameHeight;
        private int frameY;
        private float speed;
        private float minY;
        private float maxY;
        private bool goingDown;

        public Vector2 Position 
        { 
            get { return pos; }
            set 
            { 
                pos = value;
                UpdateRect();
            }
        }

        public Texture2D Texture { get { return texture; } }
        
        public Rectangle Rect { get { return rect; } }

       public MovingSprite(Texture2D tex, Vector2 start, int[] downXPositions, int[] upXPositions, int yPos,
                   int spriteWidth, int spriteHeight, float frameDuration,
                   float moveSpeed = 100f, float range = 200f)
{
            texture = tex;
            pos = start;
            frameCount = downXPositions.Length;
            downFrameXPositions = downXPositions;
            upFrameXPositions = upXPositions;
            frameTime = frameDuration;
            curFrame = 0;
            elapsedTime = 0f;
            frameWidth = spriteWidth;
            frameHeight = spriteHeight;
            frameY = yPos;
            speed = moveSpeed;
            minY = start.Y - range / 2;
            maxY = start.Y + range / 2;
            goingDown = true;
            
            UpdateRect();
        }

        private void UpdateRect()
        {
            rect = new Rectangle(
                (int)(pos.X - frameWidth / 2),
                (int)(pos.Y - frameHeight / 2),
                frameWidth,
                frameHeight
            );
        }

        public void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            elapsedTime += dt;
            if (elapsedTime >= frameTime)
            {
                curFrame = (curFrame + 1) % frameCount;
                elapsedTime = 0f;
            }

            if (goingDown)
            {
                pos.Y += speed * dt;
                if (pos.Y >= maxY)
                {
                    pos.Y = maxY;
                    goingDown = false;
                }
            }
            else
            {
                pos.Y -= speed * dt;
                if (pos.Y <= minY)
                {
                    pos.Y = minY;
                    goingDown = true;
                }
            }
            
            UpdateRect();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            int[] currentFrames = goingDown ? downFrameXPositions : upFrameXPositions;
    
            Rectangle source = new Rectangle(
                currentFrames[curFrame],
                frameY,
                frameWidth,
                frameHeight
    );

            Vector2 drawPos = new Vector2(location.X - frameWidth / 2, location.Y - frameHeight / 2);
            spriteBatch.Draw(
                texture,                // texture
                drawPos,                // position
                source,                 // sourceRectangle
                Color.White,            // color
                0.0f,                   // rotation
                Vector2.Zero,           // origin
                3.0f,                   // scale
                SpriteEffects.None,     // effects
                0.0f                    // layerDepth
            );
        }
    }
}