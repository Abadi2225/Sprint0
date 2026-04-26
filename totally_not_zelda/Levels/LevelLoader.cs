using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using Sprint.Levels;

public class LevelLoader
{
    private Dictionary<int, List<string>> levelsByDungeon = new()
    {
        [1] = new List<string>{
            "template",
            "12statues",
            "12blocks",
            "6blockslower",
            "6blocksupper",
            "4blockssmalllower",
            "4blocksbig",
            "1block",
            "dice5",
            "4blockssmallupper",
            "waffle",
            "wave",
            "dumbbell",
            "blockedstairs",
            "boss",
            "pacman",
            "NPC",
            "Underground",
        },
        [2] = new List<string>{
            "12blocks",
            "12statues",
            "4blocksbiglower",
            "4blocksbigupper",
            "4blockssmall",
            "4statues",
            "dice5",
            "desert",
            "boss",
            "6blocks",
            "emptyleft",
            "emptylower",
            "emptyupper",
            "NPC",
            "pacman",
            "trap",
            "wafflelower",
            "waffleupper"
        },
    };

    private List<string> levels => levelsByDungeon[GameServices.CurrentDungeon];

    private int currentLevel = 0;

    public LevelData ResetForDungeon()
    {
        currentLevel = 0;
        return Load(levels[currentLevel]);
    }
    public LevelData CycleNext()
    {
        if (currentLevel < levels.Count - 1)
        {
            currentLevel++;
        }
        return Load(levels[currentLevel]);
    }
    public LevelData CyclePrevious()
    {
        if (currentLevel > 0)
        {
            currentLevel--;
        }
        return Load(levels[currentLevel]);
    }
    public void ResetToFirst()
    {
        currentLevel = 1;
    }
    public LevelData GetCurrentLevel()
    {
        return Load(levels[currentLevel]);
    }

    public string GetCurrentLevelName()
    {
        return levels[currentLevel];
    }

    public int GetCurrentLevelGridLoc()
    {
        return GetCurrentLevel().gridPos;
    }

    public static LevelData Load(string levelName, int dungeon)
    {
        try
        {
            string path = $"Content/rooms/dungeon{dungeon}/{levelName}.json";
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<LevelData>(json);
        }
        catch
        {
            Console.Error.WriteLine($"Room {levelName}.json does not exist. Dungeon: {dungeon}");
            return null;
        }
    }

    public static LevelData Load(string levelName)
    {
        return Load(levelName, GameServices.CurrentDungeon);
    }

	public void SetCurrentLevel(string roomName)
	{
		int index = levels.IndexOf(roomName);

		if (index >= 0)
		{
			currentLevel = index;
		}
	}
}
