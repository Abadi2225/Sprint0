using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace sprint0.Interfaces
{
    public interface ISprite
    {
        void Update(GameTime gameTime);
        void Draw(GameTime gameTime, SpriteBatch spriteBatch, Texture2D image, Vector2 window, SpriteFont font);
    }
}