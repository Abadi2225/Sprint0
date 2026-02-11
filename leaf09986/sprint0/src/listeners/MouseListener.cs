using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace sprint0;

public class MouseListener : InputListener
{
    private bool isActive_ = true;

    // used to prevent a bug in linux where right mouse button is pressed when game starts
    private bool mb2ReleasedAtLeastOnce_ = false;

    public void onUpdate(Game game, GameClient client)
    {
        if (!isActive_) return;

        MouseState mouse = Mouse.GetState();

        if (!mb2ReleasedAtLeastOnce_ && mouse.RightButton == ButtonState.Released)
        {
            mb2ReleasedAtLeastOnce_ = true;
        }

        if (mouse.RightButton == ButtonState.Pressed && mb2ReleasedAtLeastOnce_)
        {
            Console.WriteLine("Exiting (MB2 pressed)");
            game.Exit();
            return;
        }
        if (!(mouse.LeftButton == ButtonState.Pressed))
        {
            return;
        }

        int halfX = game.Window.ClientBounds.X / 2;
        int halfY = game.Window.ClientBounds.Y / 2;
        if (mouse.Y < halfY)
        {
            if (mouse.X < halfX)
            {
                client.setMode(1);
            }
            else
            {
                client.setMode(2);
            }
        }
        else
        {
            if (mouse.X < halfX)
            {
                client.setMode(3);
            }
            else
            {
                client.setMode(4);
            }
        }
    }

    public void toggleInput(bool isActive)
    {
        isActive_ = isActive;
    }
}
