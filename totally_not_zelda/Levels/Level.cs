using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Block;
using Sprint.Enemies.Base;
using Sprint.Enemies.Concrete;
using Sprint.Enemies;
using Sprint.Item;
using System.Collections.Generic;

public class Level
{
    public BlockManager Blocks { get; private set; }
    public EnemyManager Enemies { get; private set; }
    public List<AbstractItem> WorldItems { get; } = new();

    public Level(BlockManager blockManager, EnemyManager enemyManager)
    {
        Blocks = blockManager;
        Enemies = enemyManager;
    }

    public void Update(GameTime gameTime)
    {
        Blocks.Update(gameTime);
        Enemies.Update(gameTime);
        foreach (AbstractItem item in WorldItems)
            item.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Blocks.Draw(spriteBatch);
        Enemies.DrawBehindBlocks(spriteBatch);
        Enemies.Draw(spriteBatch);
        foreach (AbstractItem item in WorldItems)
            item.Draw(spriteBatch, item.Position);
    }
    public void DrawOnTop(SpriteBatch spriteBatch)
    {
        Enemies.DrawOnTop(spriteBatch);
    }
}