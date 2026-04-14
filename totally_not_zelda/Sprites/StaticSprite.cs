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
        private float? customScale;

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

        public StaticSprite(Texture2D texture, Vector2 position, Rectangle source, float scale)
        {
            this.texture = texture;
            pos = position;
            sourceRect = source;
            customScale = scale;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Draw(
                texture,                                      
                location,                                      
                sourceRect,                                     
                Color.White,                                     
                0.0f,                                            
                Vector2.Zero,                                    
                customScale ?? GameServices.ScaleFactor,        
                SpriteEffects.None,                             
                0.0f                                            
            );
        }
    }
}
