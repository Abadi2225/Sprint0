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
        
        public void CycleNext()
        {
            if (enemies.Count == 0)
                return;
                
            currentEnemyIndex = (currentEnemyIndex + 1) % enemies.Count;
            currentEnemy = enemies[currentEnemyIndex];
        }
    
        public void CyclePrevious()
        {
            if (enemies.Count == 0)
                return;
                
            currentEnemyIndex = (currentEnemyIndex - 1 + enemies.Count) % enemies.Count;
            currentEnemy = enemies[currentEnemyIndex];
        }
        
        public void Update(GameTime gameTime)
        {
            foreach (var enemy in enemies)
                enemy.Update(gameTime);
                //Add collision testing call or loop for all enemies and then collision testing
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var enemy in enemies)
            {
                if (enemy is WallMaster wallMaster && wallMaster.IsEntering) continue;
                if (enemy is Keese) continue; // drawn separately on top
                enemy.Draw(spriteBatch, enemy.Position);
            }
        }

        public void DrawOnTop(SpriteBatch spriteBatch)
        {
            foreach (var enemy in enemies)
            {
                if (enemy is Keese keese)
                    keese.Draw(spriteBatch, keese.Position);
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

        public IEnemy GetCurrentEnemy() => currentEnemy;
        
        public int GetEnemyCount() => enemies.Count;
        
        public int GetCurrentIndex() => currentEnemyIndex;
    }
}
