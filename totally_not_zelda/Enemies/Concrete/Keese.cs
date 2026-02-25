using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Keese : Enemy
    {
        private const int HEALTH = 1;
        private const int DAMAGE = 1;
         private const float MOVE_SPEED = 40f;
        private const float REST_TIME_MIN = 0.5f;
        private const float REST_TIME_MAX = 2.0f;
        private const float MOVE_TIME_MIN = 1.0f;
        private const float MOVE_TIME_MAX = 3.0f;
        private Random random;
        private Vector2 moveDirection;
        private float actionTimer;
        private float actionDuration;
        private bool isResting;
        private ISprite flyingSprite;
        private ISprite restingSprite;
        
        // Rests against walls first before taking flight
        // Moves erratically in random directions, stopping sometimes to rest
        // Boomerang kills them instead of stunning
        // Never drop any items
        public Keese(Texture2D texture, Vector2 position) : base(texture, position, HEALTH, DAMAGE)
        {
            int[] flyingXPositions = new int[] { 183, 200 };
            int[] restingXPositions = new int[] {200};
            int sheetY = 11;
            int spriteWidth = 15;
            int spriteHeight = 15;
            float frameTime = 0.2f;
            
            flyingSprite = new AnimatedSprite(texture, position, flyingXPositions, sheetY, 
                                        spriteWidth, spriteHeight, frameTime);
        
            restingSprite = new AnimatedSprite(texture, position, restingXPositions, sheetY, 
                                        spriteWidth, spriteHeight, frameTime);

            random = new Random();
            isResting = true;
            actionTimer = 0f;
            actionDuration = GetRandomFloat(REST_TIME_MIN, REST_TIME_MAX);
            ChooseRandomDirection();
            sprite = restingSprite;
        }
        
        public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);
            
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            actionTimer += dt;
            
            // Check if it's time to switch between moving and resting
            if (actionTimer >= actionDuration)
            {
                actionTimer = 0f;
                isResting = !isResting;
                
                if (isResting)
                {
                    // Start resting
                    actionDuration = GetRandomFloat(REST_TIME_MIN, REST_TIME_MAX);
                    sprite = restingSprite;

                }
                else
                {
                    // Start moving in a new random direction
                    actionDuration = GetRandomFloat(MOVE_TIME_MIN, MOVE_TIME_MAX);
                    sprite = flyingSprite;
                    ChooseRandomDirection();
                }

                if (sprite != null)
                {
                    sprite.Position = Position;
                }
            }
            
            // Move if not resting
            if (!isResting)
            {
                Position += moveDirection * MOVE_SPEED * dt;
            }
            
            if (sprite != null)
            {
                return sprite.Update(gameTime);
            }
            return 0;
        }
        
        private void ChooseRandomDirection()
        {
            // Pick a random angle in radians
            float angle = (float)(random.NextDouble() * Math.PI * 2);
            moveDirection = new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle));
            moveDirection.Normalize();
        }
        
        private float GetRandomFloat(float min, float max)
        {
            return min + (float)random.NextDouble() * (max - min);
        }
    }
}