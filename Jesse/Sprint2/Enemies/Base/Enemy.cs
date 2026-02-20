using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Enemies.Base
{
    public abstract class Enemy : IEnemy
    {
        protected ISprite sprite;
        protected Vector2 position;
        protected Texture2D texture;
        
        protected int health;
        protected int maxHealth;
        protected int damage;
        protected bool isAlive;
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
        
        public Texture2D Texture => texture; // cleaner way instead of get
        public Rectangle Rect => sprite?.Rect ?? Rectangle.Empty; // if sprite exists then get .Rect if not return Rect.Empty
        
        public int Health 
        { 
            get => health; 
            set => health = MathHelper.Clamp(value, 0, maxHealth); // ensure health is between 0 and maxHealth
        }
        
        public int MaxHealth => maxHealth;
        public int Damage => damage;
        public bool IsAlive => isAlive;
        
        protected Enemy(Texture2D texture, Vector2 position, int health, int damage)
        {
            this.texture = texture;
            this.position = position;
            this.maxHealth = health;
            this.health = health;
            this.damage = damage;
            this.isAlive = true;
            this.dyingTimer = 0f;
        }
        
        public virtual void TakeDamage(int damageAmount)
        {
            if (!isAlive)
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
            if (!isAlive)
                return;

            isAlive = false;
        }
        
        public virtual void Reset()
        {
            health = maxHealth;
            isAlive = true;
            dyingTimer = 0f;
        }
        
        public virtual int Update(GameTime gameTime)
        {
            if (!isAlive)
                dyingTimer += (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (dyingTimer >= DYING_DURATION)
                {
                    isAlive = false;
                    return 0;
                }
            
            // Update the sprite
            if (sprite != null)
            {
                return sprite.Update(gameTime);
            }
            
            return 0;
        }
        
        public virtual void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!isAlive)
                return;
                
            sprite?.Draw(spriteBatch, location);
        }
    }
}