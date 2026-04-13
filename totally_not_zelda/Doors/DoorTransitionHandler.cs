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
    private readonly Func<Rectangle> getInnerBounds;
    private readonly Func<int> getTopDoorLeft;
    private readonly Func<int> getTopDoorRight;
    private readonly Func<int> getSideDoorTop;
    private readonly Func<int> getSideDoorBottom;
    private readonly LevelLoader levelLoader;
    private readonly EnemyFactory enemyFactory;
    private readonly Action<LevelData, Level> onRoomChanged;
    private readonly Action onRebuildCollision;
    private readonly Action<string> updateLinkMapPos;
    private readonly Action<LevelData, string> updateInventoryMap;

    public DoorTransitionHandler(DoorManager doorManager, ILink link,
        Func<Rectangle> getInnerBounds,
        Func<int> getTopDoorLeft,
        Func<int> getTopDoorRight,
        Func<int> getSideDoorTop,
        Func<int> getSideDoorBottom,
        LevelLoader levelLoader, EnemyFactory enemyFactory,
        Action<LevelData, Level> onRoomChanged, Action onRebuildCollision, Action<string> updateLinkMapPos, Action<LevelData, string> updateInventoryMap)
    {
        this.doorManager = doorManager;
        this.link = link;
        this.getInnerBounds = getInnerBounds;
        this.getTopDoorLeft = getTopDoorLeft;
        this.getTopDoorRight = getTopDoorRight;
        this.getSideDoorTop = getSideDoorTop;
        this.getSideDoorBottom = getSideDoorBottom;
        this.levelLoader = levelLoader;
        this.enemyFactory = enemyFactory;
        this.onRoomChanged = onRoomChanged;
        this.onRebuildCollision = onRebuildCollision;
        this.updateLinkMapPos = updateLinkMapPos;
        this.updateInventoryMap = updateInventoryMap;
    }

    public void Handle(string exitDirection)
    {
        Rectangle innerBounds = getInnerBounds();
        string targetRoom = doorManager.GetTarget(exitDirection);

        if (targetRoom == null)
        {
            int s = link.Rect.Width;
            link.Position = exitDirection switch
            {
<<<<<<< HEAD:totally_not_zelda/Block/DoorTransitionHandler.cs
                "west"  => new Vector2(innerBounds.Left, link.Position.Y),
                "east"  => new Vector2(innerBounds.Right - s, link.Position.Y),
                "north" => new Vector2(link.Position.X, innerBounds.Top),
                "south" => new Vector2(link.Position.X, innerBounds.Bottom - s),
                _       => link.Position
=======
                "west" => new Vector2(dungeonWalls.InnerBounds.Left, link.Position.Y),
                "east" => new Vector2(dungeonWalls.InnerBounds.Right - s, link.Position.Y),
                "north" => new Vector2(link.Position.X, dungeonWalls.InnerBounds.Top),
                "south" => new Vector2(link.Position.X, dungeonWalls.InnerBounds.Bottom - s),
                _ => link.Position
>>>>>>> 6d90022b7a1874cc7c06f0b8fcd5ccae6e9d9851:totally_not_zelda/Doors/DoorTransitionHandler.cs
            };
            return;
        }

<<<<<<< HEAD:totally_not_zelda/Block/DoorTransitionHandler.cs
        LevelData newData = levelLoader.Load(targetRoom);
        doorManager.Reset(newData.doors, newData.doorTypes, newData.doorOffsets);
        Level newLevel = LevelBuilder.Build(newData, enemyFactory, innerBounds);

        int spriteSize  = link.Rect.Width;
        int doorCenterX = (getTopDoorLeft() + getTopDoorRight()) / 2;
        int doorCenterY = (getSideDoorTop() + getSideDoorBottom()) / 2;

        link.Position = exitDirection switch
        {
            "east"  => new Vector2(innerBounds.Left, doorCenterY - spriteSize / 2),
            "west"  => new Vector2(innerBounds.Right - spriteSize, doorCenterY - spriteSize / 2),
            "south" => new Vector2(doorCenterX - spriteSize / 2, innerBounds.Top),
            "north" => new Vector2(doorCenterX - spriteSize / 2, innerBounds.Bottom - spriteSize),
            _       => link.Position
=======
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
>>>>>>> 6d90022b7a1874cc7c06f0b8fcd5ccae6e9d9851:totally_not_zelda/Doors/DoorTransitionHandler.cs
        };

        onRoomChanged(newData, newLevel);
        onRebuildCollision();
        updateLinkMapPos(exitDirection);
        updateInventoryMap(newData, exitDirection);
    }
}