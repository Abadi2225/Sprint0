using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;

using Sprint.Interfaces;

namespace Sprint.Block;

public class MapManager
{

    enum BlockType
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

    private Vector2 pos = new Vector2(100, 50);
    private ContentManager contentManager;

    internal AbstractBlock[] Map;

    // todo delete this
    private BlockType currentBlock = BlockType.Blank;

    public MapManager(ContentManager contentManager, Vector2 pos)
    {
        this.contentManager = contentManager;
        this.pos = pos;

        this.Map = new AbstractBlock[] {
            createBlock(currentBlock, pos)
        };
    }

    public void DrawMap(SpriteBatch sb)
    {
        for (int i = 0; i < Map.GetLength(0); i++)
        {
            Map[i].Draw(sb, Vector2.Zero);
        }
    }

    private AbstractBlock createBlock(BlockType type, Vector2 pos, int width = 32)
    {
        Rectangle textureMask = new Rectangle(
                        ((int)type % 4) * (16 + 1),
                        ((int)type / 4) * (16 + 1),
                        16,
                        16
                        );
        return new Block(contentManager, pos, textureMask, width);
    }

    // todo remove these
    public void CycleNext()
    {
        if ((int)currentBlock < 10)
        {
            currentBlock = (BlockType)((int)currentBlock + 1);
            this.Map[0] = createBlock(currentBlock, pos);
        }
    }

    public void CyclePrevious()
    {
        if ((int)currentBlock > 0)
        {
            currentBlock = (BlockType)((int)currentBlock - 1);
            this.Map[0] = createBlock(currentBlock, pos);
        }
    }
}
