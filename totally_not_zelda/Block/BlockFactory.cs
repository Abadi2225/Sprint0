using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Sprint.Interfaces;
using Sprint.Levels;

namespace Sprint.Block;

public class BlockFactory
{
    private const int SHEET_COLUMNS = 4;
    private const int TILE_SIZE = 16;
    private const int TILE_SPACING = 1;
    private readonly Texture2D tileSheet;
    private readonly Vector2 pos;
    private Block[] map;
    public IReadOnlyList<IBlock> Map => map;
    private enum BlockType
    {
        Blank,
        Square,
        StatueRight,
        StatueLeft,
        Black,
        Sand,
        Water,
        Stairs,
        Bricks,
        Ladder
    }

    public BlockFactory(Texture2D tileSheet, Vector2 pos)
    {
        this.tileSheet = tileSheet;
        this.pos = pos;
    }

    public void DrawMap(SpriteBatch sb)
    {
        foreach (Block block in map)
        {
            block.Draw(sb, block.Position);
        }
    }

    private Block CreateBlock(BlockType type, Vector2 pos)
    {
        Rectangle textureMask = new(
                        (int)type % SHEET_COLUMNS * (TILE_SIZE + TILE_SPACING),
                        (int)type / SHEET_COLUMNS * (TILE_SIZE + TILE_SPACING),
                        TILE_SIZE,
                        TILE_SIZE
                        );
        return new Block(tileSheet, pos, textureMask);
    }

    public void Build(LevelData data)
    {
        map = new Block[data.height * data.width];
        
        for (int i = 0; i < data.height * data.width; i++)
        {
            int id = data.layers[0].data[i];
            if (id == 0) continue;

            int x = i % data.width;
            int y = i / data.width;

            Block block = CreateBlock((BlockType)(id-1), new Vector2(x * TILE_SIZE * GameServices.ScaleFactor, y * TILE_SIZE * GameServices.ScaleFactor));
            map[i] = block;
        }
    }
}
