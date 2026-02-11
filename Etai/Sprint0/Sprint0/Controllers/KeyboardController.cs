using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

public class KeyboardController : IController
{
    private KeyboardState previousState;
    private Dictionary<Keys, ICommand> commands;

    public KeyboardController(Dictionary<Keys, ICommand> commands)
    {
        this.commands = commands;
    }

    public void Update()
    {
        KeyboardState current = Keyboard.GetState();

        foreach (var pair in commands)
        {
            if (current.IsKeyDown(pair.Key) && previousState.IsKeyUp(pair.Key))
            {
                pair.Value.Execute();
            }
        }

        previousState = current;
    }
}