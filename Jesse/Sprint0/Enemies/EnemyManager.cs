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
            
            // If this is the first enemy, make it current
            if (enemies.Count == 1)
            {
                currentEnemyIndex = 0;
                currentEnemy = enemies[0];
            }
        }
        
        // Cycle to the next enemy in the list (Useful for displaying different enemies for sprint2)
        public void CycleNext()
        {
            if (enemies.Count == 0)
                return;
                
            currentEnemyIndex = (currentEnemyIndex + 1) % enemies.Count;
            currentEnemy = enemies[currentEnemyIndex];
        }
    
        
        public void Update(GameTime gameTime)
        {
            // Only update the current enemy being displayed
            currentEnemy?.Update(gameTime);
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
            // Only draw the current enemy being displayed
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
        

        // Optional: Methods to get current enemy info for UI display
        // public IEnemy GetCurrentEnemy()
        // {
        //     return currentEnemy;
        // }
        
        // public int GetEnemyCount()
        // {
        //     return enemies.Count;
        // }
        
        // public int GetCurrentIndex()
        // {
        //     return currentEnemyIndex;
        // }
    }
}
