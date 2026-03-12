using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Sprint.Interfaces;
using Sprint.Levels;

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
        Ladder
    }

    public static Block Create(int tileId, Vector2 pos)
    {
        return tileId switch
        {
            0 => CreateBlock(BlockType.Blank, pos),
            1 => CreateBlock(BlockType.Square, pos),
            2 => CreateBlock(BlockType.StatueRight, pos),
            3 => CreateBlock(BlockType.StatueLeft, pos),
            4 => CreateBlock(BlockType.Black, pos),
            5 => CreateBlock(BlockType.Sand, pos),
            6 => CreateBlock(BlockType.Water, pos),
            7 => CreateBlock(BlockType.Stairs, pos),
            8 => CreateBlock(BlockType.Bricks, pos),
            9 => CreateBlock(BlockType.Ladder, pos),
            _ => null,
        };
    }

    private static Block CreateBlock(BlockType type, Vector2 pos)
    {
        Rectangle textureMask = new Rectangle(
            (int)type % SHEET_COLUMNS * (TILE_SIZE + TILE_SPACING),
            (int)type / SHEET_COLUMNS * (TILE_SIZE + TILE_SPACING),
            TILE_SIZE,
            TILE_SIZE
            );
            
            bool solid = type switch
            {
                BlockType.Blank or 
                BlockType.Sand or 
                BlockType.Stairs => false,
                _ => true  // Square, Statues, Black, Water, Bricks, Ladder all block movement
            };
        return new Block(GameServices.TileSheet, pos, textureMask, solid);
    }
}
