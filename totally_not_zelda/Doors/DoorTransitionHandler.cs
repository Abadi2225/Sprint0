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
    private Action<string> updateLinkMapPos;
    private Action<LevelData, string> updateInventoryMap;

    public DoorTransitionHandler(DoorManager doorManager, ILink link,
        Func<Rectangle> getInnerBounds,
        Func<int> getTopDoorLeft,
        Func<int> getTopDoorRight,
        Func<int> getSideDoorTop,
        Func<int> getSideDoorBottom,
        LevelLoader levelLoader, EnemyFactory enemyFactory,
        Action<LevelData, Level> onRoomChanged,
        Action onRebuildCollision,
        Action<string> updateLinkMapPos,
        Action<LevelData, string> updateInventoryMap)
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
                "west" => new Vector2(innerBounds.Left, link.Position.Y),
                "east" => new Vector2(innerBounds.Right - s, link.Position.Y),
                "north" => new Vector2(link.Position.X, innerBounds.Top),
                "south" => new Vector2(link.Position.X, innerBounds.Bottom - s),
                _ => link.Position
            };
            return;
        }

		levelLoader.SetCurrentLevel(targetRoom);

		LevelData newData = LevelLoader.Load(targetRoom);
        doorManager.Reset(newData.doors, newData.doorTypes, newData.doorOffsets, targetRoom);

        // Update room first so getInnerBounds() reflects the new room
        onRoomChanged(newData, LevelBuilder.Build(newData, enemyFactory, innerBounds));

        // Now get the correct bounds for the new room
        Rectangle newInnerBounds = getInnerBounds();
        Level newLevel = LevelBuilder.Build(newData, enemyFactory, newInnerBounds);
        onRoomChanged(newData, newLevel);
        onRebuildCollision();

        int spriteSize = link.Rect.Width;
        int doorCenterX = (getTopDoorLeft() + getTopDoorRight()) / 2;
        int doorCenterY = (getSideDoorTop() + getSideDoorBottom()) / 2;

        link.Position = exitDirection switch
        {
            "east" => new Vector2(newInnerBounds.Left, doorCenterY - spriteSize / 2),
            "west" => new Vector2(newInnerBounds.Right - spriteSize, doorCenterY - spriteSize / 2),
            "south" => new Vector2(doorCenterX - spriteSize / 2, newInnerBounds.Top),
            "north" => new Vector2(doorCenterX - spriteSize / 2, newInnerBounds.Bottom - spriteSize),
            _ => link.Position
        };

        updateLinkMapPos(exitDirection);
        updateInventoryMap(newData, exitDirection);
    }

    public void ReloadMapReferences()
    {
        updateLinkMapPos = GameServices.hudMap.UpdateLinkMapPos;
        updateInventoryMap = GameServices.inventoryMap.UpdateInventoryMap;
    }
}
