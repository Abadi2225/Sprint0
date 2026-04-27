using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;
using System.Collections.Generic;

namespace Sprint.Enemies.Concrete
{
    public class Zol : Enemy
    {
        private const int HEALTH = 1;
        private const int DAMAGE = 1;
        private const float BOUNCE_SPEED = 40f;
        private const float TURN_INTERVAL = 1f;
        private readonly List<Sprint.Block.Block> solidBlocks;
        private readonly Rectangle innerBounds;
        private Vector2 velocity;
        private float turnTimer;

        public Zol(Texture2D texture, Vector2 position, List<Sprint.Block.Block> solidBlocks, Rectangle innerBounds) : base(texture, position, HEALTH, DAMAGE)
        {
            int[] frameXPositions = [77, 94];
            int frameY = 11;
            int spriteWidth = 16;
            int spriteHeight = 16;
            float frameTime = 0.2f;
            this.solidBlocks = solidBlocks;
            this.innerBounds = innerBounds;

            sprite = new AnimatedSprite(texture, position, frameXPositions, frameY, spriteWidth, spriteHeight, frameTime);

            turnTimer = TURN_INTERVAL;
            velocity = Vector2.Zero;
            Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
        }

        protected override void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive) return;

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            turnTimer -= deltaTime;
            if (turnTimer <= 0)
            {
                velocity = GetRandomTurnDirection();
                turnTimer = TURN_INTERVAL;
            }

            Vector2 candidatePosition = Position + velocity * deltaTime;
            if (!WouldIntersectBlock(candidatePosition, solidBlocks) && !WouldIntersectWall(candidatePosition, innerBounds))
                Position = candidatePosition;
            else
                velocity = GetRandomTurnDirection();

            base.UpdateEnemy(gameTime);
        }

        public override void Reset()
        {
            base.Reset();
            turnTimer = TURN_INTERVAL;
            velocity = Vector2.Zero;
        }

        private Vector2 GetRandomTurnDirection()
        {
            return random.Next(4) switch
            {
                0 => new Vector2(0, -BOUNCE_SPEED),
                1 => new Vector2(0, BOUNCE_SPEED),
                2 => new Vector2(-BOUNCE_SPEED, 0),
                3 => new Vector2(BOUNCE_SPEED, 0),
                _ => Vector2.Zero,
            };
        }
    }
}
