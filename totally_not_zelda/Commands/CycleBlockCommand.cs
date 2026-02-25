using Sprint.Block;
using Sprint.Interfaces;

namespace Sprint.Commands
{
    public class CycleBlockCommand : ICommand
    {
        private MapManager mapManager;
        private readonly bool forward;

        public CycleBlockCommand(MapManager mapManager, bool forward)
        {
            this.mapManager = mapManager;
            this.forward = forward;
        }

        public void Execute()
        {
            if (forward)
            {
                mapManager.CycleNext();
            }
            else
            {
                mapManager.CyclePrevious();
            }
        }
    }
}
