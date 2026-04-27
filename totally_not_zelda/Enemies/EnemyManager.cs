using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;
using System.Collections.Generic;

namespace Sprint.Enemies
{
    public class EnemyManager
    {
        private readonly List<IEnemy> enemies;
        public List<IEnemy> EnemyList => enemies;

        public EnemyManager()
        {
            enemies = [];
        }

        public void AddEnemy(IEnemy enemy)
        {
            enemies.Add(enemy);
        }

        public void Update(GameTime gameTime)
        {
            foreach (var enemy in enemies)
                enemy.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var enemy in enemies)
            {
                if (enemy is EnemyEffectWrapper w && w.InnerEnemy is Keese) continue;
                if (enemy is Keese) continue;
                enemy.Draw(spriteBatch, enemy.Position);
            }
        }

        public void DrawOnTop(SpriteBatch spriteBatch)
        {
            foreach (var enemy in enemies)
            {
                var actual = enemy is EnemyEffectWrapper w ? w.InnerEnemy : enemy;
                if (actual is Keese)
                    enemy.Draw(spriteBatch, enemy.Position);
            }
        }

        public void DrawBehindBlocks(SpriteBatch spriteBatch)
        {
            foreach (var enemy in enemies)
            {
                var actual = enemy is EnemyEffectWrapper w ? w.InnerEnemy : enemy;
                if (actual is WallMaster wallMaster && wallMaster.IsEntering)
                    enemy.Draw(spriteBatch, enemy.Position);
            }
        }

        public void Reset()
        {
            foreach (var enemy in enemies)
                enemy.Reset();
        }

        public bool AllDead => enemies.Count > 0 && enemies.TrueForAll(enemy => !enemy.IsAlive);
    }
}
