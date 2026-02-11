using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Sprites
{
    public class AnimatedSprite : ISprite
    {
        private Texture2D texture;
        private Vector2 pos;
        private Rectangle rect;
        private int frameCount;
        private int curFrame;
        private int[] frameXPositions;
        private float frameTime;
        private float elapsedTime;
        private int frameWidth;
        private int frameHeight;
        private int frameY;

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

        public AnimatedSprite(Texture2D texture, Vector2 position, int[] xPositions, int yPos, int spriteWidth, int spriteHeight, float frameTime)
        {
            this.texture = texture;
            pos = position;
            this.frameCount = xPositions.Length;
            frameXPositions = xPositions;
            this.frameTime = frameTime;
            curFrame = 0;
            elapsedTime = 0f;
            frameWidth = spriteWidth;
            frameHeight = spriteHeight;
            frameY = yPos;
            
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

        public int Update(GameTime gameTime)
        {
            elapsedTime += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (elapsedTime >= frameTime)
            {
                curFrame = (curFrame + 1) % frameCount;
                elapsedTime = 0f;
            }
            
            return curFrame;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(
                frameXPositions[curFrame],
                frameY,
                frameWidth,
                frameHeight
            );

            Vector2 drawPos = new Vector2(location.X - frameWidth / 2, location.Y - frameHeight / 2);

            spriteBatch.Draw(texture, drawPos, sourceRectangle, Color.White, 0f, Vector2.Zero, 2f, SpriteEffects.None, 0f);
            
        }
    }
}
