using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Zol : Enemy
    {
        private const int ZOL_HEALTH = 1;
        private const int ZOL_DAMAGE = 2;
        private const float BOUNCE_SPEED = 40f;
        private const float BOUNCE_INTERVAL = 1f;
        private const float AIR_TIME = 1f;
        
        private Vector2 velocity;
        private float bounceTimer;
        private bool isOnGround;
        private readonly Random random;
        
        public Zol(Texture2D texture, Vector2 position) : base(texture, position, ZOL_HEALTH, ZOL_DAMAGE)
        {
            int[] frameXPositions = [77, 94];
            int frameY = 11;
            int spriteWidth = 15;
            int spriteHeight = 15;
            float frameTime = 0.2f;
            
            sprite = new AnimatedSprite(texture, position, frameXPositions, frameY, 
                                        spriteWidth, spriteHeight, frameTime);
            
            random = new Random();
            isOnGround = true;
            bounceTimer = BOUNCE_INTERVAL;
            velocity = Vector2.Zero;
        }

        public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);
            
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            if (isOnGround)
            {
                bounceTimer -= deltaTime;
                if (bounceTimer <= 0)
                {
                    isOnGround = false;
                    velocity = GetRandomBounceDirection();
                    bounceTimer = AIR_TIME;
                }
            }
            else
            {
                bounceTimer -= deltaTime;
                Position += velocity * deltaTime;
                
                if (bounceTimer <= 0)
                {
                    isOnGround = true;
                    velocity = Vector2.Zero;
                    bounceTimer = BOUNCE_INTERVAL;
                }
            }
            
            return base.Update(gameTime);
        }

        public override void Reset()
        {
            base.Reset();
            isOnGround = true;
            bounceTimer = BOUNCE_INTERVAL;
            velocity = Vector2.Zero;
        }

        private Vector2 GetRandomBounceDirection()
        {
            return random.Next(4) switch
            {
                0 => new Vector2(0, -BOUNCE_SPEED),   // Up
                1 => new Vector2(0, BOUNCE_SPEED),    // Down
                2 => new Vector2(-BOUNCE_SPEED, 0),   // Left
                3 => new Vector2(BOUNCE_SPEED, 0),    // Right
                _ => Vector2.Zero,
            };
        }
    }
}