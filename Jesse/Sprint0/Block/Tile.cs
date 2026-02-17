using Microsoft.Xna.Framework;

using Sprint.Interfaces;

namespace Sprint.Block;

public class Tile
{
    public Vector2 Position { get; set; }
    public ISprite Sprite { get; set; }
    public bool IsOccupied { get; set; }
    public AbstractBlock Block { get; set; }

    public Tile(Vector2 position, ISprite sprite)
    {
        Position = position;
        sprite = Sprite;
        Block = null;
        IsOccupied = false;
    }

    public Tile(Vector2 position, ISprite sprite, AbstractBlock block)
    {
        Position = position;
        sprite = Sprite;
        Block = block;
        IsOccupied = true;
    }
}
