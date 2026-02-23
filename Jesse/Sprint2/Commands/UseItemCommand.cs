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

        public UseItemCommand(ItemManager itemManager, ILink link)
        {
            this.itemManager = itemManager;
            this.link = link;
        }

        public void Execute()
        {
            itemManager.UseActiveItem(link);
        }
    }
}
