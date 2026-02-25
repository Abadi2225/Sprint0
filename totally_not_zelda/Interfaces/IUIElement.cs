using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Interfaces
{
    public interface IUIElement
    {
        public void Draw(SpriteBatch spriteBatch);

        public void Update(GameTime gameTime);
    }
}