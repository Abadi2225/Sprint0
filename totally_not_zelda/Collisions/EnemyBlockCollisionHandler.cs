using Microsoft.Xna.Framework;
using Sprint.Interfaces;
using Sprint.Block;
using System.Collections.Generic;
using Sprint.Enemies.Concrete;
using Sprint.Enemies;

namespace Sprint.Collisions
{
    public class EnemyBlockCollisionHandler : ICollisionHandler
    {
        private readonly List<IEnemy> enemies;
        private readonly BlockManager blockManager;

        public EnemyBlockCollisionHandler(List<IEnemy> enemies, BlockManager blockManager)
        {
            this.enemies = enemies;
            this.blockManager = blockManager;
        }

        public void Handle()
        {
            foreach (var enemy in enemies)
            {
                if (!enemy.IsAlive) continue;

                // Unwrap to get the actual enemy type
                var actualEnemy = enemy is EnemyEffectWrapper wrapper 
                    ? wrapper.InnerEnemy 
                    : enemy;
                    
                if (actualEnemy is Keese) continue;
                if (enemy is EnemyEffectWrapper w && w.IsSpawningPublic) continue;

                foreach (var block in blockManager.blocksList)
                {
                    if (block.walkAble) continue;
                    if (enemy.Rect.Intersects(block.Rect))
                        ResolveCollision(enemy, block);
                }
            }
        }

        private static void ResolveCollision(IEnemy enemy, Sprint.Block.Block block)
        {
            Rectangle overlap = Rectangle.Intersect(enemy.Rect, block.Rect);
            if (overlap.Width < overlap.Height)
            {
                int pushX = enemy.Rect.Center.X < block.Rect.Center.X
                    ? -overlap.Width : overlap.Width;
                enemy.Position += new Vector2(pushX, 0);
            }
            else
            {
                int pushY = enemy.Rect.Center.Y < block.Rect.Center.Y
                    ? -overlap.Height : overlap.Height;
                enemy.Position += new Vector2(0, pushY);
            }
        }
    }
}
