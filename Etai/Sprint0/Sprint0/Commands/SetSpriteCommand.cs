using System;
using Sprint0;

public class SetSpriteCommand : ICommand
{
    private Game1 game;
    private ISprite newSprite;

    public SetSpriteCommand(Game1 game, ISprite newSprite)
    {
        this.game = game;
        this.newSprite = newSprite;
    }

    public void Execute()
    {
        // Assuming you have a method in Game1 to set the current sprite
        game.SetCurrentSprite(newSprite);
    }
}