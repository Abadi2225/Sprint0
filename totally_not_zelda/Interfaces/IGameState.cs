using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Interfaces;

public interface IGameState
{
    public void Enter();
    public void Exit();
    public void LoadContent();
    public void Update(GameTime gameTime);
    public void Draw(SpriteBatch spriteBatch);
}