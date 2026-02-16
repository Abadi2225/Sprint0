using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Sprites
{
    public class StaticSprite : ISprite
    {
        private Texture2D texture;
        private Vector2 pos;
        private Rectangle sourceRect;
        private Rectangle rect;

        public Vector2 Position 
        { 
            get {return pos;} 
            set {pos = value;}
        }

        public Texture2D Texture => texture;

        public Rectangle Rect => rect;

        public StaticSprite(Texture2D texture, Vector2 position, Rectangle source)
        {
            this.texture = texture;
            pos = position;
            sourceRect = source;

            rect = new Rectangle
            (
                (int)(position.X - texture.Width / 2),
                (int)(position.Y - texture.Height / 2),
                texture.Width,
                texture.Height
            );

        }

        public int Update(GameTime gameTime)
        {
            return 0;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Vector2 drawPos = new Vector2(location.X - sourceRect.Width / 2, location.Y - sourceRect.Height / 2);
            spriteBatch.Draw(texture, drawPos, sourceRect, Color.White, 0f, Vector2.Zero, 2f, SpriteEffects.None, 0f);
        }
    }
}
