using System.Collections.Generic;

namespace Sprint.Doors;

public static class DoorStateRegistry
{
    private static readonly HashSet<(string room, string direction)> _unlocked = new();

    public static void Unlock(string room, string direction)
        => _unlocked.Add((room, direction));

    public static bool IsUnlocked(string room, string direction)
        => _unlocked.Contains((room, direction));

    public static void Reset()
        => _unlocked.Clear();
}