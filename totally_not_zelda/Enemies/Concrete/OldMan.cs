using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
    public class OldMan : Enemy
    {
        private const int HEALTH = 1;
        private const int DAMAGE = 0;

        public OldMan(Texture2D texture, Vector2 position) : base(texture, position, HEALTH, DAMAGE, isInvincible: true)
        {
            int[] frameXPositions = [1, 18];
            int sheetY       = 11;
            int spriteWidth  = 15;
            int spriteHeight = 15;
            float frameTime  = 0.5f;

            sprite = new AnimatedSprite(texture, position, frameXPositions, sheetY, spriteWidth, spriteHeight, frameTime);
        }

        public override void TakeDamage(int damageAmount) { }
        public override void Die() { }
    }
}
