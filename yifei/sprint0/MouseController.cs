using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TheLegendOfZilda
{
	internal class MouseController : IController
	{
		private Dictionary<int, ICommand> controllerMappings;
		private MouseState previousState;
		private Game1 game;
		private ICommand quitCommand;

		public MouseController(Game1 game)
		{
			this.game = game;
			controllerMappings = new Dictionary<int, ICommand>
			{
				{ 1, new SetCommand(game, 1) }, 
                { 2, new SetCommand(game, 2) }, 
                { 3, new SetCommand(game, 3) }, 
                { 4, new SetCommand(game, 4) }  
            };
			quitCommand = new QuitCommand(game);
			previousState = Mouse.GetState();
		}

		public void Update(GameTime gameTime)
		{
			MouseState currentState = Mouse.GetState();

			if (currentState.LeftButton == ButtonState.Pressed &&
				previousState.LeftButton == ButtonState.Released)
			{
				int quadrant = SetQuadrant(currentState.X, currentState.Y);

				if (controllerMappings.ContainsKey(quadrant))
				{
					controllerMappings[quadrant].Execute();
				}
			}
			if (currentState.RightButton == ButtonState.Pressed &&
				previousState.RightButton == ButtonState.Released)
			{
				quitCommand.Execute();
			}

			previousState = currentState;
		}

		private int SetQuadrant(int x, int y)
		{
			int width = game.GraphicsDevice.Viewport.Width;
			int height = game.GraphicsDevice.Viewport.Height;

			if (x < width / 2 && y < height / 2) return 1;      
			if (x >= width / 2 && y < height / 2) return 2;     
			if (x < width / 2 && y >= height / 2) return 3;     
			return 4;                                          
		}
	}
}
