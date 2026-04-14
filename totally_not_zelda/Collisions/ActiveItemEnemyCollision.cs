using Microsoft.Xna.Framework;
using Sprint.Enemies;
using Sprint.Interfaces;
using Sprint.Item;

namespace Sprint.Collision;

internal class ActiveItemEnemyCollision : ICollisionHandler
{
    private const int PROJECTILE_DAMAGE = 1;
    private const int BOMB_DAMAGE = 2;
    private const int BOMB_RADIUS = 64;

    private readonly ItemManager itemManager;
    private readonly EnemyManager enemyManager;

    public ActiveItemEnemyCollision(ItemManager itemManager, EnemyManager enemyManager)
    {
        this.itemManager = itemManager;
        this.enemyManager = enemyManager;
    }

    public void Handle()
    {
        // Arrow: stop on first enemy hit; Boomerang: pass through dealing damage
        foreach (var item in itemManager.SpawnedItems)
        {
            if (item is Arrow arrow)
            {
                foreach (var enemy in enemyManager.enemyList)
                {
                    if (!enemy.IsAlive) continue;
                    if (arrow.Rect.Intersects(enemy.Rect))
                    {
                        enemy.TakeDamage(PROJECTILE_DAMAGE);
                        arrow.MarkHit();
                        break;
                    }
                }
            }
            else if (item is Boomerang boomerang)
            {
                foreach (var enemy in enemyManager.enemyList)
                {
                    if (!enemy.IsAlive) continue;
                    if (boomerang.Rect.Intersects(enemy.Rect))
                        enemy.TakeDamage(PROJECTILE_DAMAGE);
                }
            }
        }

        // TimeBomb: deal AOE damage to enemies in explosion radius when it goes off
        foreach (var item in itemManager.SpawnedItems)
        {
            if (item is TimeBomb bomb && bomb.JustExploded)
            {
                Rectangle blastZone = new Rectangle(
                    (int)bomb.ExplosionCenter.X - BOMB_RADIUS,
                    (int)bomb.ExplosionCenter.Y - BOMB_RADIUS,
                    BOMB_RADIUS * 2,
                    BOMB_RADIUS * 2);

                foreach (var enemy in enemyManager.enemyList)
                {
                    if (!enemy.IsAlive) continue;
                    if (blastZone.Intersects(enemy.Rect))
                        enemy.TakeDamage(BOMB_DAMAGE);
                }
            }
        }
    }
}
