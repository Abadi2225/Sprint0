using Microsoft.Xna.Framework.Content;
using Sprint.Interfaces;
using Sprint.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.Commands
{
	public class UseItemCommand : ICommand
	{
		private readonly ItemManager items;
		private readonly ILink link;
		private readonly int itemIndex;

		public UseItemCommand(ItemManager items, ILink link, int itemIndex)
		{
			this.items = items;
			this.link = link;
			this.itemIndex = itemIndex;
		}

		public void Execute()
		{
			if (items == null || link == null) return;

			var item = items.GetItem(itemIndex);
			item?.Use(link);
		}
	}
}

