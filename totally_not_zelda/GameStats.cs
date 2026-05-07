using System;

public static class GameStats
{
    public static int EnemiesDefeated { get; private set; }
    private static DateTime startTime;

    public static void StartNewRun()
    {
        EnemiesDefeated = 0;
        startTime = DateTime.Now;
    }

    public static void RecordEnemyDefeated() => EnemiesDefeated++;

    public static TimeSpan GetElapsedTime() => DateTime.Now - startTime;
}
