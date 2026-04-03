using Microsoft.Xna.Framework;
using Sprint.Block;
using Sprint.Character;
using Sprint.Enemies.Base;
using Sprint.Interfaces;
using Sprint.UI;
using System.Collections.Generic;

namespace Sprint.Collisions
{
	public class EnemyWallCollisionHandler : ICollisionHandler
	{

		private readonly List<IEnemy> enemies;
		private readonly JesseDungeonWalls dungeonWalls;

		public EnemyWallCollisionHandler(List<IEnemy> enemies, JesseDungeonWalls dungeonWalls)
		{
			this.enemies = enemies;
			this.dungeonWalls = dungeonWalls;
		}

		public void Handle()
		{
			foreach (var enemy in enemies)
			{
				if (!enemy.HasCollision) continue;
				ResolveCollision(enemy, dungeonWalls);
			}
		}
		private static void ResolveCollision(IEnemy enemy, JesseDungeonWalls dungeonWalls)
		{

			if (enemy.Position.X < dungeonWalls.InnerBounds.Left)
			{
				int pushX = (int)dungeonWalls.InnerBounds.Left - (int)enemy.Position.X;
				enemy.Position += new Vector2(pushX, 0);
			}
			if (enemy.Position.X > dungeonWalls.InnerBounds.Right - enemy.Rect.Width)
			{
				int pushX = (int)dungeonWalls.InnerBounds.Right - enemy.Rect.Width - (int)enemy.Position.X;
				enemy.Position += new Vector2(pushX, 0);
			}
			if (enemy.Position.Y < dungeonWalls.InnerBounds.Top)
			{
				int pushY = (int)dungeonWalls.InnerBounds.Top - (int)enemy.Position.Y;
				enemy.Position += new Vector2(0, pushY);
			}
			if (enemy.Position.Y > dungeonWalls.InnerBounds.Bottom - enemy.Rect.Height)
			{
				int pushY = (int)dungeonWalls.InnerBounds.Bottom - enemy.Rect.Height - (int)enemy.Position.Y;
				enemy.Position += new Vector2(0, pushY);
			}
		}
	}
}
