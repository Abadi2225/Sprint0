using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Item;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Aquamentus : Enemy
    {
        private const int HEALTH = 1;
        private const int DAMAGE = 1;
        private Vector2 velocity;
        private const float MOVE_SPEED = 20f;
        private float directionChangeTimer;
        private const float DIRECTION_SWAP_MIN = 0.5f;
        private const float DIRECTION_SWAP_MAX = 2.0f;
        private float moveDirectionTimer;
        private bool moveLeft;
        private float fireballTimer = 0f;
        private const float FIREBALL_INTERVAL = 3f;
        private readonly Action<AbstractItem> spawnProjectile;
        protected override bool CanBeKnockedBack => false;
        private Fireball activeFireball;
        private List<Fireball> activeFireballs = new();

        private static readonly Vector2[] FireballDirections =
        [
            new Vector2(-1f,  0f),
            new Vector2(-1f, -0.5f),
            new Vector2(-1f,  0.5f),
        ];

        public Aquamentus(Texture2D texture, Vector2 position, List<Sprint.Block.Block> solidBlocks, Rectangle innerBounds,
            Action<AbstractItem> spawnProjectile = null) : base(texture, position, HEALTH, DAMAGE)
        {
            int[] sheetXPositions = [1, 26, 51, 76];
            int sheetY = 11;
            int spriteWidth = 24;
            int spriteHeight = 32;
            float frameTime = 0.2f;
            moveDirectionTimer = 0f;
            directionChangeTimer = GetRandomFloat(DIRECTION_SWAP_MIN, DIRECTION_SWAP_MAX);
            this.spawnProjectile = spawnProjectile;

            sprite = new AnimatedSprite(texture, position, sheetXPositions, sheetY, spriteWidth, spriteHeight, frameTime);
            Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
        }

        protected override void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive) return;

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            moveDirectionTimer += deltaTime;

            if (moveDirectionTimer >= directionChangeTimer)
            {
                moveDirectionTimer = 0f;
                velocity = new Vector2(moveLeft ? -MOVE_SPEED : MOVE_SPEED, 0);
                directionChangeTimer = GetRandomFloat(DIRECTION_SWAP_MIN, DIRECTION_SWAP_MAX);
                moveLeft = !moveLeft;
            }
            Position += velocity * deltaTime;

            fireballTimer += deltaTime;
            if (fireballTimer >= FIREBALL_INTERVAL)
            {
                fireballTimer = 0f;
                SpawnFireballs();
            }

            sprite.Update(gameTime);
        }

        private void SpawnFireballs()
        {
            if (spawnProjectile == null) return;
            foreach (var dir in FireballDirections)
            {
                activeFireball = ItemFactory.CreateFireball(texture, Position, dir);
                spawnProjectile(activeFireball);
                activeFireballs.Add(activeFireball);
            }
        }

        private float GetRandomFloat(float min, float max)
        {
            return min + (float)random.NextDouble() * (max - min);
        }

        public override void Die()
        {
            base.Die();
            foreach (var fireball in activeFireballs)
            {
                fireball?.Cancel();
            }
            activeFireballs.Clear();
        }
    }
}
