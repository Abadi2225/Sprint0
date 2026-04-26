using System.Collections.Generic;

public static class DungeonState
{
    private static Dictionary<string, RoomState> rooms = new();

    public static RoomState GetRoomState(string roomID)
    {
        if (!rooms.ContainsKey(roomID))
            rooms[roomID] = new RoomState();

        return rooms[roomID];
    }

    public static void ResetProgess()
    {
        rooms = new();
    }
}