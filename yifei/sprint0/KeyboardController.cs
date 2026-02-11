using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegendOfZilda
{
    internal class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private KeyboardState previousState;

        public KeyboardController(Game1 game)
        {
			controllerMappings = new Dictionary<Keys, ICommand>
			{
                // quit
                { Keys.D0, new QuitCommand(game) },
				{ Keys.NumPad0, new QuitCommand(game) },

                // sprite switching
                { Keys.D1, new SetCommand(game, 1) },
				{ Keys.D2, new SetCommand(game, 2) },
				{ Keys.D3, new SetCommand(game, 3) },
				{ Keys.D4, new SetCommand(game, 4) },

				{ Keys.NumPad1, new SetCommand(game, 1) },
				{ Keys.NumPad2, new SetCommand(game, 2) },
				{ Keys.NumPad3, new SetCommand(game, 3) },
				{ Keys.NumPad4, new SetCommand(game, 4) },
			};
			previousState = Keyboard.GetState();

        }

		public void Update(GameTime gametime) 
        {
            KeyboardState currentState = Keyboard.GetState();

			foreach (Keys key in controllerMappings.Keys)
			{
				if (currentState.IsKeyDown(key) && previousState.IsKeyUp(key))
				{
					controllerMappings[key].Execute();
				}
			}

            previousState = currentState;
		}
    }
}
