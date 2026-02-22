using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;

namespace Sprint.Enemies
{
    public enum ProjectileType
    {
        AquamentusFireball
    }

    public class EnemyProjectileFactory(Texture2D enemySpriteSheet)
    {
        private readonly Texture2D enemySpriteSheet = enemySpriteSheet;

        public void LoadAllTextures(ContentManager content)
        {

        }

        public AquamentusFireball CreateFireball(Vector2 position, Vector2 direction)
        {
            return new AquamentusFireball(enemySpriteSheet, position, direction);
        }
    }
}
