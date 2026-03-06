using Microsoft.Xna.Framework;
using Sprint.Block;
using Sprint.Character;
using Sprint.Enemies;
using Sprint.Enemies.Base;
using Sprint.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sprint.Collision
{
	internal class CollisionManager
	{

		public CollisionManager()
		{

		}
		public void allCollisions(Link link, BlockManager blockManager, EnemyManager enemyManager)
		{
			LinkHitBlocks(link, blockManager);
			LinkHitEnemy(link, enemyManager);
		}

		private void LinkHitBlocks(Link link, BlockManager blockManager)
		{

			foreach (var block in blockManager.blocksList)
			{
				if (block.walkAble)
					continue;

				if (!link.Rect.Intersects(block.Rect))
					continue;

				Rectangle overlap = Rectangle.Intersect(link.Rect, block.Rect);

				if (overlap.Width < overlap.Height)
				{
					if (link.Rect.Center.X < block.Rect.Center.X)
						link.Position -= new Vector2(overlap.Width, 0);
					else
						link.Position += new Vector2(overlap.Width, 0);
				}
				else
				{
					if (link.Rect.Center.Y < block.Rect.Center.Y)
						link.Position -= new Vector2(0, overlap.Height);
					else
						link.Position += new Vector2(0, overlap.Height);
				}
			}
		}

		private void LinkHitEnemy(Link link, EnemyManager enemyManager)
		{
			foreach (var enemy in enemyManager.enemyList)
			{
				if (!link.Rect.Intersects(enemy.Rect))
					continue;

				Rectangle overlap = Rectangle.Intersect(link.Rect, enemy.Rect);

				if (overlap.Width < overlap.Height)
				{
					if (link.Rect.Center.X < enemy.Rect.Center.X)
						link.Position -= new Vector2(overlap.Width, 0);
					else
						link.Position += new Vector2(overlap.Width, 0);
				}
				else
				{
					if (link.Rect.Center.Y < enemy.Rect.Center.Y)
						link.Position -= new Vector2(0, overlap.Height);
					else
						link.Position += new Vector2(0, overlap.Height);
				}
			}
		}
	}
}