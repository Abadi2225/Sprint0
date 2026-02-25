using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Sprites
{
    public class DirectionalAnimatedSprite : IPositionedSprite
    {
        private Texture2D texture;
        private Vector2 pos;
        private Rectangle rect;
        private int frameCount;
        private int curFrame;
        private int[] sheetXPositions;
        private float frameTime;
        private float elapsedTime;
        private int frameWidth;
        private int frameHeight;
        private int sheetY;
        private bool flipHorizontal;

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

        public DirectionalAnimatedSprite(Texture2D texture, Vector2 position, int[] xPositions, int yPos, 
                              int spriteWidth, int spriteHeight, float frameTime, bool flipHorizontal = false)
        {
            this.texture = texture;
            pos = position;
            this.frameCount = xPositions.Length;
            sheetXPositions = xPositions;
            this.frameTime = frameTime;
            curFrame = 0;
            elapsedTime = 0f;
            frameWidth = spriteWidth;
            frameHeight = spriteHeight;
            sheetY = yPos;
            this.flipHorizontal = flipHorizontal;
            
            UpdateRect();
        }

        public void UpdateFrames(int[] xPositions, bool flipHorizontal)
        {
            sheetXPositions = xPositions;
            frameCount = xPositions.Length;
            this.flipHorizontal = flipHorizontal;
            curFrame = 0;
            elapsedTime = 0f;
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
            elapsedTime += (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (elapsedTime >= frameTime)
            {
                curFrame = (curFrame + 1) % frameCount;
                elapsedTime = 0f;
            }       
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Rectangle sourceRectangle = new Rectangle(
                sheetXPositions[curFrame],
                sheetY,
                frameWidth,
                frameHeight
            );

            SpriteEffects effect = flipHorizontal ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
            Vector2 origin = new Vector2(frameWidth / 2, frameHeight / 2);
            
            spriteBatch.Draw(
                texture,                // texture
                location,               // position
                sourceRectangle,        // sourceRectangle
                Color.White,            // color
                0.0f,                   // rotation
                origin,                 // origin
                3.0f,                   // scale
                effect,                 // effects
                0.0f                    // layerDepth
            );
        }
    }
}