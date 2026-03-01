using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class SetStateCommand : ICommand
    {
        private IGameState newState;

        public SetStateCommand(IGameState newState)
        {
            this.newState = newState;
        }

        public void Execute()
        {
            GameServices.GameActions.ChangeState(newState);
        }
    }
}