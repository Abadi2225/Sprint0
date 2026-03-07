using Microsoft.Xna.Framework;
using Sprint.Character;
using Sprint.Enemies;
using Sprint.Interfaces;

namespace Sprint.Collision;

internal class SwordEnemyCollision : ICollisionHandler
{
    private const int SWORD_DAMAGE = 1;

    private readonly Link link;
    private readonly EnemyManager enemyManager;

    public SwordEnemyCollision(Link link, EnemyManager enemyManager)
    {
        this.link = link;
        this.enemyManager = enemyManager;
    }

    public void Handle()
    {
        if (link.SwordRect == Rectangle.Empty)
            return;

        var enemy = enemyManager.GetCurrentEnemy();

        if (enemy is null || !enemy.IsAlive)
            return;

        if (!link.SwordRect.Intersects(enemy.Rect))
            return;

        enemy.TakeDamage(SWORD_DAMAGE);
        link.RegisterSwordHit();
    }
}
