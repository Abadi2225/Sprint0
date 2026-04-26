using System.Collections.Generic;

public class RoomState
{
    public HashSet<int> DefeatedEnemies = new();
    public HashSet<int> CollectedItems = new();

    public bool Visited = false;
}