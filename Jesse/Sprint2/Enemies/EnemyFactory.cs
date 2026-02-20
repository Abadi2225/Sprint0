using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;

namespace Sprint.Enemies
{
    public enum EnemyType
    {
        Keese,
        Stalfos,
        Gel,
        Zol,
        Goriya,
        WallMaster,
        Trap,
        Rope,
        Aquamentus,
        Dodongo
    }
    
    public class EnemyFactory(Texture2D enemySpriteSheet, Texture2D bossSpriteSheet)
    {
        private readonly Texture2D enemySpriteSheet = enemySpriteSheet;
        private readonly Texture2D bossSpriteSheet = bossSpriteSheet;

        // Can change vector2 position to something else (e.g. x/y pos) in the future
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
                    
                case EnemyType.Zol:
                    return new Zol(enemySpriteSheet, position);
                    
                case EnemyType.WallMaster:
                    return new WallMaster(enemySpriteSheet, position);
                    
                case EnemyType.Trap:
                    return new Trap(enemySpriteSheet, position);
                    
                case EnemyType.Rope:
                    return new Rope(enemySpriteSheet, position);
                    
                 case EnemyType.Aquamentus:
                     return new Aquamentus(bossSpriteSheet, position);
                    
                // case EnemyType.Dodongo:
                //     return new Dodongo(enemySpriteSheet, position);

                default:
                    return new Gel(enemySpriteSheet, position);
            }
        }   
    }
}
