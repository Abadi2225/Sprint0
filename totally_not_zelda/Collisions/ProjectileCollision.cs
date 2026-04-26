using Microsoft.Xna.Framework;
using Sprint.Character;
using Sprint.Enemies;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;
using Sprint.Item;

namespace Sprint.Collision;

internal class ProjectileCollision : ICollisionHandler
{
    private const int PROJECTILE_DAMAGE = 1;
    private const int BOMB_DAMAGE = 2;
    private const int BOMB_RADIUS = 64;

    private readonly Link link;
    private readonly ItemManager itemManager;
    private readonly EnemyManager enemyManager;

    public ProjectileCollision(Link link, ItemManager itemManager, EnemyManager enemyManager)
    {
        this.link = link;
        this.itemManager = itemManager;
        this.enemyManager = enemyManager;
    }

    public void Handle()
    {
        foreach (var item in itemManager.SpawnedItems)
        {
            if (item.DamagesEnemies)
                ApplyEnemyDamage(item);

            if (item.DamagesPlayer && item.Rect.Intersects(link.Rect))
                link.TakeDamage(PROJECTILE_DAMAGE);
        }

        foreach (var item in itemManager.SpawnedItems)
        {
            if (item is TimeBomb bomb && !bomb.IsFinished && !bomb.JustExploded)
                TryFeedDodongo(bomb);
        }

        foreach (var item in itemManager.SpawnedItems)
        {
            if (item is TimeBomb bomb && bomb.JustExploded)
                ApplyBombBlast(bomb);
        }
    }

    private void ApplyEnemyDamage(AbstractItem item)
    {
        foreach (var enemy in enemyManager.enemyList)
        {
            if (!enemy.IsAlive) continue;
            if (!item.Rect.Intersects(enemy.Rect)) continue;

            enemy.TakeDamage(PROJECTILE_DAMAGE);
            item.OnEnemyHit();
            if (item.StopsOnHit) break;
        }
    }

    private void TryFeedDodongo(TimeBomb bomb)
    {
        foreach (var enemy in enemyManager.enemyList)
        {
            var actual = enemy is EnemyEffectWrapper w ? w.InnerEnemy : enemy;
            if (actual is Dodongo dodongo && dodongo.IsAlive && bomb.Rect.Intersects(dodongo.Rect))
            {
                dodongo.EatBomb();
                bomb.Consume();
                return;
            }
        }
    }

    private void ApplyBombBlast(TimeBomb bomb)
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
