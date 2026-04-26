using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Moldorm : Enemy
    {
        private const int SEGMENT_COUNT = 5;
        private const int SEGMENT_HEALTH = 2;
        private const float MOVE_SPEED = 100f;
        private const float TURN_INTERVAL_MIN = 0.5f;
        private const float TURN_INTERVAL_MAX = 2.0f;
        private const float SEGMENT_RADIUS = 4f; // source pixels
        private const float FLASH_DURATION = 0.15f;
        private const float PUSH_AMOUNT = 6f;

        private const int SPRITE_X = 119;
        private const int SPRITE_Y = 14;
        private const int SPRITE_W = 8;
        private const int SPRITE_H = 10;

        private class Segment
        {
            public Vector2 Position;
            public int Health;
            public bool IsAlive;
            public float FlashTimer;
            public bool IsFlashing => FlashTimer > 0;

            public Segment(Vector2 pos)
            {
                Position = pos;
                Health = SEGMENT_HEALTH;
                IsAlive = true;
                FlashTimer = 0f;
            }
        }

        private readonly List<Segment> segments = new();
        private Vector2 headVelocity;
        private float turnTimer;
        private readonly Rectangle innerBounds;
        private readonly float scaledRadius;
        private readonly float diameter;

        // head = segments[0], tail = segments[^1]
        private int headIndex => 0;
        private int tailIndex => segments.Count - 1;
        private float headDamageCooldown = 0f;
        private float tailDamageCooldown = 0f;
        private const float SEGMENT_DAMAGE_COOLDOWN = 1f;

        public Moldorm(Texture2D texture, Vector2 position, Vector2 initialDirection, Rectangle innerBounds)
            : base(texture, position, SEGMENT_HEALTH, 1)
        {
            this.innerBounds = innerBounds;
            scaledRadius = SEGMENT_RADIUS * GameServices.ScaleFactor;
            diameter = scaledRadius * 2f;

            // Initialize segments in a line behind the head
            Vector2 dir = initialDirection;
            dir.Normalize();
            headVelocity = dir * MOVE_SPEED;

            for (int i = 0; i < SEGMENT_COUNT; i++)
                segments.Add(new Segment(position - dir * diameter * i));

            turnTimer = GetRandomTurnTime();

            Rect = new Rectangle((int)position.X, (int)position.Y,
                (int)diameter, (int)diameter);
        }

        protected override void UpdateEnemy(GameTime gameTime)
        {
            if (!isAlive) return;

            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (headDamageCooldown > 0) headDamageCooldown -= dt;
            if (tailDamageCooldown > 0) tailDamageCooldown -= dt;

            // Update flash timers
            foreach (var seg in segments)
                if (seg.FlashTimer > 0)
                    seg.FlashTimer -= dt;

            // Random turn
            turnTimer -= dt;
            if (turnTimer <= 0)
            {
                TurnHead();
                turnTimer = GetRandomTurnTime();
            }

            // Move head
            MoveHead(dt);

            // Follow: each segment moves toward the one ahead of it
            for (int i = 1; i < segments.Count; i++)
            {
                Vector2 target = segments[i - 1].Position;
                Vector2 diff = segments[i].Position - target;
                if (diff.Length() > diameter)
                {
                    diff.Normalize();
                    segments[i].Position = target + diff * diameter;
                }
            }

            // Update head rect for collision
            Position = segments[headIndex].Position;
            Rect = new Rectangle((int)Position.X, (int)Position.Y,
                (int)diameter, (int)diameter);
        }

        private void MoveHead(float dt)
        {
            Vector2 newPos = segments[headIndex].Position + headVelocity * dt;

            // Wall reflection
            bool reflectX = false, reflectY = false;

            if (newPos.X - scaledRadius < innerBounds.Left)
            {
                newPos.X = innerBounds.Left + scaledRadius;
                reflectX = true;
            }
            else if (newPos.X + scaledRadius > innerBounds.Right)
            {
                newPos.X = innerBounds.Right - scaledRadius;
                reflectX = true;
            }

            if (newPos.Y - scaledRadius < innerBounds.Top)
            {
                newPos.Y = innerBounds.Top + scaledRadius;
                reflectY = true;
            }
            else if (newPos.Y + scaledRadius > innerBounds.Bottom)
            {
                newPos.Y = innerBounds.Bottom - scaledRadius;
                reflectY = true;
            }

            if (reflectX) headVelocity.X = -headVelocity.X;
            if (reflectY) headVelocity.Y = -headVelocity.Y;

            segments[headIndex].Position = newPos;
        }

        private void TurnHead()
        {
            // Randomly turn 0, +45, or -45 degrees
            int turn = random.Next(3) - 1;
            if (turn == 0) return;

            float angle = turn * MathF.PI / 4f;
            float cos = MathF.Cos(angle);
            float sin = MathF.Sin(angle);
            float vx = headVelocity.X * cos - headVelocity.Y * sin;
            float vy = headVelocity.X * sin + headVelocity.Y * cos;
            headVelocity = new Vector2(vx, vy);
            headVelocity.Normalize();
            headVelocity *= MOVE_SPEED;
        }

        public void DamageHead(int amount)
        {
            if (!isAlive || headDamageCooldown > 0) return;
            headDamageCooldown = SEGMENT_DAMAGE_COOLDOWN;
            var head = segments[headIndex];
            head.FlashTimer = FLASH_DURATION;
            head.Health -= amount;
            if (head.Health <= 0)
            {
                head.IsAlive = false;
                segments.RemoveAt(headIndex);
                CheckDeath();
            }
        }

        public void DamageTail(int amount)
        {
            if (!isAlive || tailDamageCooldown > 0) return;
            tailDamageCooldown = SEGMENT_DAMAGE_COOLDOWN;
            var tail = segments[tailIndex];
            tail.FlashTimer = FLASH_DURATION;
            tail.Health -= amount;
            if (tail.Health <= 0)
            {
                tail.IsAlive = false;
                segments.RemoveAt(tailIndex);
                CheckDeath();
            }
        }

        public void PushMiddleSegments(Vector2 pushDir)
        {
            // Push all segments except head and tail
            for (int i = 1; i < segments.Count - 1; i++)
                segments[i].Position += pushDir * PUSH_AMOUNT;
        }

        private void CheckDeath()
        {
            if (segments.Count == 0 || (segments.Count == 1 && segments[0].Health <= 0))
            {
                isAlive = false;
                return;
            }
        }

        public override void TakeDamage(int amount)
        {
            // Default damage goes to head — specific methods handle head/tail/middle
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!isAlive) return;

            Rectangle sourceRect = new Rectangle(SPRITE_X, SPRITE_Y, SPRITE_W, SPRITE_H);

            for (int i = segments.Count - 1; i >= 0; i--)
            {
                var seg = segments[i];
                if (!seg.IsAlive) continue;

                Color color = seg.IsFlashing ? Color.White * 0.3f : Color.White;

                spriteBatch.Draw(
                    texture,
                    seg.Position,
                    sourceRect,
                    color,
                    0f,
                    Vector2.Zero,
                    GameServices.ScaleFactor,
                    SpriteEffects.None,
                    0f);
            }
        }

        public Rectangle GetHeadRect() =>
            new Rectangle(
                (int)(segments[headIndex].Position.X),
                (int)(segments[headIndex].Position.Y),
                (int)diameter, (int)diameter);

        public Rectangle GetTailRect() =>
            new Rectangle(
                (int)(segments[tailIndex].Position.X),
                (int)(segments[tailIndex].Position.Y),
                (int)diameter, (int)diameter);

        public List<Rectangle> GetMiddleRects()
        {
            var rects = new List<Rectangle>();
            for (int i = 1; i < segments.Count - 1; i++)
                rects.Add(new Rectangle(
                    (int)(segments[i].Position.X),
                    (int)(segments[i].Position.Y),
                    (int)diameter, (int)diameter));
            return rects;
        }

        private float GetRandomTurnTime() =>
            TURN_INTERVAL_MIN + (float)random.NextDouble() * (TURN_INTERVAL_MAX - TURN_INTERVAL_MIN);
    }
}