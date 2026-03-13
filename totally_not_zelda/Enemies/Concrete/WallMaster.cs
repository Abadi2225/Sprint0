using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class WallMaster : Enemy
    {
        private const int WALLMASTER_HEALTH = 2;
        private const int WALLMASTER_DAMAGE = 1;
        private const float CREEP_SPEED = 60f;
        private const float DETECTION_RANGE = 160f;
        private const float GRAB_RANGE = 12f;
        private const float ENTER_SPEED = 80f;

        private enum WallMasterState { Entering, Creeping, Grabbing }

        private WallMasterState currentState;
        private Vector2 homePosition;
        private Vector2 entryStart;
        private Vector2 entryTarget;
        private bool movingVertically;
        public bool IsEntering => currentState == WallMasterState.Entering;

        public WallMaster(Texture2D texture, Vector2 position) : base(texture, position, WALLMASTER_HEALTH, WALLMASTER_DAMAGE)
        {
            int[] frameXPositions = [393, 410];
            int frameY = 11;
            int spriteWidth = 16;
            int spriteHeight = 16;
            float frameTime = 0.2f;

            sprite = new AnimatedSprite(texture, position, frameXPositions, frameY,
                                        spriteWidth, spriteHeight, frameTime);

            homePosition = position;

            // Figure out which wall this was placed on and enter from there
            Vector2 entryDirection = DetermineEntryDirection(position);
            entryStart = position - entryDirection * 16f * GameServices.ScaleFactor; // one tile inside wall
            entryTarget = position; // move toward spawn position

            Position = entryStart;
            currentState = WallMasterState.Entering;

            Rect = new Rectangle((int)position.X, (int)position.Y, 
                                spriteWidth * (int)GameServices.ScaleFactor, 
                                spriteHeight * (int)GameServices.ScaleFactor);
        }

        private Vector2 DetermineEntryDirection(Vector2 spawnPosition)
        {
            float distLeft   = spawnPosition.X;
            float distRight  = GameServices.GameWidth - spawnPosition.X;
            float distTop    = spawnPosition.Y;
            float distBottom = GameServices.GameHeight - spawnPosition.Y;

            float min = MathHelper.Min(MathHelper.Min(distLeft, distRight),
                                    MathHelper.Min(distTop, distBottom));

            if (min == distLeft)   return Vector2.UnitX;   // left wall, enter rightward
            if (min == distRight)  return -Vector2.UnitX;  // right wall, enter leftward
            if (min == distTop)    return Vector2.UnitY;   // top wall, enter downward
            return -Vector2.UnitY;                          // bottom wall, enter upward
}

        public override void Update(GameTime gameTime)
        {
            if (!isAlive) return;

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            switch (currentState)
            {
                case WallMasterState.Entering:
                    UpdateEntering(deltaTime);
                    break;

                case WallMasterState.Creeping:
                    UpdateCreeping(deltaTime);
                    break;

                case WallMasterState.Grabbing:
                    UpdateGrabbing();
                    break;
            }

            if (currentState != WallMasterState.Grabbing)
                sprite.Update(gameTime);
        }

        private void UpdateEntering(float deltaTime)
        {
            Vector2 toTarget = entryTarget - Position;
            if (toTarget.Length() < ENTER_SPEED * deltaTime)
            {
                Position = entryTarget;
                currentState = WallMasterState.Creeping;
            }
            else
            {
                toTarget.Normalize();
                Position += toTarget * ENTER_SPEED * deltaTime;
            }
        }

        private void UpdateCreeping(float deltaTime)
        {
            float dx = GameServices.Link.Position.X - Position.X;
            float dy = GameServices.Link.Position.Y - Position.Y;
            float dist = new Vector2(dx, dy).Length();

            // Only chase if within detection range
            if (dist > DETECTION_RANGE) return;

            if (dist <= GRAB_RANGE)
            {
                ((AnimatedSprite)sprite).SetFrame(1);
                currentState = WallMasterState.Grabbing;
                return;
            }

            if (movingVertically && Math.Abs(dy) < 1f)
                movingVertically = false;
            else if (!movingVertically && Math.Abs(dx) < 1f)
                movingVertically = true;

            Vector2 direction = movingVertically
                ? new Vector2(0, Math.Sign(dy))
                : new Vector2(Math.Sign(dx), 0);

            Position += direction * CREEP_SPEED * deltaTime;
        }

        private void UpdateGrabbing()
        {
            Position = GameServices.Link.Position;
            // TODO: move Link to the door
        }

        public override void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!isAlive) return;
            sprite?.Draw(spriteBatch, location);
        }

        public override void Reset()
        {
            base.Reset();
            Position = entryStart;
            currentState = WallMasterState.Entering;
        }
    }
}
