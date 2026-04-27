using Microsoft.Xna.Framework;
using Sprint.Character;
using Sprint.Enemies;
using Sprint.Interfaces;

namespace Sprint.Collision;

internal class SwordEnemyCollision : ICollisionHandler
{
    private const int SWORD_DAMAGE = 1;
    private const float KNOCKBACK_FORCE = 1000f;

    private readonly Link link;
    private readonly EnemyManager enemyManager;

    public SwordEnemyCollision(Link link, EnemyManager enemyManager)
    {
        this.link = link;
        this.enemyManager = enemyManager;
    }

    public void Handle()
    {
        if (link.SwordRect == Rectangle.Empty) return;

        foreach (var enemy in enemyManager.EnemyList)
        {
            if (!enemy.IsAlive) continue;
            if (!enemy.HasCollision) continue;
            if (link.SwordRect.Intersects(enemy.Rect))
            {
                enemy.TakeDamage(SWORD_DAMAGE);
                link.RegisterSwordHit();

                var dir = DirectionsUtils.CreateVector(link.Facing, 1f);
                enemy.Knockback(dir, KNOCKBACK_FORCE);
            }
        }
    }
}