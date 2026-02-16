using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Interfaces
{
    public interface ISprite
    {
        public void Draw(SpriteBatch spriteBatch, Vector2 location);

        public int Update(GameTime gameTime);
    }
}