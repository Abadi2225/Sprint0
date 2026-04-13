using System.Collections.Generic;
using Sprint.Levels;

namespace Sprint.UI.Hud;

internal class MapGraph
{
    public class Node
    {
        public string roomName;
        public Node north, south, west, east;
    }

    public static Node buildGraph(string startingRoomName)
    {
        Dictionary<string, Node> visited = new Dictionary<string, Node>();
        return processRoom(startingRoomName, visited);
    }

    private static Node processRoom(string roomName, Dictionary<string, Node> visited)
    {
        if (visited.ContainsKey(roomName))
        {
            return visited[roomName];
        }

        LevelData room;
        try
        {
            room = LevelLoader.Load(roomName);
        }
        catch
        {
            return null;
        }

        MapGraph.Node result = new Node();
        visited[roomName] = result;

        result.roomName = roomName;
        if (room.doors.ContainsKey("north"))
        {
            result.north = processRoom(room.doors["north"], visited);
        }
        if (room.doors.ContainsKey("south"))
        {
            result.south = processRoom(room.doors["south"], visited);
        }
        if (room.doors.ContainsKey("west"))
        {
            result.west = processRoom(room.doors["west"], visited);
        }
        if (room.doors.ContainsKey("east"))
        {
            result.east = processRoom(room.doors["east"], visited);
        }

        return result;
    }
}
