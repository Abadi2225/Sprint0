using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class CycleBlockCommand : ICommand
    {
        private readonly Game1 game;
        private readonly bool forward;

        public CycleBlockCommand(Game1 game, bool forward)
        {
            this.game = game;
            this.forward = forward;
        }

        public void Execute(int id)
        {
            var mapManager = game.GetMapManager();
            if (forward)
            {
                mapManager.CycleNext();
            }
            else
            {
                mapManager.CyclePrevious();
            }
        }

        public void Unexecute() { }
    }
}
