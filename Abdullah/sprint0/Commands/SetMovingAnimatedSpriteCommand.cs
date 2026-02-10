using sprint0.Interfaces;
using sprint0.Sprites;

namespace sprint0.Commands
{
    public class SetMovingAnimatedSpriteCommand : ICommand
    {
        public void Execute(Game1 game1)
        {
            ISprite movingAnimatedSprite = new MovingAnimatedSprite();
            game1.SetCurrentSprite(movingAnimatedSprite);
        }
    }
}