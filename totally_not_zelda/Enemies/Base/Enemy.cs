using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

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

        public Vector2 Position
        {
            get => position;
            set
            {
                position = value;
                if (sprite != null)
                {
                    sprite.Position = value;
                }
            }
        }

        public int Health
        {
            get => health;
            set => health = MathHelper.Clamp(value, 0, maxHealth);
        }

        public Texture2D Texture => texture;
        // moved out of interface into this class due to merge conflict
        // todo fix this
        public Rectangle Rect = Rectangle.Empty;

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

        public virtual void Update(GameTime gameTime)
        {
            if (!isAlive)
            {
                dyingTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (dyingTimer >= DYING_DURATION)
                {
                    return;
                }
            }

            sprite?.Update(gameTime);
        }

        public virtual void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!isAlive) return;

            sprite?.Draw(spriteBatch, location);
        }
    }
}
