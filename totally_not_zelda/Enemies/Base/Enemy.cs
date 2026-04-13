using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using System;
using Sprint.Block;
using System.Linq;
using System.Collections.Generic;

namespace Sprint.Enemies.Base
{
    public abstract class Enemy : IEnemy
    {
        protected IPositionedSprite sprite;
        protected Vector2 position;
        protected Texture2D texture;

        protected int health;
        protected int maxHealth;
        protected int damage;
        protected bool isAlive;
        protected bool isInvincible;
        protected float dyingTimer;
        protected const float DYING_DURATION = 0.5f; // For the death animation
        protected readonly Random random = new Random();
        protected virtual bool FlipsOnVertical => false;
        public virtual bool HasCollision => true;
        private const float KNOCKBACK_DURATION = 0.15f;
        private Vector2 knockbackVelocity;
        private float knockbackTimer;
        protected virtual bool CanBeKnockedBack => true;

        public void Knockback(Vector2 direction, float force)
        {
            if (!CanBeKnockedBack) return;
            knockbackVelocity = direction * force;
            knockbackTimer = KNOCKBACK_DURATION;
        }

        protected bool WouldIntersectBlock(Vector2 candidatePos, List<Sprint.Block.Block> solidBlocks)
        {
            Rectangle candidateRect = new Rectangle((int)candidatePos.X, (int)candidatePos.Y, Rect.Width, Rect.Height);
            return solidBlocks.Any(b => !b.walkAble && b.Rect.Intersects(candidateRect));
        }

        protected bool WouldIntersectWall(Vector2 candidatePos, Rectangle innerBounds)
        {
            Rectangle candidateRect = new Rectangle((int)candidatePos.X, (int)candidatePos.Y, Rect.Width, Rect.Height);
            return candidateRect.Left < innerBounds.Left ||
                candidateRect.Right > innerBounds.Right ||
                candidateRect.Top < innerBounds.Top ||
                candidateRect.Bottom > innerBounds.Bottom;
        }

        public Vector2 Position
        {
            get => position;
            set
            {
                position = value;
                if (sprite != null)
                    sprite.Position = value;
                Rect = new Rectangle((int)value.X, (int)value.Y, Rect.Width, Rect.Height);
            }
        }

        public int Health
        {
            get => health;
            set => health = MathHelper.Clamp(value, 0, maxHealth);
        }

        public Texture2D Texture => texture;
        public Rectangle Rect { get; set; } = Rectangle.Empty;

        public int MaxHealth => maxHealth;
        public int Damage => damage;
        public bool IsAlive => isAlive;

        protected Enemy(Texture2D texture, Vector2 position, int health, int damage,  bool isInvincible = false)
        {
            this.texture = texture;
            this.position = position;
            this.maxHealth = health;
            this.health = health;
            this.damage = damage;
            this.isAlive = true;
            this.isInvincible = isInvincible;
            this.dyingTimer = 0f;
        }

        public virtual void TakeDamage(int damageAmount)
        {
            if (!isAlive || isInvincible)
                return;

            health -= damageAmount;

            if (health <= 0)
            {
                health = 0;
                Die();
            }
        }

        public virtual void Die()
        {
            if (!isAlive || isInvincible)
                return;

            isAlive = false;
        }

        public virtual void Reset()
        {
            health = maxHealth;
            isAlive = true;
            dyingTimer = 0f;
        }

        public void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (knockbackTimer > 0)
            {
                Position += knockbackVelocity * dt;
                knockbackTimer -= dt;
                sprite?.Update(gameTime);
                return;
            }

            UpdateEnemy(gameTime);
        }

        protected virtual void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive)
            {
                dyingTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (dyingTimer >= DYING_DURATION)
                    return;
            }

            sprite?.Update(gameTime);
        }

        public virtual void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!isAlive) return;

            sprite?.Draw(spriteBatch, location);
        }

        protected Vector2 ChooseValidStep(List<Sprint.Block.Block> solidBlocks, Rectangle innerBounds, float stepSize, int minSteps = 1, int maxSteps = 2, int maxAttempts = 4)
        {
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                int dir = random.Next(4);
                int numSteps = random.Next(minSteps, maxSteps + 1);
                float distance = stepSize * numSteps * GameServices.ScaleFactor;

                Vector2 candidate = dir switch
                {
                    0 => Position + new Vector2(0, -distance),
                    1 => Position + new Vector2(0, distance),
                    2 => Position + new Vector2(-distance, 0),
                    3 => Position + new Vector2(distance, 0),
                    _ => Position
                };

                if (!WouldIntersectBlock(candidate, solidBlocks) && !WouldIntersectWall(candidate, innerBounds))
                    return candidate;
            }
            return Position;
        }
    }
}
