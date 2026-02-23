using Sprint.Interfaces;
using Sprint.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.Commands
{
    internal class UseItemCommand : ICommand
    {
        private ItemManager itemManager;
        private ILink link;
        private int slot;

        public UseItemCommand(ItemManager itemManager, ILink link, int slot)
        {
            this.itemManager = itemManager;
            this.link = link;
            this.slot = slot;
        }

        public void Execute()
        {
            itemManager.UseItem(link, slot);
        }
    }
}
