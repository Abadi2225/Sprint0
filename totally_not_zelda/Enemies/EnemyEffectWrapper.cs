using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Item;

namespace Sprint.Enemies;

internal class EnemyEffectWrapper : IEnemy
{
    private readonly IEnemy enemy;
    private readonly ISprite spawnSprite;
    private readonly ISprite deathSprite;
    private readonly AbstractItem droppedItem;
    private readonly Action<AbstractItem> onItemDropped;
    private bool itemDropped;

    private float spawnTimer;
    private float dyingTimer;
    public IEnemy InnerEnemy => enemy;

    private const float SPAWN_DURATION = 1.5f;
    private const float DYING_DURATION = 0.5f;
    public bool IsSpawningPublic => IsSpawning;
    public bool HasCollision => enemy.HasCollision;

    public EnemyEffectWrapper(IEnemy enemy, ISprite spawnSprite, ISprite deathSprite,
        AbstractItem droppedItem = null, Action<AbstractItem> onItemDropped = null)
    {
        this.enemy = enemy;
        this.spawnSprite = spawnSprite;
        this.deathSprite = deathSprite;
        this.droppedItem = droppedItem;
        this.onItemDropped = onItemDropped;
        ResetSpawnTimer();
    }

    public Vector2 Position
    {
        get => enemy.Position;
        set => enemy.Position = value;
    }

    public Rectangle Rect
    {
        get => enemy.Rect;
        set => enemy.Rect = value;
    }
    public Rectangle NavRect => enemy.NavRect;

    public int Health
    {
        get => enemy.Health;
        set => enemy.Health = value;
    }

    public int ID
        {
            get => enemy.ID;
            set => enemy.ID = value;
        }

    private bool IsSpawning => spawnTimer < SPAWN_DURATION;
    public int MaxHealth => enemy.MaxHealth;
    public int Damage => enemy.Damage;
    public bool IsAlive => enemy.IsAlive;
    private bool IsDyingAnimation => !enemy.IsAlive && dyingTimer < DYING_DURATION;

    public void TakeDamage(int amount) => enemy.TakeDamage(amount);
    public void Die() => enemy.Die();
    public void Knockback(Vector2 direction, float force) => enemy.Knockback(direction, force);
    public override string ToString() => enemy.ToString();

    private void ResetSpawnTimer()
    {
        spawnTimer = spawnSprite is null ? SPAWN_DURATION : 0f;
    }
    
    public void Reset()
    {
        enemy.Reset();
        ResetSpawnTimer();
        dyingTimer = 0f;
        itemDropped = false;
    }

    public void Update(GameTime gameTime)
    {
        float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (IsSpawning)
        {
            spawnTimer += dt;
            spawnSprite?.Update(gameTime);
            return;
        }

        if (IsDyingAnimation)
        {
            dyingTimer += dt;
            deathSprite?.Update(gameTime);
            return;
        }

        if (!enemy.IsAlive && !itemDropped && droppedItem != null && onItemDropped != null)
        {
            droppedItem.Position = enemy.Position;
            onItemDropped(droppedItem);
            itemDropped = true;
        }

        enemy.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch, Vector2 location)
    {
        if (IsSpawning)
        {
            spawnSprite?.Draw(spriteBatch, location);
            return;
        }

        if (IsDyingAnimation)
        {
            deathSprite?.Draw(spriteBatch, location);
            return;
        }

        enemy.Draw(spriteBatch, location);
    }
}