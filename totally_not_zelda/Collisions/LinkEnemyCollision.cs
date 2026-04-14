using System;
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
            foreach (var enemy in enemyManager.enemyList)
            {
                if (!enemy.IsAlive) continue;
                if (!enemy.HasCollision) continue;
                if (link.Rect.Intersects(enemy.Rect))
                    link.TakeDamage(enemy.Damage);
            }
        }
}
