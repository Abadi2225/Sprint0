using sprint0.Interfaces;
using sprint0.Sprites;

namespace sprint0.Commands
{
    public class SetMovingStaticSpriteCommand : ICommand
    {
        public void Execute(Game1 game1)
        {
            ISprite movingStaticSprite = new MovingStaticSprite();
            game1.SetCurrentSprite(movingStaticSprite);
        }
    }
}