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
        private uint colorMask = 0xFFFFFFFF;  // RGBA

        public Vector2 Position
        {
            get { return pos; }
            set { pos = value; }
        }

        public Texture2D Texture => texture;

        public void SetColorMask(uint mask) => colorMask = mask;

        public StaticSprite(Texture2D texture, Vector2 position, Rectangle source, uint mask = 0xFFFFFFFF)
        {
            this.texture = texture;
            pos = position;
            sourceRect = source;
            this.colorMask = mask;
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
                getColor(this.colorMask),
                0.0f,
                Vector2.Zero,
                customScale ?? GameServices.ScaleFactor,
                SpriteEffects.None,
                0.0f
            );
        }

        private static Color getColor(uint colorMask)
        {
            byte r = (byte)((colorMask & 0xFF000000) >> 24);
            byte g = (byte)((colorMask & 0xFF0000) >> 16);
            byte b = (byte)((colorMask & 0xFF00) >> 8);
            byte a = (byte)((colorMask & 0xFF));
            return new Color(r, g, b, a);
        }
    }
}
