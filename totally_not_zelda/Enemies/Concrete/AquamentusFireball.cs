using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class AquamentusFireball : ISprite
    {
        private ISprite sprite;
        private Vector2 position;
        private Vector2 velocity;
        private float lifetime;
        private const float MAX_LIFETIME = 3f;
        private const float SPEED = 120f;

        public bool IsActive => lifetime < MAX_LIFETIME;

        public Vector2 Position
        {
            get => position;
            set
            {
                position = value;
                sprite.Position = value;
            }
        }

        public AquamentusFireball(Texture2D texture, Vector2 startPosition, Vector2 direction)
        {
            position = startPosition;
            lifetime = 0f;

            int[] fireballXFrames = [101, 110, 119, 128]; 
            int fireballY = 14;                
            int fireballWidth = 7;             
            int fireballHeight = 9;            
            float frameTime = 0.3f;            
            sprite = new AnimatedSprite(texture, startPosition, fireballXFrames, fireballY, fireballWidth, fireballHeight, frameTime);

            if (direction != Vector2.Zero)
                direction.Normalize();
            velocity = direction * SPEED;
        }

        public int Update(GameTime gameTime)
        {
            if (!IsActive) return 0;

            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            lifetime += dt;
            Position += velocity * dt;
            return sprite.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            if (!IsActive) return;
            sprite.Draw(spriteBatch, location);
        }
    }
}
