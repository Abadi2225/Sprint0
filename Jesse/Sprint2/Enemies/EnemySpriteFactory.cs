using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;

namespace Sprint.Enemies
{
    public enum ProjectileType
    {
 
    }
    
    public class EnemyProjectileFactory(Texture2D enemySpriteSheet)
    {
        private readonly Texture2D enemySpriteSheet = enemySpriteSheet;

        public void LoadAllTextures(ContentManager content)
        {
            
        }

        // Can change vector2 position to something else (e.g. x/y pos) in the future
        // Switch this to projectiles for the future
        public IEnemy CreateEnemy(EnemyType type, Vector2 position)
        {
            switch (type)
            {
                 case EnemyType.Keese:
                     return new Keese(enemySpriteSheet, position);
                    
                case EnemyType.Stalfos:
                    return new Stalfos(enemySpriteSheet, position);
                    
                case EnemyType.Gel:
                    return new Gel(enemySpriteSheet, position);
                    
                 case EnemyType.Goriya:
                     return new Goriya(enemySpriteSheet, position);
                    
                // case EnemyType.Zol:
                //     return new Zol(enemySpriteSheet, position);
                    
                // case EnemyType.WallMaster:
                //     return new WallMaster(enemySpriteSheet, position);
                    
                // case EnemyType.Trap:
                //     return new Trap(enemySpriteSheet, position);
                    
                // case EnemyType.Rope:
                //     return new Rope(enemySpriteSheet, position);
                    
                // case EnemyType.Aquamentus:
                //     return new Aquamentus(enemySpriteSheet, position);
                    
                // case EnemyType.Dodongo:
                //     return new Dodongo(enemySpriteSheet, position);

                default:
                    return new Gel(enemySpriteSheet, position);
            }
        }   
    }
}
