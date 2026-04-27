using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Trap : Enemy
    {
        private const int HEALTH = 1;
        private const int DAMAGE = 1;
        private const float CHARGE_SPEED = 200f;
        private const float RETRACT_SPEED = 80f;

        private enum TrapState { Idle, Charging, Retracting }

        private TrapState currentState;
        private readonly Vector2 homePosition;
        private Vector2 chargeDirection;
        private Vector2 chargeTarget;
        protected override bool CanBeKnockedBack => false;

        public Trap(Texture2D texture, Vector2 position) : base(texture, position, HEALTH, DAMAGE, isInvincible: true)
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
            bool sameRow = Rect.Top < GameServices.Link.Rect.Bottom && GameServices.Link.Rect.Top < Rect.Bottom;
            bool sameColumn = Rect.Left < GameServices.Link.Rect.Right && GameServices.Link.Rect.Left < Rect.Right;

            switch (currentState)
            {
                case TrapState.Idle:
                    if (sameColumn || sameRow)
                        StartCharge(sameRow, sameColumn);
                    break;

                case TrapState.Charging:
                    UpdateCharging(deltaTime);
                    break;

                case TrapState.Retracting:
                    UpdateRetracting(deltaTime);
                    break;
            }
        }

        private void UpdateCharging(float deltaTime)
        {
            Vector2 toTarget = chargeTarget - Position;
            if (toTarget.Length() < CHARGE_SPEED * deltaTime)
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
            Vector2 toHome = homePosition - Position;
            if (toHome.Length() < RETRACT_SPEED * deltaTime)
            {
                Position = homePosition;
                currentState = TrapState.Idle;
            }
            else
            {
                toHome.Normalize();
                Position += toHome * RETRACT_SPEED * deltaTime;
            }
        }

        private void StartCharge(bool sameRow, bool sameColumn)
        {
            if (sameRow && !sameColumn)
            {
                chargeDirection = Rect.X < GameServices.Link.Rect.X ? Vector2.UnitX : -Vector2.UnitX;
            }
            else if (sameColumn && !sameRow)
            {
                chargeDirection = Rect.Y < GameServices.Link.Rect.Y ? Vector2.UnitY : -Vector2.UnitY;
            }
            else return;

            chargeTarget = chargeDirection.X != 0
                ? new Vector2(GameServices.Link.Rect.X, homePosition.Y)
                : new Vector2(homePosition.X, GameServices.Link.Rect.Y);

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
