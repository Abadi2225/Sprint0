using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;
using Sprint.Sprites;

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

    public class EnemyFactory(Texture2D enemySpriteSheet, Texture2D bossSpriteSheet, Texture2D linkSheet, Texture2D dustSheet)
    {
        private readonly Texture2D enemySpriteSheet = enemySpriteSheet;
        private readonly Texture2D bossSpriteSheet = bossSpriteSheet;
        private readonly Texture2D linkSheet = linkSheet;
        private readonly Texture2D dustSheet = dustSheet;

        public void LoadAllTextures(ContentManager content) { }

        // Can change vector2 position to something else (e.g. x/y pos) in the future
        public IEnemy CreateEnemy(EnemyType type, Vector2 position)
        {
            IEnemy enemy = type switch
            {
                EnemyType.Keese      => new Keese(enemySpriteSheet, position),
                EnemyType.Stalfos    => new Stalfos(enemySpriteSheet, position),
                EnemyType.Gel        => new Gel(enemySpriteSheet, position),
                EnemyType.Goriya     => new Goriya(enemySpriteSheet, position),
                EnemyType.Zol        => new Zol(enemySpriteSheet, position),
                EnemyType.WallMaster => new WallMaster(enemySpriteSheet, position),
                EnemyType.Trap       => new Trap(enemySpriteSheet, position),
                EnemyType.Rope       => new Rope(enemySpriteSheet, position),
                EnemyType.Aquamentus => new Aquamentus(bossSpriteSheet, position),
                EnemyType.Dodongo    => new Dodongo(bossSpriteSheet, position),
                _                    => new Goriya(enemySpriteSheet, position),
            };

            bool skipSpawnCloud = type is EnemyType.Aquamentus or EnemyType.Dodongo or EnemyType.WallMaster or EnemyType.Trap or EnemyType.Gel;
            return WrapWithEffects(enemy, position, skipSpawnCloud);
        }

        private EnemyEffectWrapper WrapWithEffects(IEnemy enemy, Vector2 position, bool skipSpawnCloud = false)
        {
            // Cloud: 3 frames from Link.png (skipped for bosses and WallMaster)
            var spawnSprite = skipSpawnCloud ? null : new AnimatedSprite(linkSheet, position, [138, 155, 172], 185, 15, 15, 0.5f);
            // Dust: 4 frames from dustSheet
            var deathSprite = new AnimatedSprite(dustSheet, position, [0, 16, 32, 48], 0, 14, 15, 0.3f);
            return new EnemyEffectWrapper(enemy, spawnSprite, deathSprite);
        }
    }
}
