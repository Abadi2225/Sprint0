using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using System.Collections.Generic;

namespace Sprint.Enemies.Concrete
{
    public class Stalfos : Enemy
    {
        private const int HEALTH = 2;
        private const int DAMAGE = 1;
        private const float MOVE_SPEED = 50f;
        private const float DIRECTION_CHANGE_INTERVAL = 2.0f;
        private const float FLIP_INTERVAL = 0.15f;
        private readonly Rectangle sourceRect;
        private readonly List<Sprint.Block.Block> solidBlocks;
        private readonly Rectangle innerBounds;
        private Vector2 velocity;
        private float directionChangeTimer;
        private bool isFlipped;
        private float flipTimer;

        public Stalfos(Texture2D texture, Vector2 position, List<Sprint.Block.Block> solidBlocks, Rectangle innerBounds)
            : base(texture, position, HEALTH, DAMAGE)
        {
            int spriteWidth = 16;
            int spriteHeight = 16;
            this.solidBlocks = solidBlocks;
            this.innerBounds = innerBounds;

            sourceRect = new Rectangle(1, 59, spriteWidth, spriteHeight);

            velocity = GetRandomCardinalDirection();
            directionChangeTimer = DIRECTION_CHANGE_INTERVAL;
            isFlipped = false;
            flipTimer = FLIP_INTERVAL;
            Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
        }

        private Vector2 GetRandomCardinalDirection()
        {
            return random.Next(4) switch
            {
                0 => new Vector2(0, -MOVE_SPEED),
                1 => new Vector2(0, MOVE_SPEED),
                2 => new Vector2(-MOVE_SPEED, 0),
                3 => new Vector2(MOVE_SPEED, 0),
                _ => Vector2.Zero,
            };
        }

        protected override void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive) return;
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

            Vector2 candidatePos = Position + velocity * deltaTime;
            if (!WouldIntersectBlock(candidatePos, solidBlocks) && !WouldIntersectWall(candidatePos, innerBounds))
                Position = candidatePos;
            else
            {
                velocity = GetRandomCardinalDirection();
                directionChangeTimer = DIRECTION_CHANGE_INTERVAL;
            }

            base.UpdateEnemy(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!isAlive) return;

            SpriteEffects effects = isFlipped ? SpriteEffects.FlipHorizontally : SpriteEffects.None;
            spriteBatch.Draw(texture, location, sourceRect, Color.White, 0f, Vector2.Zero, GameServices.ScaleFactor, effects, 0f);
        }
    }
}
