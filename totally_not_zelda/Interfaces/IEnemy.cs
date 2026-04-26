using Microsoft.Xna.Framework;

namespace Sprint.Interfaces;

public interface IEnemy : IPositionedSprite
{
    Rectangle Rect { get; set; }
    Rectangle NavRect { get; }
    int ID { get; set; }
    int Health { get; set; }
    int MaxHealth { get; }
    int Damage { get; }
    bool IsAlive { get; }
    public void TakeDamage(int damageAmount);
    public void Die();
    public void Reset();
    public void Knockback(Vector2 direction, float force);
    bool HasCollision { get; }
}