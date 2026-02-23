using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Sprint.Enemies.Base;
using Sprint.Sprites;
using Sprint.Item;

namespace Sprint.Enemies.Concrete
{
    public class Goriya : Enemy
    {
        private enum GoriyaState { Walking, Throwing }
        private GoriyaState currentState;
        private const int HEALTH = 3;
        private const int DAMAGE = 1;
        private const float STEP_SIZE = 16f;  // One tile/step
        private const float STEP_DELAY = 0.5f;  // Time between steps
        private const float MOVE_SPEED = 100f;  // Speed of actual movement
        private const float THROW_COOLDOWN_MIN = 2.0f;
        private const float THROW_COOLDOWN_MAX = 4.0f;

        private enum Direction { Up, Down, Left, Right }

        private Direction currentDirection;
        private Vector2 targetPosition;
        private float stepTimer;
        private float flipTimer;
        private float throwTimer;
        private bool spriteHorizontalFlip;
        const float FLIP_INTERVAL = 0.075f; //Time between flips for up/down walk
        private readonly Random random;
        private ItemFactory itemFactory;
        private Boomerang activeBoomerang;
        private ContentManager contentManager;

        // Sprite positions for each direction
        private readonly int[] upFrames = [239];
        private readonly int[] downFrames = [222];
        private readonly int[] sideFrames = [256, 273];
        private readonly int[] throwFrame = [273];


        // Attacks with boomerangs
        // Drops a heart, one rupee, four bombs, or a clock
        // Moves slowly in random directions, one step at a time

        public Goriya(Texture2D texture, Vector2 position, ContentManager content) : base(texture, position, HEALTH, DAMAGE)
        {
            this.texture = texture;
            this.contentManager = content;
            itemFactory = new ItemFactory(content);
            random = new Random();
            int sheetY = 11;
            int spriteWidth = 15;
            int spriteHeight = 15;
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
        }

        public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);

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

            activeBoomerang?.Update(gameTime);
            return sprite.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            base.Draw(spriteBatch, location);

            // Draw the boomerang if active
            activeBoomerang?.Draw(spriteBatch, Position);
        }

        private void UpdateWalking(float deltaTime)
        {
            // Check if we're moving to a target
            if (Vector2.Distance(Position, targetPosition) > 1f)
            {
                // Move toward target
                Vector2 direction = targetPosition - Position;
                direction.Normalize();
                Position += direction * MOVE_SPEED * deltaTime;

                if (currentDirection == Direction.Up || currentDirection == Direction.Down)
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
                // Reached target, wait before next step
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
            // Check if boomerang has returned (not thrown anymore)
            if (activeBoomerang != null)
            {
                var boomerangSprite = ((BoomerangSprite)activeBoomerang.GetSprite());

                if (!IsBoomerangActive())
                {
                    activeBoomerang = null;
                    currentState = GoriyaState.Walking;
                    throwTimer = GetRandomThrowTime();
                    UpdateSprite();
                }
            }
        }

        private void ThrowBoomerang()
        {
            currentState = GoriyaState.Throwing;
            UpdateSprite(); // Switch to throwing sprite

            // Calculate throw direction based on current facing direction
            Vector2 throwVelocity = currentDirection switch
            {
                Direction.Up => new Vector2(0, -3),
                Direction.Down => new Vector2(0, 3),
                Direction.Left => new Vector2(-3, 0),
                Direction.Right => new Vector2(3, 0),
                _ => new Vector2(-3, 0) // Default left
            };

            Boomerang boomerang = itemFactory.CreateBoomerang(Position, throwVelocity, 400f).StartMoving();
            activeBoomerang = boomerang;

            // Trigger the throw
            if (activeBoomerang.GetSprite() is BoomerangSprite bSprite)
            {
                bSprite.Throw();
            }
        }

        private bool IsBoomerangActive()
        {
            if (activeBoomerang == null)
                return false;

            var boomerangSprite = activeBoomerang.GetSprite() as BoomerangSprite;
            return boomerangSprite?.IsActive ?? false;
        }

        private void ChooseNextStep()
        {
            // Pick random direction and distance
            int numSteps = random.Next(1, 3);
            float distance = STEP_SIZE * numSteps;
            currentDirection = (Direction)random.Next(4);

            // Calculate new target position
            targetPosition = currentDirection switch
            {
                Direction.Up => Position + new Vector2(0, -distance),
                Direction.Down => Position + new Vector2(0, distance),
                Direction.Left => Position + new Vector2(-distance, 0),
                Direction.Right => Position + new Vector2(distance, 0),
                _ => Position
            };

            flipTimer = FLIP_INTERVAL;

            // Update sprite based on direction
            UpdateSprite();
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
            else // Right
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
