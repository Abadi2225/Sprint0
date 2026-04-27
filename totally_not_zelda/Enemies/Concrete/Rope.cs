using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;
using System.Collections.Generic;

namespace Sprint.Enemies.Concrete
{
    public class Rope : Enemy
    {
        private const int HEALTH = 1;
        private const int DAMAGE = 1;
        private const float PATROL_SPEED = 45f;
        private const float CHARGE_SPEED = 160f;
        private const float DIRECTION_CHANGE_MIN = 1.5f;
        private const float DIRECTION_CHANGE_MAX = 3f;
        private const float CHARGE_DURATION = 1f;
        private const float CHARGE_COOLDOWN = 2f;
        private readonly List<Sprint.Block.Block> solidBlocks;
        private readonly Rectangle innerBounds;
        private readonly int[] frameXPositions = [127, 144];

        private Vector2 moveDirection;
        private bool isCharging;
        private float chargeTimer;
        private float chargeCooldownTimer;
        private float directionChangeTimer;
        private float directionChangeDuration;
        private bool facingLeft;

        public override bool BoomerangKills => true;

        public Rope(Texture2D texture, Vector2 position, List<Sprint.Block.Block> solidBlocks, Rectangle innerBounds)
            : base(texture, position, HEALTH, DAMAGE)
        {
            int frameY = 59;
            int spriteWidth = 15;
            int spriteHeight = 15;
            float frameTime = 0.3f;
            this.solidBlocks = solidBlocks;
            this.innerBounds = innerBounds;

            sprite = new DirectionalAnimatedSprite(texture, position, frameXPositions, frameY,
                                        spriteWidth, spriteHeight, frameTime, false);

            isCharging = false;
            chargeTimer = 0f;
            directionChangeDuration = GetRandomFloat(DIRECTION_CHANGE_MIN, DIRECTION_CHANGE_MAX);
            directionChangeTimer = directionChangeDuration;
            ChooseRandomCardinalDirection();
            Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
        }

        protected override void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive) return;

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (chargeCooldownTimer > 0)
                chargeCooldownTimer -= deltaTime;

            if (!isCharging && chargeCooldownTimer <= 0)
            {
                Rectangle linkRect = GameServices.Link.Rect;
                bool sameRow = Rect.Top < linkRect.Bottom && linkRect.Top < Rect.Bottom;
                bool sameCol = Rect.Left < linkRect.Right && linkRect.Left < Rect.Right;

                if (sameRow || sameCol)
                {
                    isCharging = true;
                    chargeTimer = CHARGE_DURATION;
                    Vector2 toLink = linkRect.Center.ToVector2() - Rect.Center.ToVector2();
                    if (sameRow && (!sameCol || Math.Abs(toLink.X) >= Math.Abs(toLink.Y)))
                        moveDirection = toLink.X >= 0 ? Vector2.UnitX : -Vector2.UnitX;
                    else
                        moveDirection = toLink.Y >= 0 ? Vector2.UnitY : -Vector2.UnitY;
                }
            }

            if (isCharging)
            {
                chargeTimer -= deltaTime;
                if (chargeTimer <= 0)
                {
                    isCharging = false;
                    chargeCooldownTimer = CHARGE_COOLDOWN;
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
            Vector2 candidatePosition = Position + moveDirection * currentSpeed * deltaTime;
            if (!WouldIntersectBlock(candidatePosition, solidBlocks) && !WouldIntersectWall(candidatePosition, innerBounds))
                Position = candidatePosition;
            else
            {
                isCharging = false;
                chargeCooldownTimer = CHARGE_COOLDOWN;
                directionChangeDuration = GetRandomFloat(DIRECTION_CHANGE_MIN, DIRECTION_CHANGE_MAX);
                directionChangeTimer = directionChangeDuration;
                ChooseRandomCardinalDirection();
            }

            UpdateSpriteFlip();
            sprite.Update(gameTime);
        }

        private void ChooseRandomCardinalDirection()
        {
            moveDirection = random.Next(4) switch
            {
                0 => new Vector2(0, -1),
                1 => new Vector2(0, 1),
                2 => new Vector2(-1, 0),
                3 => new Vector2(1, 0),
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

    }
}
