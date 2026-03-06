using System.Collections.Generic;
using Sprint.Block;
using Sprint.Levels;
using Microsoft.Xna.Framework;

public class LevelBuilder
{
    private const int TILE_SIZE = 16;

    public static Level Build(LevelData data)
    {   
        BlockManager blockManager = new BlockManager();

        for (int i = 0; i < data.height * data.width; i++)
        {
            int id = data.layers[0].data[i];
            if (id == 0) continue;

            int x = i % data.width;
            int y = i / data.width;

            
            Block block = BlockFactory.Create(id-1, new Vector2((x * TILE_SIZE + 35) * GameServices.ScaleFactor, (y * TILE_SIZE + (224-176+35)) * GameServices.ScaleFactor));
            blockManager.Add(block);
        }

        return new Level(blockManager);
    }
}
