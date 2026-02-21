using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using System.Collections.Generic;

namespace Sprint.Enemies
{
    public class EnemyManager
    {
        private readonly List<IEnemy> enemies;
        private int currentEnemyIndex;
        private IEnemy currentEnemy;
        
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
            currentEnemy?.Update(gameTime);
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            currentEnemy?.Draw(spriteBatch, currentEnemy.Position);
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
