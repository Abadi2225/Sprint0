using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class QuitCommand : ICommand
    {
        public void Execute()
        {
            GameServices.GameActions.Quit();
        }
    }
}