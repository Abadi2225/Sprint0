using Microsoft.Xna.Framework;
using Sprint.Interfaces;
using Sprint.Block;
using System.Collections.Generic;

namespace Sprint.Collisions
{
	public class LinkBlockCollisionHandler : ICollisionHandler
	{
		private readonly ILink link;
		private readonly BlockManager blockManager;

		public LinkBlockCollisionHandler(ILink link, BlockManager blockManager)
		{
			this.link = link;
			this.blockManager = blockManager;
		}

		public void Handle()
		{
				foreach (var block in blockManager.blocksList)
				{
					if (block.walkAble) continue;
					if (block.pushAble) continue;
					if (link.Rect.Intersects(block.Rect))
						ResolveCollision(link, block);
				}
		}
		

		private static void ResolveCollision(ILink link, Sprint.Block.Block block)
		{
			Rectangle overlap = Rectangle.Intersect(link.Rect, block.Rect);
			if (overlap.Width < overlap.Height)
			{
				int pushX = link.Rect.Center.X < block.Rect.Center.X
					? -overlap.Width : overlap.Width;
				link.Position += new Vector2(pushX, 0);
			}
			else
			{
				int pushY = link.Rect.Center.Y < block.Rect.Center.Y
					? -overlap.Height : overlap.Height;
				link.Position += new Vector2(0, pushY);
			}
		}
	}
}
