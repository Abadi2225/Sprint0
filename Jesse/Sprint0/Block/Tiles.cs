using System.Collections.Generic;

namespace Sprint.Block;

public class Tiles
{
    public List<List<Tile>> Grid { get; set; }

    public void AddRow(List<Tile> row)
    {
        Grid.Add(row);
    }
}
