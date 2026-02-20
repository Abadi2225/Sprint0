using System;
using System.Numerics;
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
        
        // Rope is stationary most of the time; when it charges, it moves very fast
        private const float CHARGE_SPEED = 160f;
        private const float IDLE_DURATION = 1.5f;    // How long Rope waits before next patrol/charge
        private const float CHARGE_DURATION = 0.6f;  // How long Rope charges lasts

        private enum RopeState { Idle, Charging }
        private RopeState state;

        private Vector2 velocity;
        private float idleTimer;
        private float chargeTimer;
        private bool isFacingLeft;

        private readonly Random random;

        public Rope(Texture2D texture, Vector2 position) : base(texture, position, ROPE_HEALTH, ROPE_DAMAGE)
        {
            int[] frameXPositions = [126, 143];
            int frameY = 59;
            int spriteWidth = 15;
            int spriteHeight = 15;
            float frameTime = 0.15f;
            
            sprite = new AnimatedSprite(texture, position, frameXPositions, frameY, 
                                        spriteWidth, spriteHeight, frameTime);
            
            random = new Random();
            state = RopeState.Idle;
            idleTimer = IDLE_DURATION;
            velocity = Vector2.Zero;
            isFacingLeft = false;
        }
        
        private Vector2 GetRandomCardinalDirection()
        {
            int direction = random.Next(4);
            return direction switch
            {
                0 => new Vector2(0, -BOUNCE_SPEED),    // Up
                1 => new Vector2(0, BOUNCE_SPEED),     // Down
                2 => new Vector2(-BOUNCE_SPEED, 0),    // Left
                3 => new Vector2(BOUNCE_SPEED, 0),     // Right
                _ => Vector2.Zero,
            };

        }
        
        public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);
            
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            switch (state)
            {
                case RopeState.Idle:
                    idleTimer -= deltaTime;
                    if (idleTimer <= 0)
                    {
                        Vector2 direction = GetRandomCardinalDirection();
                        velocity = direction * CHARGE_SPEED;
                        isFacingLeft = velocity.X < 0;
                        state = RopeState.Charging;
                        chargeTimer = CHARGE_DURATION;
                    }
                    break;
                
                case RopeState.Charging:
                    chargeTimer -= deltaTime;
                    // Position is inherited from the Enemy base class
                    Position += velocity * deltaTime;

                    if (chargeTimer <= 0)
                    {
                        velocity = Vector2.Zero;
                        state = RopeState.Idle;
                        idleTimer = IDLE_DURATION;
                    }
                    break;
            }
            
            return base.Update(gameTime);
        }
    }
}