using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class SetStateCommand : ICommand
    {
        private IGameActions gameActions;
        private IGameState newState;

        public SetStateCommand(IGameActions actions, IGameState newState)
        {
            gameActions = actions;
            this.newState = newState;
        }

        public void Execute()
        {
            gameActions.ChangeState(newState);
        }
    }
}