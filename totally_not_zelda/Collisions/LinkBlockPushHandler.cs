using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Block;
using Sprint.Character;
using Sprint.Interfaces;

namespace Sprint.Collisions
{
	internal class LinkBlockPushHandler : ICollisionHandler
	{
		private readonly ILink link;
		private readonly BlockManager blockManager;
		private static readonly Rectangle PushableStatueSource = new Rectangle(34, 0, 16, 16);
		private static readonly Rectangle FloorSource = new Rectangle(0, 0, 16, 16);

		public LinkBlockPushHandler(ILink link, BlockManager blockManager)
		{
			this.link = link;
			this.blockManager = blockManager;
		}

		public void Handle()
		{
			foreach (var block in blockManager.blocksList)
			{
				if (block.walkAble) continue;
				if (!block.pushAble) continue;
				if (link.Rect.Intersects(block.Rect))
				{
					ResolvePush(link, block);
					break;
				}
			}
		}

		private void ResolvePush(ILink link, Block.Block block)
		{
			Vector2 originalPos = block.Position;
			Vector2 targetPos = originalPos;
			Block.Block targetBlock = null;

			if (link.Facing == Directions.Right)
			{
				if (link.Rect.Center.X >= block.Rect.Center.X) return;
				targetPos = new Vector2(originalPos.X + block.tileWidth, originalPos.Y);
			}
			else if (link.Facing == Directions.Left)
			{
				if (link.Rect.Center.X <= block.Rect.Center.X) return;
				targetPos = new Vector2(originalPos.X - block.tileWidth, originalPos.Y);
			}
			else if (link.Facing == Directions.Down)
			{
				if (link.Rect.Center.Y >= block.Rect.Center.Y) return;
				targetPos = new Vector2(originalPos.X, originalPos.Y + block.tileWidth);
			}
			else if (link.Facing == Directions.Up)
			{
				if (link.Rect.Center.Y <= block.Rect.Center.Y) return;
				targetPos = new Vector2(originalPos.X, originalPos.Y - block.tileWidth);
			}

			foreach (var blk in blockManager.blocksList)
			{
				if (blk.Position == targetPos)
				{
					targetBlock = blk;
					break;
				}
			}
			if (targetBlock == null) return;
			if (!targetBlock.walkAble) return;
			
			Block.Block newPushBlock =
				new Block.Block(
					GameServices.TileSheet,
					targetPos,
					PushableStatueSource,
					false,
					true
				);

			Block.Block newFloorBlock =
				new Block.Block(
					GameServices.TileSheet,
					originalPos,
					FloorSource,
					true,
					false
				);

			blockManager.blocksList.Remove(block);
			blockManager.blocksList.Remove(targetBlock);
			blockManager.blocksList.Add(newFloorBlock);
			blockManager.blocksList.Add(newPushBlock);
		}
	}
}