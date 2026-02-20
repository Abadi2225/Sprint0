using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class WallMaster : Enemy
    {
        private const int WALLMASTER_HEALTH = 2;
        private const int WALLMASTER_DAMAGE = 1;
        
        // Bouncing movement
        private Vector2 velocity;
        private float bounceTimer;
        private bool isOnGround;
        private const float BOUNCE_SPEED = 30f;
        private const float BOUNCE_INTERVAL = 1f;
        private const float AIR_TIME = 0.7f;
        private readonly Random random;
        
        public WallMaster(Texture2D texture, Vector2 position) : base(texture, position, WALLMASTER_HEALTH, WALLMASTER_DAMAGE)
        {
            int[] frameXPositions = [393, 410];
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
        
        private Vector2 GetRandomBounceDirection()
        {
            int direction = random.Next(4);
            return direction switch
            {
                0 => new Vector2(0, -BOUNCE_SPEED),// Up
                1 => new Vector2(0, BOUNCE_SPEED),// Down
                2 => new Vector2(-BOUNCE_SPEED, 0),// Left
                3 => new Vector2(BOUNCE_SPEED, 0),// Right
                _ => Vector2.Zero,
            };

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
    }
}