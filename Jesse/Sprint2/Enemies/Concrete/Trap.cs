using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;

namespace Sprint.Enemies.Concrete
{
    public class Trap : Enemy
    {
        private const int TRAP_HEALTH = 0;
        private const int TRAP_DAMAGE = 1;
        
        private const float MOVE_SPEED = 110f;
        private Vector2 velocity;
        private float directionChangeTimer;
        private const float DIRECTION_CHANGE_INTERVAL = 2.0f;
        private readonly Random random;

        // Sprite flipping for animation
        private Rectangle sourceRect;
        private bool isFlipped;
        private float flipTimer;
        private const float FLIP_INTERVAL = 0.15f;
        
        public Trap(Texture2D texture, Vector2 position) : base(texture, position, TRAP_HEALTH, TRAP_DAMAGE)
        {
            int frameX = 164;
            int frameY = 59;
            int spriteWidth = 15;
            int spriteHeight = 15;
            
            sourceRect = new Rectangle(frameX, frameY, spriteWidth, spriteHeight);
            
            random = new Random();
            velocity = GetRandomCardinalDirection();
            directionChangeTimer = DIRECTION_CHANGE_INTERVAL;
            isFlipped = false;
            flipTimer = FLIP_INTERVAL;
        }
        
        private Vector2 GetRandomCardinalDirection()
        {
            // Only move in 4 directions (up, down, left, right)
            int direction = random.Next(4);
            return direction switch
            {
                0 => new Vector2(0, -MOVE_SPEED),// Up
                1 => new Vector2(0, MOVE_SPEED),// Down
                2 => new Vector2(-MOVE_SPEED, 0),// Left
                3 => new Vector2(MOVE_SPEED, 0),// Right
                _ => (Vector2)Vector2.Zero,
            };

        }
        
        public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);
            
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            
            directionChangeTimer -= deltaTime;
            if (directionChangeTimer <= 0)
            {
                velocity = GetRandomCardinalDirection();
                directionChangeTimer = DIRECTION_CHANGE_INTERVAL;
            }

            flipTimer -= deltaTime;
            if (flipTimer <= 0)
            {
                isFlipped = !isFlipped;
                flipTimer = FLIP_INTERVAL;
            }
            
            // Update position
            Position += velocity * deltaTime;
            
            return base.Update(gameTime);
        }


        // Didn't use the animatedSprite class for this one since it only has 1 frame.
        public override void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!isAlive)
                return;
            
            SpriteEffects effects = isFlipped ? SpriteEffects.FlipHorizontally : SpriteEffects.None;

            Vector2 drawPosition = new Vector2(
                location.X - sourceRect.Width / 2,
                location.Y - sourceRect.Height / 2
            );

            spriteBatch.Draw(
                texture, 
                drawPosition, 
                sourceRect, 
                Color.White, 
                0f,
                Vector2.Zero, 
                2f, 
                effects, 
                0f
            );
        }
    }
}
