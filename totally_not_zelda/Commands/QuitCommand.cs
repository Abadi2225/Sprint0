using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class QuitCommand : ICommand
    {
        private IGameActions gameActions;

        public QuitCommand(IGameActions actions)
        {
            gameActions = actions;
        }

        public void Execute()
        {
            gameActions.Quit();
        }
    }
}