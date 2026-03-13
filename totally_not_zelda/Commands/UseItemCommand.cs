using Sprint.Interfaces;
using Sprint.Item;

namespace Sprint.Commands
{
    internal class UseItemCommand : ICommand
    {
        private readonly ItemManager itemManager;
        private readonly Inventory inventory;
        private readonly ILink link;
        private readonly int slot;

        public UseItemCommand(ItemManager itemManager, Inventory inventory, ILink link, int slot)
        {
            this.itemManager = itemManager;
            this.inventory = inventory;
            this.link = link;
            this.slot = slot;
        }

        public void Execute()
        {
            itemManager.UseItem(link, inventory, slot);
        }
    }
}
