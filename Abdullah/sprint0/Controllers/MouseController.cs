using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using sprint0.Commands;
using sprint0.Interfaces;

namespace sprint0.Controllers
{
    public class MouseController : IController
    {
        private MouseState previousMouseState;
        private float width;
        private float height;

        public MouseController(Vector2 window)
        {
            width = window.X;
            height = window.Y;
        }

        public void Update(GameTime gameTime, Game1 game1)
        {
            ICommand command;
            MouseState currentMouseState = Mouse.GetState();
            bool leftClicked = currentMouseState.LeftButton == ButtonState.Pressed &&
                               previousMouseState.LeftButton == ButtonState.Released;
            bool rightClicked = currentMouseState.RightButton == ButtonState.Pressed &&
                               previousMouseState.RightButton == ButtonState.Released;

            if (rightClicked)
            {
                command = new QuitCommand();
                command.Execute(game1);
            }
            else if (leftClicked && currentMouseState.Position.X < width / 2 && 
                    currentMouseState.Position.Y < height / 2)
            {
                command = new SetStaticSpriteCommand();
                command.Execute(game1);
            }
            else if (leftClicked && currentMouseState.Position.X > width / 2 && 
                currentMouseState.Position.Y < height / 2)
            {
                command = new SetAnimatedSpriteCommand();
                command.Execute(game1);
            }
            else if (leftClicked && currentMouseState.Position.X < width / 2 && 
                currentMouseState.Position.Y > height / 2)
            {
                command = new SetMovingStaticSpriteCommand();
                command.Execute(game1);
            }
            else if (leftClicked && currentMouseState.Position.X > width / 2 && 
                currentMouseState.Position.Y > height / 2)
            {
                command = new SetMovingAnimatedSpriteCommand();
                command.Execute(game1);
            }
            previousMouseState = currentMouseState;
        }
    }
}