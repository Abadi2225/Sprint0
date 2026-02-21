using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Dodongo : Enemy
    {
        private enum DodongoState {Walking, BombEaten, Dead}
        private const int HEALTH = 1;
        private const int DAMAGE = 1;
        private Vector2 velocity;
        private const float MOVE_SPEED = 20f;
        private float directionChangeTimer;
        private const float DIRECTION_SWAP_MIN = 0.5f;
        private const float DIRECTION_SWAP_MAX = 2.0f;
        private Random random = new Random();
        private float moveDirectionTimer;
        private bool moveLeft;

        //Walks randomly in all four directions, eats bombs to take damage
        
        public Dodongo(Texture2D texture, Vector2 position) : base(texture, position, HEALTH, DAMAGE)
        {
            int[]sheetXPositions = new int[] {1, 26, 51, 76}; 
            int sheetY = 11;
            int spriteWidth = 23;
            int spriteHeight = 31;
            float frameTime = 0.2f;
            moveDirectionTimer = 0f;
            directionChangeTimer = GetRandomFloat(DIRECTION_SWAP_MIN,DIRECTION_SWAP_MAX);
            
       
            sprite = new AnimatedSprite(texture, position, sheetXPositions, sheetY, spriteWidth, spriteHeight, frameTime);
        }
        
       public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);
            
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            moveDirectionTimer += deltaTime;
            
            if (moveDirectionTimer >= directionChangeTimer)
            {
                moveDirectionTimer = 0f;
                if (moveLeft)
                {
                    velocity = new Vector2(-MOVE_SPEED, 0);

                } else
                {
                    velocity = new Vector2(MOVE_SPEED, 0);
                }
                directionChangeTimer = GetRandomFloat(DIRECTION_SWAP_MIN, DIRECTION_SWAP_MAX);
                moveLeft = !moveLeft;
            }
            Position += velocity * deltaTime;
            
            return sprite.Update(gameTime);
        }

        private void fireBall()
        {
            //Code for shooting fireballs here, on a few second timer.
        }
        
         private float GetRandomFloat(float min, float max)
        {
            return min + (float)random.NextDouble() * (max - min);
        }
    }
}