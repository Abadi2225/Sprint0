using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Sprint.Block;

public static class BlockFactory
{
    private const int SHEET_COLUMNS = 4;
    private const int TILE_SIZE = 16;
    private const int TILE_SPACING = 1;
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
        Ladder,
        InvisibleWall
    }

    // level # mapped to color mask for blocks
    internal static Dictionary<int, uint> tileColors = new() {
        {1, 0xFFFFFFFF},
        {2, 0xFFA0FFFF},
    };

    public static Block Create(int tileId, Vector2 pos, int level)
    {
        uint color = tileColors[level];
        return tileId switch
        {
            0 => CreateBlock(BlockType.Blank, pos, color),
            1 => CreateBlock(BlockType.Square, pos, color),
            2 => CreateBlock(BlockType.StatueRight, pos, color),
            3 => CreateBlock(BlockType.StatueLeft, pos, color),
            4 => CreateBlock(BlockType.Black, pos, color),
            5 => CreateBlock(BlockType.Sand, pos, color),
            6 => CreateBlock(BlockType.Water, pos, color),
            7 => CreateBlock(BlockType.Stairs, pos, color),
            8 => CreateBlock(BlockType.Bricks, pos, color),
            9 => CreateBlock(BlockType.Ladder, pos, color),
            10 => CreateInvisibleSolid(pos),
            11 => CreateInvisibleWalkable(pos),
            _ => null,
        };
    }

    private static Block CreateBlock(BlockType type, Vector2 pos, uint colorMask)
    {
        int tileX = (int)type % SHEET_COLUMNS;
        int tileY = (int)type / SHEET_COLUMNS;

        Rectangle textureMask = new Rectangle(
            tileX * (TILE_SIZE + TILE_SPACING), // X position on the tile sheet
            tileY * (TILE_SIZE + TILE_SPACING), // Y position on the tile sheet
            TILE_SIZE,                          // Width of the tile
            TILE_SIZE                           // Height of the tile
        );

        bool walkable = type switch
        {
            BlockType.Blank or
            BlockType.Sand or
            BlockType.Black or
            BlockType.Stairs => true,
            _ => false  // Square, Statues, Black, Water, Bricks, Ladder all block movement
        };
        return new Block(GameServices.TileSheet, pos, textureMask, colorMask, walkable, false, type == BlockType.Stairs);
    }

    private static Block CreateInvisibleSolid(Vector2 pos)
    {
        return new Block(null, pos, Rectangle.Empty, 0xFFFFFFFF, false, false);
    }

    private static Block CreateInvisibleWalkable(Vector2 pos)
    {
        return new Block(null, pos, Rectangle.Empty, 0xFFFFFFFF, true, false);
    }

    public static Block CreatePushable(int tileId, Vector2 pos, int level)
    {
        BlockType type = tileId switch
        {
            0 => BlockType.Blank,
            1 => BlockType.Square,
            2 => BlockType.StatueRight,
            3 => BlockType.StatueLeft,
            4 => BlockType.Black,
            5 => BlockType.Sand,
            6 => BlockType.Water,
            7 => BlockType.Stairs,
            8 => BlockType.Bricks,
            9 => BlockType.Ladder,
            _ => BlockType.Blank,
        };

        Rectangle textureMask = new Rectangle(
            (int)type % SHEET_COLUMNS * (TILE_SIZE + TILE_SPACING),
            (int)type / SHEET_COLUMNS * (TILE_SIZE + TILE_SPACING),
            TILE_SIZE,
            TILE_SIZE
        );

        return new Block(GameServices.TileSheet, pos, textureMask, tileColors[level], false, true);
    }
}
