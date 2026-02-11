using Microsoft.Xna.Framework.Input;
public class MouseController : IController
{
    // commands[0] = static sprite
    // commands[1] = animated sprite
    // commands[2] = moving sprite
    // commands[3] = moving animated sprite
    // commands[4] = quit
    private ICommand[] commands;
    private MouseState previousState;

    private int windowWidth;
    private int windowHeight;

    public MouseController(int windowWidth, int windowHeight, ICommand[] commands)
    {
        this.windowWidth = windowWidth;
        this.windowHeight = windowHeight;
        this.commands = commands;
    }

    public void Update()
    {
        MouseState current = Mouse.GetState();

        // Left click (edge detection)
        if (current.LeftButton == ButtonState.Pressed &&
            previousState.LeftButton == ButtonState.Released)
        {
            int midX = windowWidth / 2;
            int midY = windowHeight / 2;

            if (current.X < midX && current.Y < midY)
                commands[0].Execute();      // static
            else if (current.X >= midX && current.Y < midY)
                commands[1].Execute();      // animated
            else if (current.X < midX && current.Y >= midY)
                commands[2].Execute();      // moving
            else
                commands[3].Execute();      // moving + animated
        }

        // Right click
        if (current.RightButton == ButtonState.Pressed &&
            previousState.RightButton == ButtonState.Released)
        {
            commands[4].Execute();          // quit
        }

        previousState = current;
    }
}