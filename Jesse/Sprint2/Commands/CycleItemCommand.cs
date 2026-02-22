using Sprint.Interfaces;
using Sprint.Item;

namespace Sprint.Commands
{
    public class CycleItemCommand : ICommand
    {
        private readonly ItemManager itemManager;
        private readonly bool forward;

        public CycleItemCommand(ItemManager itemManager, bool forward)
        {
            this.itemManager = itemManager;
            this.forward = forward;
        }

        public void Execute()
        {
            if (forward)
                itemManager?.CycleNext();
            else
                itemManager?.CyclePrevious();
        }
    }
}
