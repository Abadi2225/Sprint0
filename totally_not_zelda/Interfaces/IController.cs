using Microsoft.Xna.Framework.Input;

namespace Sprint.Interfaces;

public interface IController
    {
        void Update();
        bool IsKeyDown(Keys key);
        bool IsKeyPressed(Keys key);
        bool IsKeyReleased(Keys key);
    }