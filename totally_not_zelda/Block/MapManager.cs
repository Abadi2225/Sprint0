using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint.Block;

public class MapManager
{
    private const int SHEET_COLUMNS = 4;
    private const int TILE_SIZE = 16;
    private const int TILE_SPACING = 1;
    private readonly Texture2D tileSheet;
    private readonly Vector2 pos;
    private readonly Block[] map;
    internal IReadOnlyList<Block> Map => map;

    // todo delete this
    private BlockType currentBlock = BlockType.Blank;
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

    public MapManager(Texture2D tileSheet, Vector2 pos)
    {
        this.tileSheet = tileSheet;
        this.pos = pos;

        this.map = [CreateBlock(currentBlock, pos)];
    }

    public void DrawMap(SpriteBatch sb)
    {
        foreach (Block block in map)
        {
            block.Draw(sb, block.Position);
        }
    }

    // todo remove these
    public void CycleNext()
    {
        if ((int)currentBlock < 9)
        {
            currentBlock = (BlockType)((int)currentBlock + 1);
            map[0] = CreateBlock(currentBlock, pos);
        }
    }

    public void CyclePrevious()
    {
        if ((int)currentBlock > 0)
        {
            currentBlock = (BlockType)((int)currentBlock - 1);
            map[0] = CreateBlock(currentBlock, pos);
        }
    }

    private Block CreateBlock(BlockType type, Vector2 pos, int width = Block.DEFAULT_TILE_WIDTH)
    {
        Rectangle textureMask = new(
                        (int)type % SHEET_COLUMNS * (TILE_SIZE + TILE_SPACING),
                        (int)type / SHEET_COLUMNS * (TILE_SIZE + TILE_SPACING),
                        TILE_SIZE,
                        TILE_SIZE
                        );
        return new Block(tileSheet, pos, textureMask, width);
    }
}
