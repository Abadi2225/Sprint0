using System.Collections.Generic;
using Sprint.Block;
using Sprint.Levels;
using Microsoft.Xna.Framework;
using Sprint.Enemies;
using System.Linq;
using System.Runtime.CompilerServices;

public class LevelBuilder
{
    private const int TILE_SIZE = 16;
    public static Level Build(LevelData data, EnemyFactory enemyFactory, Rectangle innerBounds)
    {
        BlockManager blockManager = new BlockManager();
        float hudHeight = 48 * GameServices.ScaleFactor;
        float wallBorderX = 34 * GameServices.ScaleFactor;
        float wallBorderY = 34 * GameServices.ScaleFactor;

        var backgroundLayer = data.layers.FirstOrDefault(l => l.name == "BackgroundTiles");
        if (backgroundLayer != null)
        {
            for (int i = 0; i < backgroundLayer.data.Length; i++)
            {
                int id = backgroundLayer.data[i];
                if (id == 0) continue;

                int x = i % data.width;
                int y = i / data.width;

                Block block = BlockFactory.Create(
                    id - 1,
                    new Vector2(
                        x * TILE_SIZE * GameServices.ScaleFactor + wallBorderX,
                        y * TILE_SIZE * GameServices.ScaleFactor + wallBorderY + hudHeight));

                blockManager.Add(block);
            }
        }

		var pushableLayer = data.layers.FirstOrDefault(layer => layer.name == "PushableBlocks");
		if (pushableLayer != null)
		{
			for (int i = 0; i < pushableLayer.data.Length; i++)
			{
				int id = pushableLayer.data[i];
				if (id == 0) continue;

				int x = i % data.width;
				int y = i / data.width;

				Vector2 pos = new Vector2(
					x * TILE_SIZE * GameServices.ScaleFactor + wallBorderX,
					y * TILE_SIZE * GameServices.ScaleFactor + wallBorderY + hudHeight);

				Block block = BlockFactory.CreatePushable(id - 1, pos);
				blockManager.Add(block);
			}
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

                enemyManager.AddEnemy(enemyFactory.CreateEnemy((EnemyType)(id - 1), pos, solidBlocks, innerBounds));
            }
        }

        return new Level(blockManager, enemyManager);
    }
}
