using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Enemies
{
    internal class EnemyEffectWrapper : IEnemy
    {
        private readonly IEnemy enemy;
        private readonly ISprite spawnSprite;
        private readonly ISprite deathSprite;

        private float spawnTimer;
        private float dyingTimer = 0f;

        private const float SPAWN_DURATION = 1.5f;
        private const float DYING_DURATION = 0.5f;

        public EnemyEffectWrapper(IEnemy enemy, ISprite spawnSprite, ISprite deathSprite)
        {
            this.enemy = enemy;
            this.spawnSprite = spawnSprite;
            this.deathSprite = deathSprite;
            spawnTimer = spawnSprite == null ? SPAWN_DURATION : 0f;
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

        public int MaxHealth => enemy.MaxHealth;
        public int Damage => enemy.Damage;
        public bool IsAlive => enemy.IsAlive;

        public void TakeDamage(int amount) => enemy.TakeDamage(amount);
        public void Die() => enemy.Die();

        public void Reset()
        {
            enemy.Reset();
            spawnTimer = spawnSprite == null ? SPAWN_DURATION : 0f;
            dyingTimer = 0f;
        }

        public int Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            // Spawn phase: freeze enemy AI, play cloud animation
            if (spawnTimer < SPAWN_DURATION)
            {
                spawnTimer += dt;
                spawnSprite?.Update(gameTime);
                return 0;
            }

            int result = enemy.Update(gameTime);

            // Death phase: play dust animation
            if (!enemy.IsAlive && dyingTimer < DYING_DURATION)
            {
                dyingTimer += dt;
                deathSprite?.Update(gameTime);
            }

            return result;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            // Spawn phase: show cloud, hide enemy
            if (spawnTimer < SPAWN_DURATION)
            {
                spawnSprite?.Draw(spriteBatch, location);
                return;
            }

            // Death phase: show dust, hide enemy
            if (!enemy.IsAlive)
            {
                if (dyingTimer < DYING_DURATION)
                    deathSprite?.Draw(spriteBatch, location);
                return;
            }

            enemy.Draw(spriteBatch, location);
        }
    }
}
