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
				if (block.HasBeenPushed) continue;
				if (!link.BlockRect.Intersects(block.Rect)) continue;

				ResolvePush(link, block);
				break;
			}
		}

		private void ResolvePush(Link link, Block.Block block)
		{
			Vector2 originalPos = block.Position;
			Vector2 targetPos = originalPos;

			Rectangle overlap = Rectangle.Intersect(link.BlockRect, block.Rect);
			if (overlap.Width == 0 || overlap.Height == 0) return;

			if (link.Facing != block.PushDirection) return;

			bool pushingFromCorrectSide = block.PushDirection switch
			{
				Directions.Up => link.BlockRect.Center.Y > block.Rect.Center.Y,
				Directions.Down => link.BlockRect.Center.Y < block.Rect.Center.Y,
				Directions.Left => link.BlockRect.Center.X > block.Rect.Center.X,
				Directions.Right => link.BlockRect.Center.X < block.Rect.Center.X,
				_ => false
			};

			if (!pushingFromCorrectSide) return;

			targetPos = block.PushDirection switch
			{
				Directions.Up => new Vector2(originalPos.X, originalPos.Y - block.tileWidth),
				Directions.Down => new Vector2(originalPos.X, originalPos.Y + block.tileWidth),
				Directions.Left => new Vector2(originalPos.X - block.tileWidth, originalPos.Y),
				Directions.Right => new Vector2(originalPos.X + block.tileWidth, originalPos.Y),
				_ => originalPos
			};

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
			movingBlock.HasBeenPushed = true;
			movingBlock = null;
			movingTargetPos = Vector2.Zero;
		}
	}
}