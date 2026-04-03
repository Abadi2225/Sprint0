using Microsoft.Xna.Framework;
using Sprint.Block;
using Sprint.Character;
using Sprint.Interfaces;

namespace Sprint.Collisions
{
	internal class LinkBlockPushHandler : ICollisionHandler
	{
		private readonly Link link;
		private readonly BlockManager blockManager;

		private Block.Block movingBlock = null;
		private Vector2 movingTargetPos;

		private const float PUSH_STEP = 4f;

		public LinkBlockPushHandler(Link link, BlockManager blockManager)
		{
			this.link = link;
			this.blockManager = blockManager;
		}

		public void Handle()
		{
			if (movingBlock != null)
			{
				UpdateMovingBlock();
				return;
			}

			if (link.IsPushing) return;

			foreach (var block in blockManager.blocksList)
			{
				if (block.walkAble) continue;
				if (!block.pushAble) continue;
				if (!link.Rect.Intersects(block.Rect)) continue;

				ResolvePush(link, block);
				break;
			}
		}

		private void ResolvePush(Link link, Block.Block block)
		{
			Vector2 originalPos = block.Position;
			Vector2 targetPos = originalPos;

			Rectangle overlap = Rectangle.Intersect(link.Rect, block.Rect);
			if (overlap.Width == 0 || overlap.Height == 0) return;

			if (overlap.Width < overlap.Height)
			{
				if (link.Rect.Center.X < block.Rect.Center.X)
				{
					targetPos = new Vector2(originalPos.X + block.tileWidth, originalPos.Y);
				}
				else
				{
					targetPos = new Vector2(originalPos.X - block.tileWidth, originalPos.Y);
				}
			}
			else
			{
				if (link.Rect.Center.Y < block.Rect.Center.Y)
				{
					targetPos = new Vector2(originalPos.X, originalPos.Y + block.tileWidth);
				}
				else
				{
					targetPos = new Vector2(originalPos.X, originalPos.Y - block.tileWidth);
				}
			}

			bool blocked = false;

			foreach (var blk in blockManager.blocksList)
			{
				if (blk == block) continue;
				if (blk.Position == targetPos && !blk.walkAble)
				{
					blocked = true;
					break;
				}
			}

			if (blocked) return;

			link.StartPush();
			link.StopMove();

			movingBlock = block;
			movingTargetPos = targetPos;
		}

		private void UpdateMovingBlock()
		{
			if (movingBlock == null) return;

			Vector2 toTarget = movingTargetPos - movingBlock.Position;
			float remainingDistance = toTarget.Length();

			if (remainingDistance <= PUSH_STEP)
			{
				FinishPush();
				return;
			}

			Vector2 stepDirection = Vector2.Normalize(toTarget);
			movingBlock.Position += stepDirection * PUSH_STEP;
		}

		private void FinishPush()
		{
			movingBlock.Position = movingTargetPos;
			movingBlock = null;
			movingTargetPos = Vector2.Zero;
		}
	}
}