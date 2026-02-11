using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace sprint0;

public interface ISprite
{
    public void render(Vector2 pos, SpriteBatch spriteBatch, ContentManager contentManager);
    public void advanceFrame();
}
