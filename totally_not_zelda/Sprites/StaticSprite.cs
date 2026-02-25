using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Sprites
{
    public class StaticSprite : IPositionedSprite
    {
        private Texture2D texture;
        private Vector2 pos;
        private Rectangle sourceRect;

        public Vector2 Position 
        { 
            get {return pos;} 
            set {pos = value;}
        }

        public Texture2D Texture => texture;

        public StaticSprite(Texture2D texture, Vector2 position, Rectangle source)
        {
            this.texture = texture;
            pos = position;
            sourceRect = source;

        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Vector2 drawPos = new Vector2(location.X - sourceRect.Width / 2, location.Y - sourceRect.Height / 2);
            spriteBatch.Draw(
                texture,                // texture
                drawPos,                // position
                sourceRect,             // sourceRectangle
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
