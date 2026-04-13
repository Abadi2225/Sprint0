using Sprint.Layers;
using System.Collections.Generic;

namespace Sprint.Levels;

public class RoomItemData
{
    public string item { get; set; }
    public int tile { get; set; }
}

public class LevelData
{
    public int width { get; set; }
    public int height { get; set; }

    public List<LayerData> layers { get; set; }

    // Door connections: key = "north"/"south"/"east"/"west", value = room name
    public Dictionary<string, string> doors { get; set; }

    // Optional door types: key = direction, value = "open" (default), "key", "enemy", or "bomb"
    public Dictionary<string, string> doorTypes { get; set; }

    // Optional door position overrides: key = direction, value = [x, y] in source pixels
    public Dictionary<string, int[]> doorOffsets { get; set; }

    // Item that spawns in the room center when all enemies are cleared
    public string roomClearDrop { get; set; }

    // Enemies that carry an item dropped on death: key = tile index in Enemies layer, value = item name
    public Dictionary<string, string> carriedItems { get; set; }

    // A single item placed at a specific tile position in the room
    public RoomItemData roomItem { get; set; }

    // Custom background: null = use default dungeon walls
    public string background { get; set; }
    
    // Position of this room on the map grid
    public int gridPos { get; set; }
}
