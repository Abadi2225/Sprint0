using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Sprites
{
    public class TextSprite : ISprite
    {
        private Texture2D texture;
        private Vector2 pos;
        private Rectangle rect;

        public Vector2 Position 
        { 
            get => pos; 
            set => pos = value; 
        }

        public Texture2D Texture => texture;

        public Rectangle Rect => rect;

        public TextSprite(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            pos = position;

            if (texture != null)
            {
                rect = new Rectangle
                (
                    (int)(position.X - texture.Width / 2),
                    (int)(position.Y - texture.Height / 2),
                    texture.Width,
                    texture.Height
                );
            }
        }

        public int Update(GameTime gameTime)
        {
            return 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (texture != null)
            {
                spriteBatch.Draw(texture, location, Color.White);
            }
        }
    }
}
