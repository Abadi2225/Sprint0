using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using sprint0.Commands;
using sprint0.Interfaces;
using System.Collections.Generic;


namespace sprint0.Controllers
{
    public class KeyboardController : IController
    {
        private Dictionary<Keys, ICommand> keyboardCommands;
        private KeyboardState previousKeyboardState;
        
        public KeyboardController()
        {
            keyboardCommands = new Dictionary<Keys, ICommand>();
            keyboardCommands[Keys.D0] = new QuitCommand();
            keyboardCommands[Keys.NumPad0] = new QuitCommand();
            keyboardCommands[Keys.D1] = new SetStaticSpriteCommand();
            keyboardCommands[Keys.NumPad1] = new SetStaticSpriteCommand();
            keyboardCommands[Keys.D2] = new SetAnimatedSpriteCommand();
            keyboardCommands[Keys.NumPad2] = new SetAnimatedSpriteCommand();
            keyboardCommands[Keys.D3] = new SetMovingStaticSpriteCommand();
            keyboardCommands[Keys.NumPad3] = new SetMovingStaticSpriteCommand();
            keyboardCommands[Keys.D4] = new SetMovingAnimatedSpriteCommand();
            keyboardCommands[Keys.NumPad4] = new SetMovingAnimatedSpriteCommand();
        }

        public void Update(GameTime gameTime, Game1 game1)
        {
            KeyboardState currentKeyboardState = Keyboard.GetState();
            
            foreach (var keyboardKey in keyboardCommands)
            {
                if (currentKeyboardState.IsKeyDown(keyboardKey.Key) &&
                    previousKeyboardState.IsKeyUp(keyboardKey.Key))
                {
                    keyboardKey.Value.Execute(game1);
                }
            }
            previousKeyboardState = currentKeyboardState;
        }
    }   
}