using Microsoft.Xna.Framework.Input;

namespace Sprint.Interfaces;

public interface IController
{
    public void Update();
    public void Reset();
    public bool IsKeyDown(Keys key);
    public bool IsKeyPressed(Keys key);
    public bool IsKeyReleased(Keys key);
}