using Sprint.Interfaces;
using Sprint.Commands;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Sprint.InputHandling;

public class MenuInputHandler : IInputHandler
{
    private Dictionary<Keys, ICommand> commands;

    public MenuInputHandler()
    {
        // Constructor can be used to initialize any necessary references for the commands
        commands = new Dictionary<Keys, ICommand>
        {
            {Keys.Enter, new SetStateCommand(new GameplayState())},
            {Keys.Q, new QuitCommand()}
        };
        
    }
    public void HandleInput()
    {
        foreach (var command in commands)
        {
            if (GameServices.KeyInput.IsKeyPressed(command.Key))
            {
                command.Value.Execute();
            }
        }
    }
}