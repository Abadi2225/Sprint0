using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Interfaces;

public interface IGameState
{
    void Enter();
    void Exit();
    void LoadContent();
    void Update(GameTime gameTime);
    void Draw(SpriteBatch spriteBatch);
}