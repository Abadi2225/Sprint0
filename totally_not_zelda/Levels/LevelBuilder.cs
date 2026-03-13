using System.Collections.Generic;
using Sprint.Block;
using Sprint.Levels;
using Microsoft.Xna.Framework;
using Sprint.Enemies;
using System.Linq;

public class LevelBuilder
{
    private const int TILE_SIZE = 16;
    public static Level Build(LevelData data, EnemyFactory enemyFactory)
    {
        BlockManager blockManager = new BlockManager();
        float hudHeight = 48 * GameServices.ScaleFactor;
        float wallBorderX = 34 * GameServices.ScaleFactor;
        float wallBorderY = 34 * GameServices.ScaleFactor;

        for (int i = 0; i < data.height * data.width; i++)
        {
            int id = data.layers[0].data[i];
            if (id == 0) continue;

            int x = i % data.width;
            int y = i / data.width;

            Block block = BlockFactory.Create(id-1, new Vector2(
            x * TILE_SIZE * GameServices.ScaleFactor + wallBorderX,
            y * TILE_SIZE * GameServices.ScaleFactor + wallBorderY + hudHeight));
            blockManager.Add(block);
        }

        EnemyManager enemyManager = new EnemyManager();
        var solidBlocks = blockManager.blocksList.Where(b => !b.walkAble).ToList();

        var enemyLayer = data.layers.FirstOrDefault(l => l.name == "Enemies");
        if (enemyLayer != null)
        {
            for (int i = 0; i < enemyLayer.data.Length; i++)
            {
                int id = enemyLayer.data[i];
                if (id == 0) continue;

                int x = i % data.width;
                int y = i / data.width;
                Vector2 pos = new Vector2(
                    x * TILE_SIZE * GameServices.ScaleFactor + wallBorderX,
                    y * TILE_SIZE * GameServices.ScaleFactor + wallBorderY + hudHeight);

                enemyManager.AddEnemy(enemyFactory.CreateEnemy((EnemyType)(id - 1), pos, solidBlocks));
            }
        }

        return new Level(blockManager, enemyManager);
    }
}
