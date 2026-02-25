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
        private const float CREEP_SPEED = 25f;
        private const float RETREAT_SPEED = 40f;
        private const float HIDDEN_TIME_MIN = 1.5f;
        private const float HIDDEN_TIME_MAX = 3f;
        private const float CREEP_TIME_MIN = 2f;
        private const float CREEP_TIME_MAX = 4f;

        private enum WallMasterState { Hidden, Creeping, Retreating }
        
        private readonly Random random;
        private WallMasterState currentState;
        private Vector2 creepDirection;
        private Vector2 homePosition;
        private float stateTimer;
        private float stateDuration;
        
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
            homePosition = position;
            currentState = WallMasterState.Hidden;
            stateTimer = 0f;
            stateDuration = GetRandomFloat(HIDDEN_TIME_MIN, HIDDEN_TIME_MAX);
            ChooseCreepDirection();
        }
        
        public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);
            
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            stateTimer += deltaTime;

            switch (currentState)
            {
                case WallMasterState.Hidden:
                    UpdateHidden();
                    break;

                case WallMasterState.Creeping:
                    UpdateCreeping(deltaTime);
                    break;

                case WallMasterState.Retreating:
                    UpdateRetreating(deltaTime);
                    break;
            }
            
            return sprite.Update(gameTime);
        }

        private void UpdateHidden()
        {
            if (stateTimer >= stateDuration)
            {
                currentState = WallMasterState.Creeping;
                stateTimer = 0f;
                stateDuration = GetRandomFloat(CREEP_TIME_MIN, CREEP_TIME_MAX);
                ChooseCreepDirection();
            }
        }

        private void UpdateCreeping(float deltaTime)
        {
            // TODO instead of a fixed direction, we can change it to track link
            Position += creepDirection * CREEP_SPEED * deltaTime;

            if (stateTimer >= stateDuration)
            {
                currentState = WallMasterState.Retreating;
                stateTimer = 0f;
            }
        }

        private void UpdateRetreating(float deltaTime)
        {
            Vector2 directionToHome = homePosition - Position;
            float distanceToHome = directionToHome.Length();

            if (distanceToHome < RETREAT_SPEED * deltaTime)
            {
                Position = homePosition;
                currentState = WallMasterState.Hidden;
                stateTimer = 0f;
                stateDuration = GetRandomFloat(HIDDEN_TIME_MIN, HIDDEN_TIME_MAX);
            }
            else
            {
                directionToHome.Normalize();
                Position += directionToHome * RETREAT_SPEED * deltaTime;
            }
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!isAlive || currentState == WallMasterState.Hidden)
                return;

            sprite?.Draw(spriteBatch, location);
        }


        public override void Reset()
        {
            base.Reset();
            Position = homePosition;
            currentState = WallMasterState.Hidden;
            stateTimer = 0f;
            stateDuration = GetRandomFloat(HIDDEN_TIME_MIN, HIDDEN_TIME_MAX);
        }


        private void ChooseCreepDirection()
        {
            // TODO: Replace with direction towards link
            creepDirection = random.Next(4) switch
            {
                0 => new Vector2(0, -1),   // Up
                1 => new Vector2(0, 1),    // Down
                2 => new Vector2(-1, 0),   // Left
                3 => new Vector2(1, 0),    // Right
                _ => Vector2.UnitX,
            };

        }
        
        private float GetRandomFloat(float min, float max)
        {
            return min + (float)random.NextDouble() * (max - min);
        }
    }
}