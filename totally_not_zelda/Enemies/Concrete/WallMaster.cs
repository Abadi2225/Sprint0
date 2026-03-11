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

        private enum WallMasterState { Hidden, Creeping, Grabbing }

        private WallMasterState currentState;
        private Vector2 homePosition;
        private bool movingVertically;

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
            currentState = WallMasterState.Hidden;
            Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
        }

        public override void Update(GameTime gameTime)
        {
            if (!isAlive) return;

            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            switch (currentState)
            {
                case WallMasterState.Hidden:
                    UpdateHidden();
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

        private void UpdateHidden()
        {
            float dx = GameServices.Link.Position.X - Position.X;
            float dy = GameServices.Link.Position.Y - Position.Y;
            if (new Vector2(dx, dy).Length() <= DETECTION_RANGE)
            {
                movingVertically = Math.Abs(dy) >= Math.Abs(dx);
                currentState = WallMasterState.Creeping;
            }
        }

        private void UpdateCreeping(float deltaTime)
        {
            float dx = GameServices.Link.Position.X - Position.X;
            float dy = GameServices.Link.Position.Y - Position.Y;

            if (new Vector2(dx, dy).Length() <= GRAB_RANGE)
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
            if (!isAlive || currentState == WallMasterState.Hidden)
                return;

            sprite?.Draw(spriteBatch, location);
        }

        public override void Reset()
        {
            base.Reset();
            Position = homePosition;
            currentState = WallMasterState.Hidden;
        }
    }
}
