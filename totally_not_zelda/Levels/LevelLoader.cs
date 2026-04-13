using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using Sprint.Levels;

public class LevelLoader
{
    // todo remove this
    private List<string> levels = new List<string>{
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
        "NPC"
    };
    // location of room on an 8x8 grid, used for tracking link's location on the maps
    public static Dictionary<string, int> LocOnGrid = new Dictionary<string, int>{
        {"template", 58}
        // ...
    };

    private int currentLevel = 0;
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
        currentLevel = 0;
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
        return LocOnGrid[GetCurrentLevelName()];
    }

    public static LevelData Load(string levelName)
    {
        string path = $"Content/rooms/{levelName}.json";
        string json = File.ReadAllText(path);

        LevelData data =
            JsonSerializer.Deserialize<LevelData>(json);

        return data;
    }
}
