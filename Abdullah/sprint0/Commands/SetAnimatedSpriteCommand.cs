using sprint0.Interfaces;
using sprint0.Sprites;

namespace sprint0.Commands
{
    public class SetAnimatedSpriteCommand : ICommand
    {
        public void Execute(Game1 game1)
        {
            ISprite animatedSprite = new AnimatedSprite();
            game1.SetCurrentSprite(animatedSprite);
        }
    }
}