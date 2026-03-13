using Sprint.Block;
using Sprint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Sprint.Collisions
{
	internal class LinkBlockPushHandler
	{
		private readonly ILink link;
		private readonly BlockManager blockManager;
		public LinkBlockPushHandler(ILink link, BlockManager blockManager) { 
			
			this.link = link;
			this.blockManager = blockManager;
		}

		public void Handle()
		{
			foreach (var block in blockManager.blocksList)
			{
				if (block.walkAble) continue;
				if (!block.pushAble) continue;
				if (link.Rect.Intersects(block.Rect)) ;
					
			}
		}

		private static void ResolvePush(ILink link, Sprint.Block.Block block)
		{
			// TODO: Implement push resolution logic based on link's facing direction and block's position
		}
	}
}
