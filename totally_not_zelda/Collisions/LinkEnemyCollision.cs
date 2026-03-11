using Sprint.Character;
using Sprint.Enemies;
using Sprint.Interfaces;

namespace Sprint.Collision;

internal class LinkEnemyCollision : ICollisionHandler
{
    private readonly Link link;
    private readonly EnemyManager enemyManager;

    public LinkEnemyCollision(Link link, EnemyManager enemyManager)
    {
        this.link = link;
        this.enemyManager = enemyManager;
    }

    public void Handle()
    {
        var enemy = enemyManager.GetCurrentEnemy();

        if (enemy is null || !enemy.IsAlive)
            return;

        if (!link.Rect.Intersects(enemy.Rect))
            return;

        link.TakeDamage(enemy.Damage);
    }
}
