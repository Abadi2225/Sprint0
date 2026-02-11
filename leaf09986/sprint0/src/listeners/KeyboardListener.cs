using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace sprint0;

public class KeyboardListener : InputListener
{
    private bool isActive_ = true;

    public void onUpdate(Game game, GameClient client)
    {
        if (!isActive_) return;
        KeyboardState kb = Keyboard.GetState();
        if (kb.IsKeyDown(Keys.Escape) || kb.IsKeyDown(Keys.D0))
        {
            Console.WriteLine("Exiting (Key B0 Pressed)");
            game.Exit();
            return;
        }
        if (kb.IsKeyDown(Keys.D1))
        {
            client.setMode(1);
        }
        if (kb.IsKeyDown(Keys.D2))
        {
            client.setMode(2);
        }
        if (kb.IsKeyDown(Keys.D3))
        {
            client.setMode(3);
        }
        if (kb.IsKeyDown(Keys.D4))
        {
            client.setMode(4);
        }
    }

    public void toggleInput(bool isActive)
    {
        isActive_ = isActive;
    }
}
