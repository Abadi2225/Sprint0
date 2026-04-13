using Sprint.Interfaces;
using Sprint.Item;

namespace Sprint.Commands
{
    internal class UseItemCommand : ICommand
    {
        private readonly ItemManager itemManager;
        private readonly Inventory inventory;
        private readonly ILink link;

        public UseItemCommand(ItemManager itemManager, Inventory inventory, ILink link)
        {
            this.itemManager = itemManager;
            this.inventory = inventory;
            this.link = link;
        }

        public void Execute()
        {
            itemManager.UseItem(link, inventory, inventory.ActiveSlot);
        }
    }
}
