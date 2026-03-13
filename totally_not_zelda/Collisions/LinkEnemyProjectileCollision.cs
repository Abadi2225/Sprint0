using Sprint.Character;
using Sprint.Enemies;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;
using Sprint.Item;

namespace Sprint.Collision;

internal class LinkEnemyProjectileCollision : ICollisionHandler
{
    private const int PROJECTILE_DAMAGE = 1;

    private readonly Link link;
    private readonly EnemyManager enemyManager;

    public LinkEnemyProjectileCollision(Link link, EnemyManager enemyManager)
    {
        this.link = link;
        this.enemyManager = enemyManager;
    }

    public void Handle()
    {
        foreach (var enemy in enemyManager.enemyList)
        {
            if (enemy is Aquamentus aquamentus)
            {
                foreach (var fireball in aquamentus.ActiveFireballs)
                {
                    if (!fireball.IsActive) continue;
                    if (fireball.Rect.Intersects(link.Rect))
                        link.TakeDamage(PROJECTILE_DAMAGE);
                }
            }
            else if (enemy is Goriya goriya)
            {
                Boomerang boomerang = goriya.ActiveBoomerang;
                if (boomerang != null && boomerang.Rect.Intersects(link.Rect))
                    link.TakeDamage(PROJECTILE_DAMAGE);
            }
        }
    }
}
