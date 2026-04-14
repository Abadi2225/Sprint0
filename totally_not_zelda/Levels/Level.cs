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
    public List<AbstractItem> WorldItems { get; }

    private readonly List<CarriedItem> carriedItems;
    private readonly AbstractItem roomClearDropItem;
    private bool roomClearDropped;

    public Level(BlockManager blockManager, EnemyManager enemyManager, List<AbstractItem> worldItems,
        List<CarriedItem> carriedItems = null, AbstractItem roomClearDropItem = null)
    {
        Blocks = blockManager;
        Enemies = enemyManager;
        WorldItems = worldItems;
        this.carriedItems = carriedItems ?? new();
        this.roomClearDropItem = roomClearDropItem;
    }

    public void Update(GameTime gameTime)
    {
        Blocks.Update(gameTime);
        Enemies.Update(gameTime);

        foreach (CarriedItem carried in carriedItems)
            carried.Update();

        if (!roomClearDropped && roomClearDropItem != null && Enemies.AllDead)
        {
            WorldItems.Add(roomClearDropItem);
            roomClearDropped = true;
        }

        foreach (AbstractItem item in WorldItems)
            item.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Blocks.Draw(spriteBatch);
        Enemies.DrawBehindBlocks(spriteBatch);
        Enemies.Draw(spriteBatch);
    }

    public void DrawOnTop(SpriteBatch spriteBatch)
    {
        foreach (AbstractItem item in WorldItems)
            item.Draw(spriteBatch, item.Position);
        Enemies.DrawOnTop(spriteBatch);
    }
}