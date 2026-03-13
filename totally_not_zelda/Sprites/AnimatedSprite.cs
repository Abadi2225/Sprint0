using System.Data.SqlTypes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Sprites
{
    public class AnimatedSprite : IPositionedSprite
    {
        private Texture2D texture;
        private Vector2 pos;
        private Rectangle rect;
        private readonly int frameCount;
        private int curFrame;
        private readonly int[] sheetXPositions;
        private readonly float frameTime;
        private float elapsedTime;
        private readonly int frameWidth;
        private readonly int frameHeight;
        private readonly int sheetY;

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

        public AnimatedSprite(Texture2D texture, Vector2 position, int[] sheetXPositions, int sheetYPos, int spriteWidth, int spriteHeight, float frameTime)
        {
            this.texture = texture;
            pos = position;
            frameCount = sheetXPositions.Length;
            this.sheetXPositions = sheetXPositions;
            this.frameTime = frameTime;
            curFrame = 0;
            elapsedTime = 0f;
            frameWidth = spriteWidth;
            frameHeight = spriteHeight;
            sheetY = sheetYPos;
            
            UpdateRect();
        }

        private void UpdateRect()
        {
			rect = new Rectangle(
				(int)(pos.X),
				(int)(pos.Y),
				frameWidth * (int)GameServices.ScaleFactor,
				frameHeight * (int)GameServices.ScaleFactor
			);
		}
        
        public void SetFrame(int frame)
        {
            curFrame = frame % frameCount;
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


            //white is the default no color mask
            spriteBatch.Draw(
                texture,                    // texture
                location,                   // position
                sourceRectangle,            // sourceRectangle
                Color.White,                // color
                0.0f,                       // rotation
                Vector2.Zero,                     // origin
                GameServices.ScaleFactor,   // scale
                SpriteEffects.None,         // effects
                0.0f                        // layerDepth
            );
        }
    }
}
