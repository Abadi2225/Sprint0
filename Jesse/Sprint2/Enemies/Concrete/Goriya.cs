using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

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
        
        private enum Direction { Up, Down, Left, Right }
        
        private Direction currentDirection;
        private Vector2 targetPosition;
        private float stepTimer;
        private bool spriteHorizontalFlip;
        private readonly Random random;
        
        // Sprite positions for each direction
        private readonly int[] upFrames = [239];      
        private readonly int[] downFrames = [222];   
        private readonly int[] sideFrames = [256, 273];

        
        // Attacks with boomerangs
        // Drops a heart, one rupee, four bombs, or a clock
        // Moves slowly in random directions, one step at a time
        
        public Goriya(Texture2D texture, Vector2 position) : base(texture, position, HEALTH, DAMAGE)
        {
            this.texture = texture;
            random = new Random();
            int sheetY = 11;
            int spriteWidth = 15;
            int spriteHeight = 15;
            float frameTime = 0.2f;
            
            currentState = GoriyaState.Walking;
            currentDirection = Direction.Down;
            targetPosition = position;
            stepTimer = STEP_DELAY;
            spriteHorizontalFlip = true;
            
            sprite = new DirectionalAnimatedSprite(texture, position, downFrames, sheetY, 
                                        spriteWidth, spriteHeight, frameTime, true);
        }
        
       public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);
            
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            switch (currentState)
            {
                case GoriyaState.Walking:
                UpdateWalking(dt);
                break;
                
                case GoriyaState.Throwing:
                break;
            }
            return sprite.Update(gameTime);
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
            
            // Update sprite based on direction
            UpdateSprite();
        }
        
       private void UpdateSprite()
        {
            var dirSprite = sprite as DirectionalAnimatedSprite;
            
                if (currentDirection == Direction.Up || currentDirection == Direction.Down)
                {
                    SpriteEffects effect = spriteHorizontalFlip ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
                    spriteHorizontalFlip = !spriteHorizontalFlip;
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
    }
}