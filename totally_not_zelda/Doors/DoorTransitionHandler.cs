using Microsoft.Xna.Framework;
using Sprint.Enemies;
using Sprint.Interfaces;
using Sprint.Levels;
using Sprint.UI;
using System;

namespace Sprint.Doors;

public class DoorTransitionHandler
{
    private readonly DoorManager doorManager;
    private readonly ILink link;
    private readonly OuterDungeonWalls dungeonWalls;
    private readonly LevelLoader levelLoader;
    private readonly EnemyFactory enemyFactory;

    private readonly Action<LevelData, Level> onRoomChanged;
    private readonly Action onRebuildCollision;
    private readonly Action<string> updateLinkMapPos;
    private readonly Action<LevelData, string> updateInventoryMap;

    public DoorTransitionHandler(DoorManager doorManager, ILink link, OuterDungeonWalls dungeonWalls,
        LevelLoader levelLoader, EnemyFactory enemyFactory,
        Action<LevelData, Level> onRoomChanged, Action onRebuildCollision, Action<string> updateLinkMapPos, Action<LevelData, string> updateInventoryMap)
    {
        this.doorManager = doorManager;
        this.link = link;
        this.dungeonWalls = dungeonWalls;
        this.levelLoader = levelLoader;
        this.enemyFactory = enemyFactory;
        this.onRoomChanged = onRoomChanged;
        this.onRebuildCollision = onRebuildCollision;
        this.updateLinkMapPos = updateLinkMapPos;
        this.updateInventoryMap = updateInventoryMap;
    }

    public void Handle(string exitDirection)
    {
        string targetRoom = doorManager.GetTarget(exitDirection);
        if (targetRoom == null)
        {
            // No connection — push Link back to the inner boundary.
            int s = link.Rect.Width;
            link.Position = exitDirection switch
            {
                "west" => new Vector2(dungeonWalls.InnerBounds.Left, link.Position.Y),
                "east" => new Vector2(dungeonWalls.InnerBounds.Right - s, link.Position.Y),
                "north" => new Vector2(link.Position.X, dungeonWalls.InnerBounds.Top),
                "south" => new Vector2(link.Position.X, dungeonWalls.InnerBounds.Bottom - s),
                _ => link.Position
            };
            return;
        }

        LevelData newData = LevelLoader.Load(targetRoom);
        doorManager.Reset(newData.doors, newData.doorTypes, targetRoom);
        Level newLevel = LevelBuilder.Build(newData, enemyFactory, dungeonWalls.InnerBounds);

        // Place Link just inside the inner bounds at the opposite door.
        int spriteSize = link.Rect.Width;
        int doorCenterX = (dungeonWalls.TopDoorLeft + dungeonWalls.TopDoorRight) / 2;
        int doorCenterY = (dungeonWalls.SideDoorTop + dungeonWalls.SideDoorBottom) / 2;
        link.Position = exitDirection switch
        {
            "east" => new Vector2(dungeonWalls.InnerBounds.Left, doorCenterY - spriteSize / 2),
            "west" => new Vector2(dungeonWalls.InnerBounds.Right - spriteSize, doorCenterY - spriteSize / 2),
            "south" => new Vector2(doorCenterX - spriteSize / 2, dungeonWalls.InnerBounds.Top),
            "north" => new Vector2(doorCenterX - spriteSize / 2, dungeonWalls.InnerBounds.Bottom - spriteSize),
            _ => link.Position
        };

        onRoomChanged(newData, newLevel);
        onRebuildCollision();
        updateLinkMapPos(exitDirection);
        updateInventoryMap(newData, exitDirection);
    }
}