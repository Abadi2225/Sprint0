using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Enemies;

internal class EnemyEffectWrapper : IEnemy
{
    private readonly IEnemy enemy;
    private readonly ISprite spawnSprite;
    private readonly ISprite deathSprite;

    private float spawnTimer;
    private float dyingTimer;

    private const float SPAWN_DURATION = 1.5f;
    private const float DYING_DURATION = 0.5f;

    public EnemyEffectWrapper(IEnemy enemy, ISprite spawnSprite, ISprite deathSprite)
    {
        this.enemy = enemy;
        this.spawnSprite = spawnSprite;
        this.deathSprite = deathSprite;
        ResetSpawnTimer();
    }

    public Vector2 Position
    {
        get => enemy.Position;
        set => enemy.Position = value;
    }

    public int Health
    {
        get => enemy.Health;
        set => enemy.Health = value;
    }

    private bool IsSpawning => spawnTimer < SPAWN_DURATION;
    public int MaxHealth => enemy.MaxHealth;
    public int Damage => enemy.Damage;
    public bool IsAlive => enemy.IsAlive;
    private bool IsDyingAnimation => !enemy.IsAlive && dyingTimer < DYING_DURATION;

    public void TakeDamage(int amount) => enemy.TakeDamage(amount);
    public void Die() => enemy.Die();

    private void ResetSpawnTimer()
    {
        spawnTimer = spawnSprite is null ? SPAWN_DURATION : 0f;
    }
    
    public void Reset()
    {
        enemy.Reset();
        ResetSpawnTimer();
        dyingTimer = 0f;
    }

    public void Update(GameTime gameTime)
    {
        float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

        // Spawn phase: freeze enemy, play cloud animation
        if (IsSpawning)
        {
            spawnTimer += dt;
            spawnSprite?.Update(gameTime);
            return;
        }

        // Death phase: play dust animation
        if (IsDyingAnimation)
        {
            dyingTimer += dt;
            deathSprite?.Update(gameTime);
            return;
        }

        // Normal phase: update the actual enemy
        enemy.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch, Vector2 location)
    {
        // Spawn phase: show cloud, hide enemy
        if (IsSpawning)
        {
            spawnSprite?.Draw(spriteBatch, location);
            return;
        }

        // Death phase: show dust, hide enemy
        if (IsDyingAnimation)
        {
            deathSprite?.Draw(spriteBatch, location);
            return;
        }

        enemy.Draw(spriteBatch, location);
    }
}