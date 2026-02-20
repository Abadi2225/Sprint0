using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Gel : Enemy
    {
        private const int GEL_HEALTH = 1;
        private const int GEL_DAMAGE = 1;
        
        //Originally configured for bouncing
        private Vector2 velocity;
        private float bounceTimer;
        private bool isOnGround;
        private const float BOUNCE_SPEED = 30f;
        private const float BOUNCE_INTERVAL = 1f;
        private const float AIR_TIME = 0.7f;
        private readonly Random random;
        
        public Gel(Texture2D texture, Vector2 position) : base(texture, position, GEL_HEALTH, GEL_DAMAGE)
        {
            int[] frameXPositions = [1, 10];
            int frameY = 15;
            int spriteWidth = 7;
            int spriteHeight = 8;
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