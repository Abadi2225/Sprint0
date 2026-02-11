using Sprint.Interfaces;
using Sprint.Controllers;

namespace Sprint.Commands
{
    public class SetStateCommand : ICommand
    {
        private Game1 game;
        private GameState newState;
        private GameState prevState;

        public SetStateCommand(Game1 game, GameState state)
        {
            this.game = game;
            newState = state;
        }

        public void Execute(int id)
        {
            prevState = game.GetCurrentState();
            game.SetState(newState);
        }

        public void Unexecute()
        {
            game.SetState(prevState);
        }
    }
}