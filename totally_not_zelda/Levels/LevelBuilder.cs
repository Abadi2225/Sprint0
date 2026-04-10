using System.Collections.Generic;
using Sprint.Block;
using Sprint.Item;
using Sprint.Levels;
using Microsoft.Xna.Framework;
using Sprint.Enemies;
using Sprint.Interfaces;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System;

public class LevelBuilder
{
    private const int TILE_SIZE = 16;
    public static Level Build(LevelData data, EnemyFactory enemyFactory, Rectangle innerBounds)
    {
        BlockManager blockManager = new BlockManager();
        float hudHeight = 48;
        float wallBorderX = 32;
        float wallBorderY = 32; 

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
                        (x * TILE_SIZE + wallBorderX) * GameServices.ScaleFactor,
                        (y * TILE_SIZE+ wallBorderY + hudHeight) * GameServices.ScaleFactor));
                
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
					(x * TILE_SIZE + wallBorderX) * GameServices.ScaleFactor,
					(y * TILE_SIZE + wallBorderY + hudHeight) * GameServices.ScaleFactor);

				Block block = BlockFactory.CreatePushable(id - 1, pos);
				blockManager.Add(block);
			}
		}

        List<AbstractItem> worldItems = new();
        List<CarriedItem> carriedItems = new();
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
                    (x * TILE_SIZE + wallBorderX) * GameServices.ScaleFactor,
                    (y * TILE_SIZE + wallBorderY + hudHeight) * GameServices.ScaleFactor);

                // Check if this tile has a carried item assigned in the room JSON
                bool hasCarriedItem = data.carriedItems != null &&
                    data.carriedItems.TryGetValue(i.ToString(), out string carriedItemName);

                IEnemy enemy = enemyFactory.CreateEnemy(
                    (EnemyType)(id - 1), pos, solidBlocks, innerBounds,
                    onItemDropped: item => worldItems.Add(item),
                    skipRandomDrop: hasCarriedItem);

                enemyManager.AddEnemy(enemy);

                if (hasCarriedItem)
                {
                    data.carriedItems.TryGetValue(i.ToString(), out carriedItemName);
                    var carriedDrop = CreatePickupItem(carriedItemName, Vector2.Zero);
                    carriedItems.Add(new CarriedItem(carriedDrop, enemy, item => worldItems.Add(item)));
                }
            }
        }

        // Room clear drop: spawns at the room center when all enemies are dead
        AbstractItem roomClearDropItem = null;
        if (data.roomClearDrop != null)
        {
            Vector2 center = new Vector2(innerBounds.Center.X, innerBounds.Center.Y);
            roomClearDropItem = CreatePickupItem(data.roomClearDrop, center);
        }

        return new Level(blockManager, enemyManager, worldItems, carriedItems, roomClearDropItem);
    }

    private static AbstractItem CreatePickupItem(string name, Vector2 pos) => name switch
    {
        "Boomerang" => ItemFactory.CreateBoomerang(pos, Vector2.Zero, maxDistance: 0),
        _ => ItemFactory.CreateStillItem(Enum.Parse<ItemFactory.StillType>(name), pos, scale: GameServices.ScaleFactor),
    };
}
