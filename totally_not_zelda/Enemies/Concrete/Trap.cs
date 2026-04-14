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
        private const float RETRACT_SPEED = 80f;
        
        private enum TrapState { Idle, Charging, Retracting }

        private TrapState currentState;
        private Vector2 homePosition;
        private Vector2 chargeDirection;
        private Vector2 chargeTarget;
        private bool sameRow;
        private bool sameColumn;
        protected override bool CanBeKnockedBack => false;
        
        public Trap(Texture2D texture, Vector2 position) : base(texture, position, TRAP_HEALTH, TRAP_DAMAGE, isInvincible: true)
        {
            int frameX = 164;
            int frameY = 59;
            int spriteWidth = 16;
            int spriteHeight = 16;
                        
            sprite = new StaticSprite(texture, position, new Rectangle(frameX, frameY, spriteWidth, spriteHeight));

            homePosition = position;
            currentState = TrapState.Idle;
            chargeDirection = Vector2.Zero;
            Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
        }

        protected override void UpdateEnemy(GameTime gameTime)
        {       
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            sameRow = Rect.Top < GameServices.Link.Rect.Bottom && GameServices.Link.Rect.Top < Rect.Bottom;
            sameColumn = Rect.Left < GameServices.Link.Rect.Right && GameServices.Link.Rect.Left < Rect.Right;
            switch (currentState)
            {
                case TrapState.Idle:
                    UpdateIdle();
                    break;
                
                case TrapState.Charging:
                    UpdateCharging(deltaTime);
                    break;

                case TrapState.Retracting:
                    UpdateRetracting(deltaTime);
                    break;
            }
        }

        private void UpdateIdle()
        {
            if (sameColumn || sameRow)
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
            }
            else
            {
                ToHome.Normalize();
                Position += ToHome * RETRACT_SPEED * deltaTime;
            }
        }

        private void StartCharge()
        {
            if (sameRow && !sameColumn)
            {
                if (Rect.X < GameServices.Link.Rect.X)
                    chargeDirection = Vector2.UnitX;
                else
                    chargeDirection = -Vector2.UnitX;
            }
            else if (sameColumn && !sameRow)
            {
                if (Rect.Y < GameServices.Link.Rect.Y)
                    chargeDirection = Vector2.UnitY;
                else
                    chargeDirection = -Vector2.UnitY;
            }
            else return;
            if (chargeDirection.X != 0)
            {
                chargeTarget = new Vector2(GameServices.Link.Rect.X, homePosition.Y);
            }
            else if (chargeDirection.Y != 0)
            {
                chargeTarget = new Vector2(homePosition.X, GameServices.Link.Rect.Y);
            }
            currentState = TrapState.Charging;
        }

        public override void TakeDamage(int damageAmount) { }
        public override void Die() { }

        public override void Reset()
        {
            base.Reset();
            Position = homePosition;
            currentState = TrapState.Idle;
        }
    }
}
