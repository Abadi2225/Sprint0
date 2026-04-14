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
        private int currentEnemyIndex;
        private IEnemy currentEnemy;
        public List<IEnemy> enemyList => enemies;
        
        public EnemyManager()
        {
            enemies = [];
            currentEnemyIndex = -1;
            currentEnemy = null;
        }
        
        public void AddEnemy(IEnemy enemy)
        {
            enemies.Add(enemy);
            
            if (enemies.Count == 1)
            {
                currentEnemyIndex = 0;
                currentEnemy = enemies[0];
            }
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
                if (enemy is WallMaster wallMaster && wallMaster.IsEntering)
                    wallMaster.Draw(spriteBatch, wallMaster.Position);
            }
        }
        
        public void Reset()
        {
            foreach (var enemy in enemies)
            {
                enemy.Reset();
            }
            
            if (enemies.Count > 0)
            {
                currentEnemyIndex = 0;
                currentEnemy = enemies[0];
            }
        }

        public bool AllDead => enemies.Count > 0 && enemies.TrueForAll(enemy => !enemy.IsAlive);

        public IEnemy GetCurrentEnemy() => currentEnemy;
        
        public int GetEnemyCount() => enemies.Count;
        
        public int GetCurrentIndex() => currentEnemyIndex;
    }
}
