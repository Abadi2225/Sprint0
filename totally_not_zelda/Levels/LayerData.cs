namespace Sprint.Layers;
using System.Collections.Generic;

public class LayerData
{
    public string name { get; set; }
    public string type { get; set; }

    public int width { get; set; }
    public int height { get; set; }

    public int[] data { get; set; }
    public Dictionary<string, int[]> doorOffsets { get; set; } // e.g. {"north": [49, 0]}
}