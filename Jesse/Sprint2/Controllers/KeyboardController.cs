using Sprint.Interfaces;
using Sprint.Commands;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace Sprint.Controllers
{
    public class KeyboardController : IController
    {
        private KeyboardState previous;
        private KeyboardState current;

        public KeyboardController(Game1 game)
        {
            current = Keyboard.GetState();
        }

        public void Update()
        {
            previous = current;
            current = Keyboard.GetState();
        }

        public bool IsKeyPressed(Keys key)
        {
            return current.IsKeyDown(key) && previous.IsKeyUp(key);
        }

        public bool IsKeyDown(Keys key)
        {
            return current.IsKeyDown(key);
        }
        public bool IsKeyReleased(Keys key)
        {
            return current.IsKeyUp(key) && previous.IsKeyDown(key);
        }

        public bool IsKeyUp(Keys key)
        {
            return current.IsKeyUp(key);
        }
    }
}