using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Keese : Enemy
    {
        private const int HEALTH = 1;
        private const int DAMAGE = 1;
        private const float MOVE_SPEED = 40f;
        private const float REST_TIME_MIN = 0.5f;
        private const float REST_TIME_MAX = 2.0f;
        private const float MOVE_TIME_MIN = 1.0f;
        private const float MOVE_TIME_MAX = 3.0f;
        private Vector2 moveDirection;
        private float actionTimer;
        private float actionDuration;
        private bool isResting;
        private readonly IPositionedSprite flyingSprite;
        private readonly IPositionedSprite restingSprite;
        private readonly Rectangle innerBounds;
        public override bool BoomerangKills => true;

        public Keese(Texture2D texture, Vector2 position, Rectangle innerBounds) : base(texture, position, HEALTH, DAMAGE)
        {
            int[] flyingXPositions = [183, 200];
            int[] restingXPositions = [200];
            int sheetY = 14;
            int spriteWidth = 16;
            int spriteHeight = 10;
            float frameTime = 0.2f;

            flyingSprite = new AnimatedSprite(texture, position, flyingXPositions, sheetY,
                                        spriteWidth, spriteHeight, frameTime);

            restingSprite = new AnimatedSprite(texture, position, restingXPositions, sheetY,
                                        spriteWidth, spriteHeight, frameTime);

            this.innerBounds = innerBounds;
            isResting = true;
            actionTimer = 0f;
            actionDuration = GetRandomFloat(REST_TIME_MIN, REST_TIME_MAX);
            ChooseRandomDirection();
            sprite = restingSprite;
            Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
        }

        protected override void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive) return;

            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            actionTimer += dt;

            if (actionTimer >= actionDuration)
            {
                actionTimer = 0f;
                isResting = !isResting;

                if (isResting)
                {
                    actionDuration = GetRandomFloat(REST_TIME_MIN, REST_TIME_MAX);
                    sprite = restingSprite;
                }
                else
                {
                    actionDuration = GetRandomFloat(MOVE_TIME_MIN, MOVE_TIME_MAX);
                    sprite = flyingSprite;
                    ChooseRandomDirection();
                }

                sprite.Position = Position;
            }

            if (!isResting)
            {
                Vector2 newPos = Position + moveDirection * MOVE_SPEED * dt;
                if (newPos.X < innerBounds.Left || newPos.X + Rect.Width > innerBounds.Right)
                    moveDirection.X = -moveDirection.X;
                if (newPos.Y < innerBounds.Top || newPos.Y + Rect.Height > innerBounds.Bottom)
                    moveDirection.Y = -moveDirection.Y;
                Position += moveDirection * MOVE_SPEED * dt;
            }

            sprite.Update(gameTime);
        }

        private void ChooseRandomDirection()
        {
            float angle = (float)(random.NextDouble() * Math.PI * 2);
            moveDirection = new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle));
            moveDirection.Normalize();
        }

    }
}
