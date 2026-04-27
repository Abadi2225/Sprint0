using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class Flame : Enemy
    {
        private const int HEALTH = 1;
        private const int DAMAGE = 0;

        public Flame(Texture2D texture, Vector2 position) : base(texture, position, HEALTH, DAMAGE, isInvincible: true)
        {
            int spriteWidth = 16;
            int spriteHeight = 16;

            sprite = new AnimatedSprite(texture, position, [52, 69], 11, spriteWidth, spriteHeight, 0.15f);
            Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
        }
    }
}
