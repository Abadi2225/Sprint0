using Sprint.Interfaces;
using Sprint.UI;

namespace Sprint.Commands
{
    public class RestartGameCommand : ICommand
    {
        public void Execute()
        {
            DungeonState.ResetProgess();
            GameServices.GameActions.ChangeState(new MenuState());
        }
    }
}