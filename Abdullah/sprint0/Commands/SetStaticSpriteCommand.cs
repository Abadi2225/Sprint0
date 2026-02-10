using sprint0.Interfaces;
using sprint0.Sprites;

namespace sprint0.Commands
{
    public class SetStaticSpriteCommand : ICommand
    {
        public void Execute(Game1 game1)
        {
            ISprite staticSprite = new StaticSprite();
            game1.SetCurrentSprite(staticSprite);
        }
    }
}