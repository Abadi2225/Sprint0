using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Rope : Enemy
    {
        private const int ROPE_HEALTH = 1;
        private const int ROPE_DAMAGE = 1;
        private const float PATROL_SPEED = 45f;
        private const float CHARGE_SPEED = 160f;
        private const float DIRECTION_CHANGE_MIN = 1.5f;
        private const float DIRECTION_CHANGE_MAX = 3f;
        private const float CHARGE_DURATION = 3f;

        private readonly Random random;
        private Vector2 moveDirection;
        private bool isCharging;
        private float chargeTimer;
        private float directionChangeTimer;
        private float directionChangeDuration;
        private bool facingLeft;

        readonly int[] frameXPositions = [126, 143];

        public Rope(Texture2D texture, Vector2 position) : base(texture, position, ROPE_HEALTH, ROPE_DAMAGE)
        {
            int frameY = 59;
            int spriteWidth = 15;
            int spriteHeight = 15;
            float frameTime = 0.3f;
            
            sprite = new DirectionalAnimatedSprite(texture, position, frameXPositions, frameY, 
                                        spriteWidth, spriteHeight, frameTime, false);
            
            random = new Random();
            isCharging = false;
            chargeTimer = 0f;
            directionChangeDuration = GetRandomFloat(DIRECTION_CHANGE_MIN, DIRECTION_CHANGE_MAX);
            directionChangeTimer = directionChangeDuration;
            ChooseRandomCardinalDirection();
        }

        public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);
            
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            // TODO: To trigger a charge, check whether Link's X position
            // matches Rope's X within a threshold (for vertical charge) or Link's Y matches
            // Rope's Y (for horizontal charge). If aligned, set isCharging = true, set
            // chargeTimer = CHARGE_DURATION, and set moveDirection toward Link.

            if (isCharging)
            {
                chargeTimer -= deltaTime;
                if (chargeTimer <= 0)
                {
                    isCharging = false;
                    directionChangeDuration = GetRandomFloat(DIRECTION_CHANGE_MIN, DIRECTION_CHANGE_MAX);
                    directionChangeTimer = directionChangeDuration;
                }
            }
            else
            {
                directionChangeTimer -= deltaTime;
                if (directionChangeTimer <= 0)
                {
                    directionChangeDuration = GetRandomFloat(DIRECTION_CHANGE_MIN, DIRECTION_CHANGE_MAX);
                    directionChangeTimer = directionChangeDuration;
                    ChooseRandomCardinalDirection();
                }
            }

            float currentSpeed = isCharging ? CHARGE_SPEED : PATROL_SPEED;
            Position += moveDirection * currentSpeed * deltaTime;

            UpdateSpriteFlip();
            
            return sprite.Update(gameTime);
        }
        
        private void ChooseRandomCardinalDirection()
        {
            moveDirection = random.Next(4) switch
            {
                0 => new Vector2(0, -1),   // Up
                1 => new Vector2(0, 1),    // Down
                2 => new Vector2(-1, 0),   // Left
                3 => new Vector2(1, 0),    // Right
                _ => Vector2.UnitX,
            };
        }

        private void UpdateSpriteFlip()
        {
            bool newFacingLeft = moveDirection.X < 0;
            if (newFacingLeft != facingLeft)
            {
                facingLeft = newFacingLeft;
                var dirSprite = sprite as DirectionalAnimatedSprite;
                dirSprite?.UpdateFrames(frameXPositions, facingLeft);
            }
        }
        
        private float GetRandomFloat(float min, float max)
        {
            return min + (float)random.NextDouble() * (max - min);
        }
    }
}