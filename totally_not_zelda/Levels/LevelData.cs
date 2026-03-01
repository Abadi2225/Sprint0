using Sprint.Layers;
using System.Collections.Generic;

namespace Sprint.Levels;

public class LevelData
{
    public int width { get; set; }
    public int height { get; set; }

    public List<LayerData> layers { get; set; }
}