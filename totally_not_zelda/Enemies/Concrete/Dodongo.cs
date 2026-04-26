using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;
using System.Collections.Generic;

namespace Sprint.Enemies.Concrete
{
    public class Dodongo : Enemy
    {
        private enum DodongoState { Walking, BombEaten }
        private DodongoState currentState;
        private const int HEALTH = 2;
        private const int DAMAGE = 2;
        private const float STEP_SIZE = 16f;
        private const float STEP_DELAY = 0.5f;
        private const float MOVE_SPEED = 80f;
        private const float FLIP_INTERVAL = 0.1f;
        private const float BOMB_STUN_DURATION = 2.0f;
        protected override bool CanBeKnockedBack => false;
        
        private enum Direction { Up, Down, Left, Right }
        
        private Direction currentDirection;
        private Vector2 targetPosition;
        private float stepTimer;
        private float flipTimer;
        private float bombStunTimer;
        private int bombsEaten;
        private bool spriteHorizontalFlip;
        
        // side sprites are 32px wide, up/down are 16px wide
        private readonly int[] upFrames = [35];      
        private readonly int[] downFrames = [1];   
        private readonly int[] sideFrames = [69, 102];  
        private readonly int[] bombedUpFrame = [52];
        private readonly int[] bombedDownFrame = [18];
        private readonly int[] bombedSideFrame = [135];
        private List<Sprint.Block.Block> solidBlocks;
        private Rectangle innerBounds;
    protected override bool FlipsOnVertical => true;

        
        // Walks randomly in all four directions, eats bombs to take damage
        
        public Dodongo(Texture2D texture, Vector2 position, List<Sprint.Block.Block> solidBlocks, Rectangle innerBounds) : base(texture, position, HEALTH, DAMAGE)
        {
            this.texture = texture;
            this.solidBlocks = solidBlocks;
            this.innerBounds = innerBounds;
            
            currentState = DodongoState.Walking;
            currentDirection = Direction.Down;
            targetPosition = position;
            stepTimer = STEP_DELAY;
            flipTimer = FLIP_INTERVAL;
            spriteHorizontalFlip = false;
            
            sprite = new DirectionalAnimatedSprite(texture, position, downFrames, 58, 16, 16, 0.2f, false);
            Rect = new Rectangle((int)position.X, (int)position.Y, 16 * (int)GameServices.ScaleFactor, 16 * (int)GameServices.ScaleFactor);
        }
        
        protected override void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive) return;
            
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            switch (currentState)
            {
                case DodongoState.Walking:
                    UpdateWalking(dt);
                    break;
                    
                case DodongoState.BombEaten:
                    UpdateBombEaten(dt);
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
                Position = targetPosition;
                stepTimer -= deltaTime;
                
                if (stepTimer <= 0)
                {
                    ChooseNextStep();
                    stepTimer = STEP_DELAY;
                }
            }
        }

        private void UpdateBombEaten(float deltaTime)
        {
            bombStunTimer -= deltaTime;

            if (bombStunTimer <= 0)
            {
                if (bombsEaten >= HEALTH)
                {
                    base.TakeDamage(HEALTH);
                    return;
                }
                currentState = DodongoState.Walking;
                UpdateSprite();
            }
        }

        public override void TakeDamage(int damageAmount) { }

        public void EatBomb()
        {
            if (!isAlive || currentState == DodongoState.BombEaten) return;

            bombsEaten++;
            currentState = DodongoState.BombEaten;
            bombStunTimer = BOMB_STUN_DURATION;
            UpdateSprite();
        }
        
        private void ChooseNextStep()
        {
            Vector2 candidate = ChooseValidStep(solidBlocks, innerBounds, STEP_SIZE, minSteps: 1, maxSteps: 3);

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
            int sheetY = 58;
            float frameTime = 0.2f;
            
            switch (currentState)
            {
                case DodongoState.BombEaten:
                    UpdateBombedSprite(dirSprite, sheetY, frameTime);
                    break;
                    
                case DodongoState.Walking:
                    UpdateWalkingSprite(dirSprite, sheetY, frameTime);
                    break;
            }
        }

        private void UpdateBombedSprite(DirectionalAnimatedSprite dirSprite, int sheetY, float frameTime)
        {
            switch (currentDirection)
            {
                case Direction.Up:
                    sprite = new DirectionalAnimatedSprite(texture, Position, bombedUpFrame, sheetY, 16, 16, frameTime, false);
                    break;
                    
                case Direction.Down:
                    sprite = new DirectionalAnimatedSprite(texture, Position, bombedDownFrame, sheetY, 16, 16, frameTime, false);
                    break;
                    
                case Direction.Left:
                    sprite = new DirectionalAnimatedSprite(texture, Position, bombedSideFrame, sheetY, 32, 16, frameTime, true);
                    break;
                    
                case Direction.Right:
                    sprite = new DirectionalAnimatedSprite(texture, Position, bombedSideFrame, sheetY, 32, 16, frameTime, false);
                    break;
            }
        }

        private void UpdateWalkingSprite(DirectionalAnimatedSprite dirSprite, int sheetY, float frameTime)
        {
            switch (currentDirection)
            {
                case Direction.Up:
                    sprite = new DirectionalAnimatedSprite(texture, Position, upFrames, sheetY, 16, 16, frameTime, spriteHorizontalFlip);
                    break;
                    
                case Direction.Down:
                    sprite = new DirectionalAnimatedSprite(texture, Position, downFrames, sheetY, 16, 16, frameTime, spriteHorizontalFlip);
                    break;
                    
                case Direction.Left:
                    sprite = new DirectionalAnimatedSprite(texture, Position, sideFrames, sheetY, 32, 16, frameTime, true);
                    break;
                    
                case Direction.Right:
                    sprite = new DirectionalAnimatedSprite(texture, Position, sideFrames, sheetY, 32, 16, frameTime, false);
                    break;
            }
        }
        
        public override void Reset()
        {
            base.Reset();
            stepTimer = STEP_DELAY;
            flipTimer = FLIP_INTERVAL;
            currentDirection = Direction.Down;
            targetPosition = Position;
            bombsEaten = 0;
            currentState = DodongoState.Walking;
        }
    }
}