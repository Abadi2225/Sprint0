using System.Collections.Generic;
using Sprint.Block;
using Sprint.Item;
using Sprint.Levels;
using Microsoft.Xna.Framework;
using Sprint.Enemies;
using Sprint.Interfaces;
using System.Linq;
using System;
using Sprint.Character;
public class LevelBuilder
{
    private const int TILE_SIZE = 16;

    public static Level Build(LevelData data, EnemyFactory enemyFactory, Rectangle innerBounds)
    {
        BlockManager blockManager = new BlockManager();
        float scale = GameServices.ScaleFactor;
        float hudHeight = 48 * scale;
        float blockBorderX = 32 * scale;
        float blockBorderY = 32 * scale + hudHeight;

        bool useInnerBounds = data.background != null;
        float blockOriginX = useInnerBounds ? innerBounds.Left : blockBorderX;
        float blockOriginY = useInnerBounds ? innerBounds.Top : blockBorderY;

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
                        x * TILE_SIZE * scale + blockOriginX,
                        y * TILE_SIZE * scale + blockOriginY),
                        GameServices.CurrentDungeon);

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
                    x * TILE_SIZE * scale + blockOriginX,
                    y * TILE_SIZE * scale + blockOriginY);

                Block block = BlockFactory.CreatePushable(id - 1, pos, GameServices.CurrentDungeon);

				if (data.pushDirection == "left")
				{
					block.PushDirection = Directions.Left;
				}
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
                    x * TILE_SIZE * scale + innerBounds.Left,
                    y * TILE_SIZE * scale + innerBounds.Top);

                System.Console.WriteLine($"Enemy id:{id} tile:({x},{y}) scaled pos:{pos}");

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

        AbstractItem roomClearDropItem = null;
        if (data.roomClearDrop != null)
        {
            Vector2 center = new Vector2(innerBounds.Center.X, innerBounds.Center.Y);
            roomClearDropItem = CreatePickupItem(data.roomClearDrop, center);
        }

        if (data.roomItems != null)
        {
            foreach (var roomItemData in data.roomItems)
            {
                int x = roomItemData.tile % data.width;
                int y = roomItemData.tile / data.width;
                Vector2 pos = new Vector2(
                    x * TILE_SIZE * scale + innerBounds.Left,
                    y * TILE_SIZE * scale + innerBounds.Top);
                worldItems.Add(CreatePickupItem(roomItemData.item, pos));
            }
        }

        if (data.precisePlacements != null)
        {

            foreach (var precisePlacementData in data.precisePlacements)
            {
                Vector2 pos = new Vector2(precisePlacementData.x, precisePlacementData.y);

                switch (precisePlacementData.type)
                {
                    case "old_man":
                        enemyManager.AddEnemy(
                            enemyFactory.CreateEnemy(EnemyType.OldMan, pos, solidBlocks, innerBounds)
                        );
                        break;

                    case "flame_left":
                        enemyManager.AddEnemy(
                            enemyFactory.CreateEnemy(EnemyType.FlameLeft, pos, solidBlocks, innerBounds)
                        );
                        break;

                    case "flame_right":
                        enemyManager.AddEnemy(
                            enemyFactory.CreateEnemy(EnemyType.FlameRight, pos, solidBlocks, innerBounds)
                        );
                        break;

                    case "GoldTriforce":
                        worldItems.Add(CreatePickupItem("GoldTriforce", pos));
                        break;
                }
            }
        }
        return new Level(blockManager, enemyManager, worldItems, carriedItems, roomClearDropItem);
    }

	private static AbstractItem CreatePickupItem(string name, Vector2 pos) => name switch
    {
        "Boomerang" => ItemFactory.CreateBoomerang(pos, Vector2.Zero, maxDistance: 0),
        "Bomb" => ItemFactory.CreateTimeBomb(100000, pos, Vector2.Zero, 0, GameServices.ScaleFactor),
        _ => ItemFactory.CreateStillItem(Enum.Parse<ItemFactory.StillType>(name), pos, scale: GameServices.ScaleFactor),
    };
}