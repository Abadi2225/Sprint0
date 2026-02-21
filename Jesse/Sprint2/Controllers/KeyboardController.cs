using Sprint.Interfaces;
using Sprint.Commands;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace Sprint.Controllers
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyCommands;
        private KeyboardState prevKeyState;
        private Game1 game;

        public KeyboardController(Game1 game)
        {
            this.game = game;
            prevKeyState = Keyboard.GetState();
            keyCommands = new Dictionary<Keys, ICommand>();

            InitializeKeyMapping();
        }

        private void InitializeKeyMapping()
        {
            keyCommands[Keys.D0] = new QuitCommand(game);
            keyCommands[Keys.NumPad0] = new QuitCommand(game);
            keyCommands[Keys.O] = new CycleEnemyCommand(game, true);
            keyCommands[Keys.P] = new CycleEnemyCommand(game, false);
        }

        public void Update()
        {
            KeyboardState keys = Keyboard.GetState();

            foreach (var key in keyCommands.Keys)
            {
                if (keys.IsKeyDown(key) && prevKeyState.IsKeyUp(key))
                {
                    keyCommands[key].Execute(0);
                }
            }

            prevKeyState = keys;
        }
    }
}