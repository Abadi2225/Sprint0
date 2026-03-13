using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Block;
using Sprint.Enemies.Base;
using Sprint.Enemies.Concrete;
using Sprint.Enemies;
using Sprint.Interfaces;
public class Level
{
    public BlockManager Blocks { get; private set; }
    public EnemyManager Enemies { get; private set; }

    public Level(BlockManager blockManager, EnemyManager enemyManager)
    {
        Blocks = blockManager;
        Enemies = enemyManager;
    }

    public void Update(GameTime gameTime)
    {
        Blocks.Update(gameTime);
        Enemies.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Blocks.Draw(spriteBatch);
        Enemies.DrawBehindBlocks(spriteBatch);
        Enemies.Draw(spriteBatch);
    }
    public void DrawOnTop(SpriteBatch spriteBatch)
    {
        Enemies.DrawOnTop(spriteBatch);
    }
}