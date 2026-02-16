using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;
using Sprint.Interfaces;
using Sprint.Commands;
using Sprint.Controllers;

namespace Sprint.Controllers
{
    public class MouseController : IController
    {
        private Game1 game;
        private MouseState prevMouse;
        private int screenWidth;
        private int screenHeight;
        private Dictionary<string, ICommand> clickCommands;

        public MouseController(Game1 game, int width, int height)
        {
            this.game = game;
            screenWidth = width;
            screenHeight = height;
            prevMouse = Mouse.GetState();
            
            clickCommands = new Dictionary<string, ICommand>
            {
                { "TopLeft", new SetStateCommand(game, GameState.StaticNonAnimated) },
                { "TopRight", new SetStateCommand(game, GameState.StaticAnimated) },
                { "BottomLeft", new SetStateCommand(game, GameState.MovingNonAnimated) },
                { "BottomRight", new SetStateCommand(game, GameState.MovingAnimated) },
                { "RightClick", new QuitCommand(game) }
            };
        }

        public void Update()
        {
            MouseState mouse = Mouse.GetState();

            if (mouse.RightButton == ButtonState.Pressed && 
                prevMouse.RightButton == ButtonState.Released)
            {
                clickCommands["RightClick"].Execute(0);
            }

            if (mouse.LeftButton == ButtonState.Pressed && 
                prevMouse.LeftButton == ButtonState.Released)
            {
                int midX = screenWidth / 2;
                int midY = screenHeight / 2;

                string quadrant = GetQuadrant(mouse.X, mouse.Y, midX, midY);
                if (clickCommands.ContainsKey(quadrant))
                {
                    clickCommands[quadrant].Execute(0);
                }
            }

            prevMouse = mouse;
        }

        private string GetQuadrant(int x, int y, int midX, int midY)
        {
            if (x < midX && y < midY)
                return "TopLeft";
            else if (x >= midX && y < midY)
                return "TopRight";
            else if (x < midX && y >= midY)
                return "BottomLeft";
            else
                return "BottomRight";
        }
    }
}