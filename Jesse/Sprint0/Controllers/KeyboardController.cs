using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Sprint.Interfaces;
using Sprint.Commands;
using Sprint.Controllers;

namespace Sprint.Controllers
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyCommands;
        private KeyboardState prevKeyState;

        public KeyboardController(Game1 game)
        {
            prevKeyState = Keyboard.GetState();
            
            keyCommands = new Dictionary<Keys, ICommand>
            {
                { Keys.D0, new QuitCommand(game) },
                { Keys.D1, new SetStateCommand(game, GameState.StaticNonAnimated) },
                { Keys.D2, new SetStateCommand(game, GameState.StaticAnimated) },
                { Keys.D3, new SetStateCommand(game, GameState.MovingNonAnimated) },
                { Keys.D4, new SetStateCommand(game, GameState.MovingAnimated) },
                { Keys.NumPad0, new QuitCommand(game)},
                { Keys.NumPad1, new SetStateCommand(game, GameState.StaticNonAnimated) },
                { Keys.NumPad2, new SetStateCommand(game, GameState.StaticAnimated) },
                { Keys.NumPad3, new SetStateCommand(game, GameState.MovingNonAnimated) },
                { Keys.NumPad4, new SetStateCommand(game, GameState.MovingAnimated) }
            };
        }

        public void Update()
        {
            KeyboardState keys = Keyboard.GetState();

            foreach (var pair in keyCommands)
            {
                if (WasPressed(pair.Key, keys))
                {
                    pair.Value.Execute(0);
                }
            }

            prevKeyState = keys;
        }

        private bool WasPressed(Keys key, KeyboardState current)
        {
            return current.IsKeyDown(key) && prevKeyState.IsKeyUp(key);
        }
    }
}