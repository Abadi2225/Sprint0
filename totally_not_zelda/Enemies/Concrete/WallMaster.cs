using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;
using System.Collections.Generic;

namespace Sprint.Enemies.Concrete
{
    public class WallMaster : Enemy
    {
        private const int WALLMASTER_HEALTH = 2;
        private const int WALLMASTER_DAMAGE = 1;
        private const float CREEP_SPEED = 60f;
        private const float DETECTION_RANGE = 160f;
        private const float GRAB_RANGE = 12f;
        private const float ENTER_SPEED = 80f;
        private const float LEAVE_SPEED = 80f;
        private const float CHASE_DURATION = 20f;
        private const float REENTER_MIN = 7f;
        private const float REENTER_MAX = 12f;

        private enum WallMasterState { Hiding, Entering, Creeping, Chasing, Leaving, Cooldown }

        private WallMasterState currentState;
        private Vector2 homePosition;
        private Vector2 entryStart;
        private Vector2 entryTarget;
        private Vector2 leaveTarget;
        private bool movingVertically;
        private float chaseTimer;
        private float cooldownTimer;
        private Rectangle innerBounds;
        public bool IsEntering => currentState == WallMasterState.Entering || currentState == WallMasterState.Hiding;
        public override bool HasCollision => currentState == WallMasterState.Chasing;
        private const float CREEP_STEP_SIZE = 16f;
        private const float CREEP_STEP_DELAY = 0.8f;
        private Vector2 creepTarget;
        private float stepTimer;
        private List<Sprint.Block.Block> solidBlocks;
        private Vector2 linkGrabOffset;
        private bool isGrabbingLink;

        public WallMaster(Texture2D texture, Vector2 position, List<Sprint.Block.Block> solidBlocks, Rectangle innerBounds) : base(texture, position, WALLMASTER_HEALTH, WALLMASTER_DAMAGE)
        {
            int[] frameXPositions = [393, 410];
            int frameY = 11;
            int spriteWidth = 16;
            int spriteHeight = 16;
            float frameTime = 0.2f;
            this.innerBounds = innerBounds;
            this.solidBlocks = solidBlocks;
            creepTarget = position;
            stepTimer = CREEP_STEP_DELAY;

            sprite = new AnimatedSprite(texture, position, frameXPositions, frameY,
                                        spriteWidth, spriteHeight, frameTime);

            homePosition = position;
            SetupEntry(position);

            Rect = new Rectangle((int)position.X, (int)position.Y,
                                spriteWidth * (int)GameServices.ScaleFactor,
                                spriteHeight * (int)GameServices.ScaleFactor);
        }

        private void SetupEntry(Vector2 spawnPosition)
        {
            Vector2 entryDirection = DetermineEntryDirection(spawnPosition);
            entryStart = spawnPosition - entryDirection * 16f * GameServices.ScaleFactor;
            entryTarget = spawnPosition;
            Position = entryStart;
            currentState = WallMasterState.Hiding;
        }

       private Vector2 DetermineEntryDirection(Vector2 spawnPosition)
        {
            float distLeft   = Math.Max(0, spawnPosition.X - innerBounds.Left);
            float distRight  = Math.Max(0, innerBounds.Right - spawnPosition.X);
            float distTop    = Math.Max(0, spawnPosition.Y - innerBounds.Top);
            float distBottom = Math.Max(0, innerBounds.Bottom - spawnPosition.Y);

            float min = MathHelper.Min(MathHelper.Min(distLeft, distRight),
                                    MathHelper.Min(distTop, distBottom));

            if (min == distRight)  return -Vector2.UnitX;  // right wall, enter leftward
            else if (min == distLeft)   return Vector2.UnitX;   // left wall, enter rightward
            else if (min == distBottom) return -Vector2.UnitY;  // bottom wall, enter upward
            else return Vector2.UnitY;                           // top wall, enter downward
        }

        // Pick a random wall position different from the current one
        private Vector2 ChooseNewWallPosition()
        {
            int wall = random.Next(4);
            float scaledWidth = GameServices.GameWidth;
            float scaledHeight = GameServices.GameHeight;

            return wall switch
            {
                0 => new Vector2(entryTarget.X, 0),                      // top
                1 => new Vector2(entryTarget.X, scaledHeight),            // bottom
                2 => new Vector2(0, entryTarget.Y),                      // left
                3 => new Vector2(scaledWidth, entryTarget.Y),            // right
                _ => entryTarget
            };
        }

        public override void Update(GameTime gameTime)
        {
            if (!isAlive) return;

            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            switch (currentState)
            {
                case WallMasterState.Hiding:
                    UpdateHiding();
                    break;
                case WallMasterState.Entering:
                    UpdateEntering(dt);
                    break;
                case WallMasterState.Creeping:
                    UpdateCreeping(dt);
                    break;
                case WallMasterState.Chasing:
                    UpdateChasing(dt);
                    break;
                case WallMasterState.Leaving:
                    UpdateLeaving(dt);
                    break;
                case WallMasterState.Cooldown:
                    UpdateCooldown(dt);
                    break;
            }

            if (currentState != WallMasterState.Cooldown)
                sprite.Update(gameTime);
        }

        private void UpdateHiding()
        {
            float dist = Vector2.Distance(GameServices.Link.Position, entryTarget);
            if (dist <= DETECTION_RANGE)
                currentState = WallMasterState.Entering;
        }

        private void UpdateEntering(float deltaTime)
        {
            Vector2 toTarget = entryTarget - Position;
            if (toTarget.Length() < ENTER_SPEED * deltaTime)
            {
                Position = entryTarget;
                currentState = WallMasterState.Creeping;
            }
            else
            {
                toTarget.Normalize();
                Position += toTarget * ENTER_SPEED * deltaTime;
            }
        }

        private void UpdateCreeping(float deltaTime)
        {
            // Random tile-based movement
            stepTimer -= deltaTime;
            if (stepTimer <= 0)
            {
                Vector2 candidate = ChooseValidStep(solidBlocks, innerBounds, CREEP_STEP_SIZE);
                if (candidate != Position)
                    creepTarget = candidate;
                stepTimer = CREEP_STEP_DELAY;
            }

            if (Vector2.Distance(Position, creepTarget) > 1f)
            {
                Vector2 dir = creepTarget - Position;
                dir.Normalize();
                Position += dir * CREEP_SPEED * deltaTime;
            }
            else
            {
                Position = creepTarget;
            }

            // Check if Link is within detection range
            float dx = GameServices.Link.Position.X - Position.X;
            float dy = GameServices.Link.Position.Y - Position.Y;
            float dist = new Vector2(dx, dy).Length();

            if (dist <= DETECTION_RANGE)
            {
                chaseTimer = CHASE_DURATION;
                currentState = WallMasterState.Chasing;
            }
        }

        private void UpdateChasing(float deltaTime)
        {
            chaseTimer -= deltaTime;

            float dx = GameServices.Link.Position.X - Position.X;
            float dy = GameServices.Link.Position.Y - Position.Y;
            float dist = new Vector2(dx, dy).Length();

            if (dist <= GRAB_RANGE)
            {
                ((AnimatedSprite)sprite).SetFrame(1);
                linkGrabOffset = GameServices.Link.Position - Position;
                isGrabbingLink = true;
                GameServices.Link.IsGrabbed = true;
                leaveTarget = DetermineLeaveTarget();
                currentState = WallMasterState.Leaving;
                return;
            }

            if (chaseTimer <= 0)
            {
                // Failed to catch Link — leave through nearest wall
                leaveTarget = DetermineLeaveTarget();
                currentState = WallMasterState.Leaving;
                return;
            }

            if (movingVertically && Math.Abs(dy) < 1f)
                movingVertically = false;
            else if (!movingVertically && Math.Abs(dx) < 1f)
                movingVertically = true;

            Vector2 direction = movingVertically
                ? new Vector2(0, Math.Sign(dy))
                : new Vector2(Math.Sign(dx), 0);

            Position += direction * CREEP_SPEED * deltaTime;
        }

        private void UpdateLeaving(float deltaTime)
        {
            Vector2 toLeave = leaveTarget - Position;
            if (toLeave.Length() < LEAVE_SPEED * deltaTime)
            {
                Position = leaveTarget;
                if (isGrabbingLink)
                {
                    GameServices.Link.Position = Position + linkGrabOffset;
                    isGrabbingLink = false;
                    GameServices.Link.IsGrabbed = false;
                    GameServices.OnLinkGrabbed?.Invoke();
                    return;
                }

                cooldownTimer = REENTER_MIN + (float)random.NextDouble() * (REENTER_MAX - REENTER_MIN);
                currentState = WallMasterState.Cooldown;
            }
            else
            {
                toLeave.Normalize();
                Position += toLeave * LEAVE_SPEED * deltaTime;
                if (isGrabbingLink)
                    GameServices.Link.Position = Position + linkGrabOffset;
            }
        }

        private void UpdateCooldown(float deltaTime)
        {
            cooldownTimer -= deltaTime;
            if (cooldownTimer <= 0)
            {
                Vector2 newSpawn = ChooseNewWallPosition();
                entryTarget = newSpawn;
                SetupEntry(newSpawn);
            }
        }

        private Vector2 DetermineLeaveTarget()
        {
            float distLeft   = Position.X - innerBounds.Left;
            float distRight  = innerBounds.Right - Position.X;
            float distTop    = Position.Y - innerBounds.Top;
            float distBottom = innerBounds.Bottom - Position.Y;

            float wallThickness = 31 * GameServices.ScaleFactor;
            float min = MathHelper.Min(MathHelper.Min(distLeft, distRight),
                                    MathHelper.Min(distTop, distBottom));

            if (min == distLeft)   return new Vector2(innerBounds.Left - Rect.Width - wallThickness, Position.Y);
            if (min == distRight)  return new Vector2(innerBounds.Right + Rect.Width + wallThickness, Position.Y);
            if (min == distTop)    return new Vector2(Position.X, innerBounds.Top - Rect.Height - wallThickness);
            return new Vector2(Position.X, innerBounds.Bottom + Rect.Height + wallThickness);
        }
        public override void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!isAlive || currentState == WallMasterState.Cooldown || currentState == WallMasterState.Hiding) return;
            sprite?.Draw(spriteBatch, location);
        }

        public override void Reset()
        {
            base.Reset();
            SetupEntry(homePosition);
        }
    }
}