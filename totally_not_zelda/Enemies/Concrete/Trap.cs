using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Trap : Enemy
    {
        private const int TRAP_HEALTH = 1;
        private const int TRAP_DAMAGE = 1;
        private const float CHARGE_SPEED = 200f;
        private const float RETRACT_SPEED = 40f;
        private const float CHARGE_DISTANCE = 96f;
        private const float IDLE_TIME_MIN = 2f;
        private const float IDLE_TIME_MAX = 4f;
        
        private enum TrapState { Idle, Charging, Retracting }

        private readonly Random random;
        private TrapState currentState;
        private Vector2 homePosition;
        private Vector2 chargeDirection;
        private Vector2 chargeTarget;
        private float idleTimer;
        private float idleDuration;

        private readonly Rectangle sourceRect;
        
        public Trap(Texture2D texture, Vector2 position) : base(texture, position, TRAP_HEALTH, TRAP_DAMAGE, isInvincible: true)
        {
            int frameX = 164;
            int frameY = 59;
            int spriteWidth = 15;
            int spriteHeight = 15;
            
            sourceRect = new Rectangle(frameX, frameY, spriteWidth, spriteHeight);
            
            sprite = new StaticSprite(texture, position, sourceRect);

            random = new Random();
            homePosition = position;
            currentState = TrapState.Idle;
            idleTimer = 0f;
            idleDuration = GetRandomFloat(IDLE_TIME_MIN, IDLE_TIME_MAX);
            chargeDirection = Vector2.Zero;
            chargeTarget = position;
        }

        public override void Update(GameTime gameTime)
        {            
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            switch (currentState)
            {
                case TrapState.Idle:
                    UpdateIdle(deltaTime);
                    break;
                
                case TrapState.Charging:
                    UpdateCharging(deltaTime);
                    break;

                case TrapState.Retracting:
                    UpdateRetracting(deltaTime);
                    break;
            }
        }

        private void UpdateIdle(float deltaTime)
        {
            // TODO: Change from timer trigger to link alining with the trap.
            idleTimer += deltaTime;

            if (idleTimer >= idleDuration)
            {
                StartCharge();
            }
        }

        private void UpdateCharging(float deltaTime)
        {
            Vector2 ToTarget = chargeTarget - Position;
            float distanceRemaining = ToTarget.Length();

            if (distanceRemaining < CHARGE_SPEED * deltaTime)
            {
                Position = chargeTarget;
                currentState = TrapState.Retracting;
            }
            else
            {
                Position += chargeDirection * CHARGE_SPEED * deltaTime;
            }
        }

        private void UpdateRetracting(float deltaTime)
        {
            Vector2 ToHome = homePosition - Position;
            float distanceRemaining = ToHome.Length();

            if (distanceRemaining < RETRACT_SPEED * deltaTime)
            {
                Position = homePosition;
                currentState = TrapState.Idle;
                idleTimer = 0f;
                idleDuration = GetRandomFloat(IDLE_TIME_MIN, IDLE_TIME_MAX);
            }
            else
            {
                ToHome.Normalize();
                Position += ToHome * RETRACT_SPEED * deltaTime;
            }
        }

        private void StartCharge()
        {
            // TODO: Replace with direction towards link when we have the link reference in the trap.
            chargeDirection = random.Next(4) switch
            {
                0 => new Vector2(0, -1),   // Up
                1 => new Vector2(0, 1),    // Down
                2 => new Vector2(-1, 0),   // Left
                3 => new Vector2(1, 0),    // Right
                _ => Vector2.UnitX,
            };
            chargeTarget = homePosition + chargeDirection * CHARGE_DISTANCE;
            currentState = TrapState.Charging;
        }

        public override void TakeDamage(int damageAmount) { }
        public override void Die() { }

        public override void Reset()
        {
            base.Reset();
            Position = homePosition;
            currentState = TrapState.Idle;
            idleTimer = 0f;
            idleDuration = GetRandomFloat(IDLE_TIME_MIN, IDLE_TIME_MAX);
        }

        private float GetRandomFloat(float min, float max)
        {
            return min + (float)random.NextDouble() * (max - min);
        }
    }
}
