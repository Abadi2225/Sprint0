using Sprint.Layers;
using System.Collections.Generic;

namespace Sprint.Levels;

public class LevelData
{
    public int width { get; set; }
    public int height { get; set; }

    public List<LayerData> layers { get; set; }

    // Door connections: key = "north"/"south"/"east"/"west", value = room name
    public Dictionary<string, string> doors { get; set; }

    // Optional door types: key = direction, value = "open" (default), "key", "enemy", or "bomb"
    public Dictionary<string, string> doorTypes { get; set; }
}