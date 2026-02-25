namespace Sprint.Interfaces;

public interface IEnemy : IPositionedSprite
    {
        int Health { get; set; }
        int MaxHealth { get; }
        int Damage { get; }

        bool IsAlive { get; }

        void TakeDamage(int damageAmount);
        void Die();
        void Reset();
    }