using Sprint.Interfaces;

namespace Sprint.Block;

public abstract class AbstractBlock
{
    public Tile Tile { get; set; }
    public ISprite Sprite { get; set; }

    public AbstractBlock(Tile tile, ISprite sprite)
    {
        Tile = tile;
        Sprite = sprite;
        tile.Block = this;
        tile.IsOccupied = true;
    }
}
