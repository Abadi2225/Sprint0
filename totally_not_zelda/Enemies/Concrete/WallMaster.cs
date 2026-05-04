using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using BlockType = Sprint.Block.Block;
using Sprint.Enemies.Base;
using Sprint.Sprites;
using System.Collections.Generic;

namespace Sprint.Enemies.Concrete
{
    public class WallMaster : Enemy
    {
        private const int HEALTH = 3;
        private const int DAMAGE = 1;
        private const int SPRITE_WIDTH = 16;
        private const int SPRITE_HEIGHT = 16;
        private const float CREEP_SPEED = 60f;
        private const float DETECTION_RANGE = 160f;
        private const float GRAB_RANGE = 12f;
        private const float ENTER_SPEED = 80f;
        private const float LEAVE_SPEED = 80f;
        private const float CHASE_DURATION = 20f;
        private const float REENTER_MIN = 7f;
        private const float REENTER_MAX = 12f;
        private const float CREEP_STEP_SIZE = 16f;
        private const float CREEP_STEP_DELAY = 0.8f;
        private const float WALL_THICKNESS_TILES = 31f;

        private enum WallMasterState { Hiding, Entering, Creeping, Chasing, Leaving, Cooldown }

        private readonly struct NavigationContext(List<BlockType> solidBlocks, Rectangle innerBounds)
        {
            public readonly List<BlockType> SolidBlocks = solidBlocks;
            public readonly Rectangle InnerBounds = innerBounds;
        }

        private readonly NavigationContext navigation;
        private WallMasterState currentState;
        private readonly Vector2 homePosition;
        private Vector2 entryTarget;
        private Vector2 leaveTarget;
        private bool movingVertically;
        private float chaseTimer;
        private float cooldownTimer;
        private Vector2 creepTarget;
        private float stepTimer;
        private Vector2 linkGrabOffset;
        private bool isGrabbingLink;

        public bool IsEntering => currentState == WallMasterState.Entering || currentState == WallMasterState.Hiding;
        public override bool HasCollision => currentState == WallMasterState.Chasing;

        public WallMaster(Texture2D texture, Vector2 position, List<BlockType> solidBlocks, Rectangle innerBounds)
            : base(texture, position, HEALTH, DAMAGE)
        {
            navigation = new NavigationContext(solidBlocks, innerBounds);
            homePosition = position;
            creepTarget = position;
            stepTimer = CREEP_STEP_DELAY;

            sprite = new AnimatedSprite(texture, position, [393, 410], 11, SPRITE_WIDTH, SPRITE_HEIGHT, 0.2f);
            Rect = new Rectangle((int)position.X, (int)position.Y,
                SPRITE_WIDTH * (int)GameServices.ScaleFactor,
                SPRITE_HEIGHT * (int)GameServices.ScaleFactor);

            SetupEntry(position);
        }

        private void SetupEntry(Vector2 spawnPosition)
        {
            Vector2 entryDirection = DetermineEntryDirection(spawnPosition);
            entryTarget = spawnPosition;
            Position = spawnPosition - entryDirection * SPRITE_WIDTH * GameServices.ScaleFactor;
            currentState = WallMasterState.Hiding;
        }

        private Vector2 DetermineEntryDirection(Vector2 spawnPosition)
        {
            Rectangle bounds = navigation.InnerBounds;
            float distLeft   = Math.Max(0, spawnPosition.X - bounds.Left);
            float distRight  = Math.Max(0, bounds.Right - spawnPosition.X);
            float distTop    = Math.Max(0, spawnPosition.Y - bounds.Top);
            float distBottom = Math.Max(0, bounds.Bottom - spawnPosition.Y);

            float min = MathHelper.Min(MathHelper.Min(distLeft, distRight),
                                       MathHelper.Min(distTop, distBottom));

            if (min == distRight)  return -Vector2.UnitX;
            if (min == distLeft)   return Vector2.UnitX;
            if (min == distBottom) return -Vector2.UnitY;
            return Vector2.UnitY;
        }

        private Vector2 ChooseNewWallPosition()
        {
            return random.Next(4) switch
            {
                0 => new Vector2(entryTarget.X, 0),
                1 => new Vector2(entryTarget.X, GameServices.GameHeight),
                2 => new Vector2(0, entryTarget.Y),
                3 => new Vector2(GameServices.GameWidth, entryTarget.Y),
                _ => entryTarget
            };
        }

        protected override void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive) return;

            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            switch (currentState)
            {
                case WallMasterState.Hiding:   UpdateHiding();      break;
                case WallMasterState.Entering: UpdateEntering(dt);  break;
                case WallMasterState.Creeping: UpdateCreeping(dt);  break;
                case WallMasterState.Chasing:  UpdateChasing(dt);   break;
                case WallMasterState.Leaving:  UpdateLeaving(dt);   break;
                case WallMasterState.Cooldown: UpdateCooldown(dt);  break;
            }

            if (currentState != WallMasterState.Cooldown)
                sprite.Update(gameTime);
        }

        private void UpdateHiding()
        {
            if (Vector2.Distance(GameServices.Link.Position, entryTarget) <= DETECTION_RANGE)
                currentState = WallMasterState.Entering;
        }

        private void UpdateEntering(float dt)
        {
            Vector2 toTarget = entryTarget - Position;
            if (toTarget.Length() < ENTER_SPEED * dt)
            {
                Position = entryTarget;
                currentState = WallMasterState.Creeping;
            }
            else
            {
                toTarget.Normalize();
                Position += toTarget * ENTER_SPEED * dt;
            }
        }

        private void UpdateCreeping(float dt)
        {
            stepTimer -= dt;
            if (stepTimer <= 0)
            {
                Vector2 candidate = ChooseValidStep(navigation.SolidBlocks, navigation.InnerBounds, CREEP_STEP_SIZE);
                if (candidate != Position)
                    creepTarget = candidate;
                stepTimer = CREEP_STEP_DELAY;
            }

            if (Vector2.Distance(Position, creepTarget) > 1f)
            {
                Vector2 dir = creepTarget - Position;
                dir.Normalize();
                Position += dir * CREEP_SPEED * dt;
            }
            else
            {
                Position = creepTarget;
            }

            if (Vector2.Distance(GameServices.Link.Position, Position) <= DETECTION_RANGE)
            {
                chaseTimer = CHASE_DURATION;
                currentState = WallMasterState.Chasing;
            }
        }

        private void UpdateChasing(float dt)
        {
            chaseTimer -= dt;

            Vector2 toLink = GameServices.Link.Position - Position;

            if (toLink.Length() <= GRAB_RANGE)
            {
                GrabLink();
                return;
            }

            if (chaseTimer <= 0)
            {
                leaveTarget = DetermineLeaveTarget();
                currentState = WallMasterState.Leaving;
                return;
            }

            if (movingVertically && Math.Abs(toLink.Y) < 1f)
                movingVertically = false;
            else if (!movingVertically && Math.Abs(toLink.X) < 1f)
                movingVertically = true;

            Vector2 direction = movingVertically
                ? new Vector2(0, Math.Sign(toLink.Y))
                : new Vector2(Math.Sign(toLink.X), 0);

            Position += direction * CREEP_SPEED * dt;
        }

        private void GrabLink()
        {
            (sprite as AnimatedSprite)?.SetFrame(1);
            linkGrabOffset = GameServices.Link.Position - Position;
            isGrabbingLink = true;
            GameServices.Link.IsGrabbed = true;
            leaveTarget = DetermineLeaveTarget();
            currentState = WallMasterState.Leaving;
        }

        private void UpdateLeaving(float dt)
        {
            Vector2 toLeave = leaveTarget - Position;
            if (toLeave.Length() < LEAVE_SPEED * dt)
            {
                Position = leaveTarget;
                if (isGrabbingLink)
                {
                    ReleaseLink();
                    return;
                }

                cooldownTimer = GetRandomFloat(REENTER_MIN, REENTER_MAX);
                currentState = WallMasterState.Cooldown;
            }
            else
            {
                toLeave.Normalize();
                Position += toLeave * LEAVE_SPEED * dt;
                if (isGrabbingLink)
                    GameServices.Link.Position = Position + linkGrabOffset;
            }
        }

        private void ReleaseLink()
        {
            GameServices.Link.Position = Position + linkGrabOffset;
            isGrabbingLink = false;
            GameServices.Link.IsGrabbed = false;
            GameServices.OnLinkGrabbed?.Invoke();
        }

        private void UpdateCooldown(float dt)
        {
            cooldownTimer -= dt;
            if (cooldownTimer <= 0)
                SetupEntry(ChooseNewWallPosition());
        }

        private Vector2 DetermineLeaveTarget()
        {
            Rectangle bounds = navigation.InnerBounds;
            float distLeft   = Position.X - bounds.Left;
            float distRight  = bounds.Right - Position.X;
            float distTop    = Position.Y - bounds.Top;
            float distBottom = bounds.Bottom - Position.Y;

            float wallThickness = WALL_THICKNESS_TILES * GameServices.ScaleFactor;
            float min = MathHelper.Min(MathHelper.Min(distLeft, distRight),
                                       MathHelper.Min(distTop, distBottom));

            if (min == distLeft)  return new Vector2(bounds.Left - Rect.Width - wallThickness, Position.Y);
            if (min == distRight) return new Vector2(bounds.Right + Rect.Width + wallThickness, Position.Y);
            if (min == distTop)   return new Vector2(Position.X, bounds.Top - Rect.Height - wallThickness);
            return new Vector2(Position.X, bounds.Bottom + Rect.Height + wallThickness);
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
