using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint.Enemies.Base;
using Sprint.Sprites;
using Sprint.Item;
using System.Collections.Generic;

namespace Sprint.Enemies.Concrete
{
    public class Goriya : Enemy
    {
        private enum GoriyaState { Walking, Throwing }
        private GoriyaState currentState;
        private const int HEALTH = 3;
        private const int DAMAGE = 1;
        private const float STEP_SIZE = 16f;
        private const float STEP_DELAY = 0.5f;
        private const float MOVE_SPEED = 100f;
        private const float THROW_COOLDOWN_MIN = 2.0f;
        private const float THROW_COOLDOWN_MAX = 4.0f;
        private const float BOOMERANG_SPEED = 3f;
        private const float BOOMERANG_RANGE = 400f;
        private List<Sprint.Block.Block> solidBlocks;
        private Rectangle innerBounds;

        private enum Direction { Up, Down, Left, Right }

        private Direction currentDirection;
        private Vector2 targetPosition;
        private float stepTimer;
        private float throwTimer;
        private bool spriteHorizontalFlip;
        private float flipTimer;
        const float FLIP_INTERVAL = 0.075f;
        private Boomerang activeBoomerang;
        private readonly ContentManager contentManager;
        private readonly Action<AbstractItem> spawnProjectile;

        private readonly int[] upFrames = [239];
        private readonly int[] downFrames = [222];
        private readonly int[] sideFrames = [256, 273];
        private readonly int[] throwFrame = [273];
        protected override bool FlipsOnVertical => true;

        public Goriya(Texture2D texture, Vector2 position, ContentManager content,
            List<Sprint.Block.Block> solidBlocks, Rectangle innerBounds,
            Action<AbstractItem> spawnProjectile = null) : base(texture, position, HEALTH, DAMAGE)
        {
            this.texture = texture;
            this.contentManager = content;
            this.solidBlocks = solidBlocks;
            this.innerBounds = innerBounds;
            this.spawnProjectile = spawnProjectile;
            int sheetY = 11;
            int spriteWidth = 16;
            int spriteHeight = 16;
            float frameTime = 0.2f;

            currentState = GoriyaState.Walking;
            currentDirection = Direction.Down;
            targetPosition = position;
            stepTimer = STEP_DELAY;
            flipTimer = FLIP_INTERVAL;
            throwTimer = GetRandomThrowTime();
            spriteHorizontalFlip = true;

            sprite = new DirectionalAnimatedSprite(texture, position, downFrames, sheetY,
                                        spriteWidth, spriteHeight, frameTime, true);
            Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
        }

        protected override void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive) return;

            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            throwTimer -= dt;

            if (currentState == GoriyaState.Walking)
            {
                throwTimer -= dt;
                if (throwTimer <= 0)
                {
                    ThrowBoomerang();
                }
            }

            switch (currentState)
            {
                case GoriyaState.Walking:
                    UpdateWalking(dt);
                    break;

                case GoriyaState.Throwing:
                    UpdateThrowing(dt);
                    break;
            }

            sprite.Update(gameTime);
        }

        private void UpdateWalking(float deltaTime)
        {
            if (Vector2.Distance(Position, targetPosition) > 1f)
            {
                Vector2 direction = targetPosition - Position;
                direction.Normalize();
                Position += direction * MOVE_SPEED * deltaTime;

                if (FlipsOnVertical && (currentDirection == Direction.Up || currentDirection == Direction.Down))
                {
                    flipTimer -= deltaTime;
                    if (flipTimer <= 0)
                    {
                        spriteHorizontalFlip = !spriteHorizontalFlip;
                        UpdateSprite();
                        flipTimer = FLIP_INTERVAL;
                    }
                }
            }
            else
            {
                Position = targetPosition;
                stepTimer -= deltaTime;

                if (stepTimer <= 0)
                {
                    ChooseNextStep();
                    stepTimer = STEP_DELAY;
                }
            }
        }

        private void UpdateThrowing(float deltaTime)
        {
            if (activeBoomerang == null || activeBoomerang.IsFinished)
            {
                activeBoomerang = null;
                currentState = GoriyaState.Walking;
                throwTimer = GetRandomThrowTime();
                UpdateSprite();
            }
        }

        private void ThrowBoomerang()
        {
            currentState = GoriyaState.Throwing;
            UpdateSprite();

            Vector2 throwVelocity = currentDirection switch
            {
                Direction.Up => new Vector2(0, -BOOMERANG_SPEED),
                Direction.Down => new Vector2(0, BOOMERANG_SPEED),
                Direction.Left => new Vector2(-BOOMERANG_SPEED, 0),
                Direction.Right => new Vector2(BOOMERANG_SPEED, 0),
                _ => new Vector2(-BOOMERANG_SPEED, 0)
            };

            activeBoomerang = ItemFactory.CreateEnemyBoomerang(GetThrowOrigin(), throwVelocity, BOOMERANG_RANGE).StartMoving();
            spawnProjectile?.Invoke(activeBoomerang);
        }

        private Vector2 GetThrowOrigin()
        {
            float scale = GameServices.ScaleFactor;
            int spriteSize = (int)(16 * scale);
            float cx = Position.X + spriteSize / 2f;
            float cy = Position.Y + spriteSize / 2f;
            return currentDirection switch
            {
                Direction.Up => new Vector2(cx, Position.Y),
                Direction.Down => new Vector2(cx, Position.Y + spriteSize),
                Direction.Left => new Vector2(Position.X, cy),
                Direction.Right => new Vector2(Position.X + spriteSize, cy),
                _ => new Vector2(cx, cy)
            };
        }

        public override void Die()
        {
            base.Die();
            activeBoomerang?.Cancel();
            activeBoomerang = null;
        }

        private void ChooseNextStep()
        {
            Vector2 candidate = ChooseValidStep(solidBlocks, innerBounds, STEP_SIZE);

            if (candidate != Position)
            {
                currentDirection = GetDirectionTo(candidate);
                targetPosition = candidate;
                flipTimer = FLIP_INTERVAL;
                UpdateSprite();
            }
        }

        private Direction GetDirectionTo(Vector2 target)
        {
            Vector2 diff = target - Position;
            if (MathF.Abs(diff.X) > MathF.Abs(diff.Y))
                return diff.X < 0 ? Direction.Left : Direction.Right;
            else
                return diff.Y < 0 ? Direction.Up : Direction.Down;
        }

        private void UpdateSprite()
        {
            var dirSprite = sprite as DirectionalAnimatedSprite;

            if (currentState == GoriyaState.Throwing)
            {
                int[] frame = currentDirection switch
                {
                    Direction.Up => upFrames,
                    Direction.Down => downFrames,
                    Direction.Left => throwFrame,
                    Direction.Right => throwFrame,
                    _ => throwFrame
                };

                bool flip = currentDirection == Direction.Left;
                dirSprite?.UpdateFrames(frame, flip);
            }
            else if (currentDirection == Direction.Up || currentDirection == Direction.Down)
            {
                int[] frames = currentDirection == Direction.Up ? upFrames : downFrames;
                dirSprite?.UpdateFrames(frames, spriteHorizontalFlip);
            }
            else if (currentDirection == Direction.Left)
            {
                dirSprite?.UpdateFrames(sideFrames, true);
            }
            else
            {
                dirSprite?.UpdateFrames(sideFrames, false);
            }
        }
        
        private float GetRandomThrowTime()
        {
            return THROW_COOLDOWN_MIN + (float)random.NextDouble() * (THROW_COOLDOWN_MAX - THROW_COOLDOWN_MIN);
        }
    }
}
