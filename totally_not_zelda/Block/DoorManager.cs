using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using System.Collections.Generic;

namespace Sprint.Block;

public class DoorManager
{
    private static readonly string[] AllDirections = new string[] { "north", "south", "east", "west" };

    private readonly Texture2D doorTexture;
    private readonly float scale;
    private readonly float hudHeight;

    private Dictionary<string, string> targets = new();
    private Dictionary<string, string> configuredTypes = new();
    private readonly Dictionary<string, bool> unlocked = new();

    private readonly Dictionary<string, DoorBlock> doorBlocks = new();

    public DoorManager(Texture2D doorTexture, float scale, float hudHeight)
    {
        this.doorTexture = doorTexture;
        this.scale       = scale;
        this.hudHeight   = hudHeight;
    }

    public void Reset(Dictionary<string, string> newTargets, Dictionary<string, string> newTypes)
    {
        if (newTargets != null) targets = newTargets;
        else targets = new Dictionary<string, string>();

        if (newTypes != null) configuredTypes = newTypes;
        else configuredTypes = new Dictionary<string, string>();
        unlocked.Clear();
        doorBlocks.Clear();

        foreach (string dir in AllDirections)
            doorBlocks[dir] = new DoorBlock(doorTexture, dir, scale, hudHeight);
    }

    public bool HasDoor(string direction) => targets.ContainsKey(direction);

    public string GetTarget(string direction) =>
        targets.TryGetValue(direction, out string t) ? t : null;

    private string GetDoorType(string direction) =>
        configuredTypes.TryGetValue(direction, out string t) ? t : "wall";

    public bool IsLocked(string direction) =>
        GetDoorType(direction) switch
        {
            "open"  => false,
            "key"   => !unlocked.GetValueOrDefault(direction),
            "enemy" => true,   // TODO: integrate with enemy manager
            "bomb"  => true,   // TODO: integrate with bomb system
            _       => true,   // "wall" is impassable
        };

    public bool TryExit(string direction, ILink link)
    {
        if (!HasDoor(direction)) return false;

        if (GetDoorType(direction) == "key")
        {
            if (unlocked.GetValueOrDefault(direction)) return true;
            if (link.UseKey())
            {
                unlocked[direction] = true;
                return true;
            }
            return false;
        }

        return !IsLocked(direction);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        foreach (string dir in AllDirections)
        {
            string type = GetDoorType(dir);
            string displayType = (type == "key" && !IsLocked(dir)) ? "open" : type;
            doorBlocks[dir].Draw(spriteBatch, displayType);
        }
    }
}
