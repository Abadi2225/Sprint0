using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using System.Collections.Generic;

namespace Sprint.Doors;

public class DoorManager
{
    private static readonly string[] AllDirections = new string[] { "north", "south", "east", "west" };

    private readonly Texture2D doorTexture;
    private readonly float scale;
    private readonly float hudHeight;

    private string currentRoomName;
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

    public void Reset(Dictionary<string, string> newTargets, Dictionary<string, string> newTypes,
        Dictionary<string, int[]> doorOffsets = null, string roomName = null)
    {
        currentRoomName = roomName;

        if (newTargets != null) targets = newTargets;
        else targets = new Dictionary<string, string>();

        if (newTypes != null) configuredTypes = newTypes;
        else configuredTypes = new Dictionary<string, string>();

        unlocked.Clear();
        doorBlocks.Clear();

        foreach (string dir in AllDirections)
        {
            Vector2? customOrigin = null;
            if (doorOffsets != null && doorOffsets.TryGetValue(dir, out int[] offset))
                customOrigin = new Vector2(offset[0], offset[1]);
            doorBlocks[dir] = new DoorBlock(doorTexture, dir, scale, hudHeight, customOrigin);

            if (currentRoomName != null && DoorStateRegistry.IsUnlocked(currentRoomName, dir))
                unlocked[dir] = true;
        }
    }

    private static string OppositeDirection(string direction) => direction switch
    {
        "north" => "south",
        "south" => "north",
        "east"  => "west",
        "west"  => "east",
        _       => direction,
    };

    private void RegisterUnlock(string direction)
    {
        if (currentRoomName == null) return;
        DoorStateRegistry.Unlock(currentRoomName, direction);
        string targetRoom = GetTarget(direction);
        if (targetRoom != null)
            DoorStateRegistry.Unlock(targetRoom, OppositeDirection(direction));
    }

    public bool HasDoor(string direction) => targets.ContainsKey(direction);

    public string GetTarget(string direction) =>
        targets.TryGetValue(direction, out string t) ? t : null;

    private string GetDoorType(string direction) =>
        configuredTypes.TryGetValue(direction, out string t) ? t : "wall";

    public bool IsLocked(string direction) =>
        GetDoorType(direction) switch
        {
            "open" => false,
            "wall" => true,
            _      => !unlocked.GetValueOrDefault(direction),
        };

    private static readonly Dictionary<string, Vector2> DoorCenters = new()
    {
        ["north"] = new Vector2(128,  16),
        ["south"] = new Vector2(128, 160),
        ["west"]  = new Vector2( 16,  88),
        ["east"]  = new Vector2(240,  88),
    };

    public void UnlockEnemyDoors()
    {
        foreach (string dir in AllDirections)
        {
            if (GetDoorType(dir) != "enemy") continue;
            unlocked[dir] = true;
            RegisterUnlock(dir);
        }
    }

    public void TryUnlockBomb(Vector2 explosionCenter, float radius)
    {
        foreach (string dir in AllDirections)
        {
            if (GetDoorType(dir) != "bomb") continue;
            if (unlocked.GetValueOrDefault(dir)) continue;
            Vector2 doorCenter = new Vector2(DoorCenters[dir].X * scale, DoorCenters[dir].Y * scale + hudHeight);
            if (Vector2.Distance(explosionCenter, doorCenter) <= radius)
            {
                unlocked[dir] = true;
                RegisterUnlock(dir);
            }
        }
    }

    public bool TryExit(string direction, ILink link)
    {
        if (!HasDoor(direction)) return false;

        if (GetDoorType(direction) == "key")
        {
            if (unlocked.GetValueOrDefault(direction)) return true;
            if (link.UseKey())
            {
                unlocked[direction] = true;
                RegisterUnlock(direction);
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
            bool locked = IsLocked(dir);
            string displayType = type switch
            {
                "bomb" => locked ? "wall" : "bomb",
                _      => locked ? type   : "open",
            };
            doorBlocks[dir].Draw(spriteBatch, displayType);
        }
    }
}