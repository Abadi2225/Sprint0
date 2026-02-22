using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
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
        private Random random = new Random();
        private float moveDirectionTimer;
        private bool moveLeft;

        private EnemyProjectileFactory projectileFactory;
        private List<AquamentusFireball> activeFireballs = new();
        private float fireballTimer = 0f;
        private const float FIREBALL_INTERVAL = 3f;

        // Faces left, walking back and forth
        // Fires three fireballs to the left in a triangle pattern

        public Aquamentus(Texture2D texture, Vector2 position) : base(texture, position, HEALTH, DAMAGE)
        {
            int[]sheetXPositions = [1, 26, 51, 76];
            int sheetY = 11;
            int spriteWidth = 23;
            int spriteHeight = 31;
            float frameTime = 0.2f;
            moveDirectionTimer = 0f;
            directionChangeTimer = GetRandomFloat(DIRECTION_SWAP_MIN,DIRECTION_SWAP_MAX);

            sprite = new AnimatedSprite(texture, position, sheetXPositions, sheetY, spriteWidth, spriteHeight, frameTime);
            projectileFactory = new EnemyProjectileFactory(texture);
        }

        public override int Update(GameTime gameTime)
        {
            if (!isAlive)
                return base.Update(gameTime);

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            moveDirectionTimer += deltaTime;

            if (moveDirectionTimer >= directionChangeTimer)
            {
                moveDirectionTimer = 0f;
                if (moveLeft)
                {
                    velocity = new Vector2(-MOVE_SPEED, 0);

                } else
                {
                    velocity = new Vector2(MOVE_SPEED, 0);
                }
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

            activeFireballs.RemoveAll(f => !f.IsActive);
            foreach (var fireball in activeFireballs)
                fireball.Update(gameTime);

            return sprite.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            base.Draw(spriteBatch, location);
            foreach (var fireball in activeFireballs)
                fireball.Draw(spriteBatch, fireball.Position);
        }

        private void SpawnFireballs()
        {
            Vector2[] directions = new[]
            {
                new Vector2(-1f,  0f),    // straight left
                new Vector2(-1f, -0.5f),  // up-left
                new Vector2(-1f,  0.5f),  // down-left
            };

            foreach (var dir in directions)
                activeFireballs.Add(projectileFactory.CreateFireball(Position, dir));
        }

        private float GetRandomFloat(float min, float max)
        {
            return min + (float)random.NextDouble() * (max - min);
        }
    }
}