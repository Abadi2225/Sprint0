using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint;
using Sprint.Character;
using Sprint.Collision;
using Sprint.Collisions;
using Sprint.Doors;
using Sprint.Enemies;
using Sprint.Enemies.Concrete;
using Sprint.GameStates;
using Sprint.InputHandling;
using Sprint.Interfaces;
using Sprint.Item;
using Sprint.Levels;
using Sprint.Sound;
using Sprint.UI;
using Sprint.UI.InventoryElements;
using Sprint.UI.Text;
using System.Collections.Generic;
using Sprint.GameStates.Gameplay;

class GameplayState : IGameState
{
    private Textures textures;

    private Link link;
    private ItemManager items;
    private Inventory inventory;
    private InventoryMap invMap;
    private EnemyFactory enemyFactory;
    private LevelLoader levelLoader;
    private RoomManager roomManager;

    private GameplayHUD gameplayHUD;

    private GameplayCollisionManager collisionManager;
    private DoorManager doorManager;
    private DoorTransitionHandler doorTransitionHandler;
    //  // for debug mode
    private bool debugMode = false;
    // end debug mode
    private bool roomTransitionActive;
    private GameplayInputHandler inputHandler;
    private OuterDungeonWalls dungeonWalls;

    private GameOverTransition gameOverTransition;
    private TextWriter gameOverText;
    public GameplayState() { }

    public void Exit() { }

    public void Enter()
    {
        inputHandler = new GameplayInputHandler(this, link, inventory, items, gameplayHUD.HUD);
    }

    public void LoadContent()
    {
        textures = new Textures();
        textures.SetGameServicesRefs();

        link = new Link(textures.linkSheet, textures.dustSheet, new Vector2(GameServices.GameWidth / 2, GameServices.GameHeight / 2));

        items = new ItemManager();
        inventory = new Inventory();
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bomb, Vector2.Zero, GameServices.ScaleFactor));

        enemyFactory = new EnemyFactory(textures.enemiesSheet, textures.bossesSheet, textures.linkSheet, textures.dustSheet, textures.NPCSheet);

        dungeonWalls = new OuterDungeonWalls(textures.outerWallsTexture);

        link.Position = new Vector2(
            (dungeonWalls.BottomDoorLeft + dungeonWalls.BottomDoorRight) / 2,
            dungeonWalls.BottomDoorTop - 16 * GameServices.ScaleFactor);

        levelLoader = new LevelLoader();

        gameplayHUD = new GameplayHUD(
            textures.fontSheet, textures.hudElements, textures.innerWallsTexture, textures.pixel,
            link, inventory, levelLoader, dungeonWalls);

        invMap = gameplayHUD.InvMap;

        doorManager = new DoorManager(textures.doorSheet, GameServices.ScaleFactor, 48 * GameServices.ScaleFactor);

        gameOverText = TextWriter.CreateGameOverText(textures.fontSheet);
        gameOverTransition = new GameOverTransition(
            dungeonWalls.OuterBounds,
            Game1.Instance.GraphicsDevice,
            gameOverText);

        roomManager = new RoomManager(
            levelLoader, enemyFactory, gameplayHUD.UIManager, dungeonWalls,
            textures.staircaseTexture, () => collisionManager?.Rebuild(roomManager), items.SpawnItem);

        gameplayHUD.UpdateNPCText(textures.fontSheet, roomManager.CurrentLevelData, GameServices.CurrentDungeon);

        doorManager.Reset(
            roomManager.CurrentLevelData.doors,
            roomManager.CurrentLevelData.doorTypes,
            roomManager.CurrentLevelData.doorOffsets,
            roomManager.CurrentLevelName);

        doorTransitionHandler = new DoorTransitionHandler(
            doorManager, link,
            () => roomManager.GetInnerBounds(),
            () => dungeonWalls.TopDoorLeft,
            () => dungeonWalls.TopDoorRight,
            () => dungeonWalls.SideDoorTop,
            () => dungeonWalls.SideDoorBottom,
            levelLoader, enemyFactory,
            (data, level) =>
            {
                roomManager.LoadRoom(data);
                gameplayHUD.UpdateNPCText(textures.fontSheet, roomManager.CurrentLevelData, GameServices.CurrentDungeon);
            },
            () => collisionManager?.Rebuild(roomManager),
            gameplayHUD.HUD.Map.UpdateLinkMapPos,
            invMap.UpdateInventoryMap,
            items.SpawnItem);

        collisionManager = new GameplayCollisionManager(
            link, inventory, items, dungeonWalls, doorManager, HandleDoorExit);
        collisionManager.Rebuild(roomManager);

        SetGameServicesRefs();

        MusicPlayer.Play(MusicType.DUNGEON);
        collisionManager.Rebuild(roomManager);
        GameStats.StartNewRun();
        ResetMaps();
    }

    private void SetGameServicesRefs()
    {
        GameServices.Link = link;
        GameServices.DungeonEntrancePosition = link.Position;
        GameServices.OnLinkGrabbed = () =>
        {
            DoorStateRegistry.Reset();
            roomManager.ResetToFirst();
            gameplayHUD.UpdateNPCText(textures.fontSheet, roomManager.CurrentLevelData, GameServices.CurrentDungeon);
            doorManager.Reset(
                roomManager.CurrentLevelData.doors,
                roomManager.CurrentLevelData.doorTypes,
                roomManager.CurrentLevelData.doorOffsets,
                roomManager.CurrentLevelName);
            link.Position = GameServices.DungeonEntrancePosition;
            GameServices.hudMap.SetLinkPos(levelLoader.GetCurrentLevelGridLoc());
            GameServices.inventoryMap.SetLinkPos(levelLoader.GetCurrentLevelGridLoc());
        };
    }

    private void HandleDoorExit(string direction)
    {
        Level oldLevel = roomManager.CurrentLevel;

        var oldDoorManager = new DoorManager(textures.doorSheet, GameServices.ScaleFactor, 48 * GameServices.ScaleFactor);
        oldDoorManager.Reset(
            roomManager.CurrentLevelData.doors,
            roomManager.CurrentLevelData.doorTypes,
            roomManager.CurrentLevelData.doorOffsets,
            roomManager.CurrentLevelName);

        doorTransitionHandler.Handle(direction);
        Level newLevel = roomManager.CurrentLevel;

        var transition = new RoomTransitionState(
            oldLevel, oldDoorManager,
            newLevel, doorManager,
            dungeonWalls, gameplayHUD, link,
            direction, this);

        roomTransitionActive = true;
        Game1.Instance.ForceState(transition);
    }

    public void Update(GameTime gameTime)
    {
        gameplayHUD.Update(gameTime, roomManager.IsNPCRoom);
        roomManager.CurrentLevel.Update(gameTime);
        link.Update(gameTime);
        inventory.Update(gameTime);
        items.Update(gameTime);

        if (roomManager.CurrentLevel.Enemies.AllDead)
            doorManager.UnlockEnemyDoors();

        if (roomManager.CurrentLevel.Enemies.AllDead &&
            roomManager.CurrentLevel.Blocks.blocksList.Exists(b => b.HasBeenPushed))
            doorManager.TryUnlockEnemyBlockDoors();


        foreach (var item in items.JustFinished)
            if (item.Name == "TimeBomb")
                doorManager.TryUnlockBomb(item.Position, 80f);

        if (!link.TriforceActive)
        {
            collisionManager.HandleAll();
            if (roomTransitionActive) { roomTransitionActive = false; return; }
            inputHandler.HandleInput();
            inputHandler.HandleMouseInput();
        }

        if (link.ShouldEndTriforceSequence())
        {
            link.EndTriforceSequence();
            if (GameServices.CurrentDungeon == 1)
            {
                DoorStateRegistry.Reset();
                SwitchDungeon(2);
                MusicPlayer.Play(MusicType.DUNGEON);
                link.Position = GameServices.DungeonEntrancePosition;
            }
            else
            {
                GameServices.GameActions.ChangeState(new GameCompleteState());
            }
        }

        if (link.IsDead && !gameOverTransition.Finished)
            gameOverTransition.Start();

        gameOverTransition.Update(gameTime, link);

        if (gameOverTransition.Finished)
        {
            MenuState menu = new MenuState();
            menu.LoadContent();
            menu.Enter();
            Game1.Instance.ForceState(menu);
            DungeonState.ResetProgess();
            return;
        }
    }

    // debug methods
    public void DebugToggle()
    {
        debugMode = !debugMode;
        if (debugMode) GiveDebugItems();
    }

    public void DebugCycleRoom(bool forwards)
    {
        if (!debugMode) return;

        if (forwards)
        {
            roomManager.CycleNext();
        }
        else
        {
            roomManager.CyclePrevious();
        }
        doorManager.Reset(
            roomManager.CurrentLevelData.doors,
            roomManager.CurrentLevelData.doorTypes,
            roomManager.CurrentLevelData.doorOffsets,
            roomManager.CurrentLevelName);
        gameplayHUD.UpdateNPCText(textures.fontSheet, roomManager.CurrentLevelData, GameServices.CurrentDungeon);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        roomManager.CurrentLevel.Draw(spriteBatch);
        doorManager.Draw(spriteBatch);
        gameplayHUD.Draw(spriteBatch, roomManager.IsUnderground, roomManager.IsNPCRoom);
        roomManager.CurrentLevel.DrawOnTop(spriteBatch);
        gameOverTransition.DrawBlackOut(spriteBatch);
        gameOverTransition.DrawGameOverText(spriteBatch);
        link.Draw(spriteBatch);
        items.Draw(spriteBatch);
    }

    internal void SwitchDungeon(int dungeon)
    {
        roomManager.SwitchDungeon(dungeon);
        doorManager.Reset(
            roomManager.CurrentLevelData.doors,
            roomManager.CurrentLevelData.doorTypes,
            roomManager.CurrentLevelData.doorOffsets,
            roomManager.CurrentLevelName);
        gameplayHUD.RefreshWallColor();
        gameplayHUD.UpdateNPCText(textures.fontSheet, roomManager.CurrentLevelData, GameServices.CurrentDungeon);
        ResetMaps();
    }
    internal void DrawRoomContent(SpriteBatch sb, Level level, DoorManager doors, bool drawDoors)
    {
        level.Draw(sb);
        gameplayHUD.DrawInnerWalls(sb);
        if (drawDoors) doors.Draw(sb);
        level.DrawOnTop(sb);
    }

    internal void DrawHUDOnly(SpriteBatch sb) => gameplayHUD.DrawHUDOnly(sb);

    // for debug mode
    private void GiveDebugItems()
    {
        while (link.MaxHealth < 16)
            link.AddHeartContainer();
        link.SetHealth(link.MaxHealth);
        link.SetBombs(99);
        link.SetKeys(99);
        link.IncreaseRupees(999);

        var existingNames = new HashSet<string>();
        foreach (var item in inventory.GetItems())
            existingNames.Add(item.Name);

        if (!existingNames.Contains("Bow"))
            inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bow, Vector2.Zero, GameServices.ScaleFactor));
        if (!existingNames.Contains("Boomerang"))
            inventory.Add(ItemFactory.CreateBoomerang(Vector2.Zero, Vector2.Zero, 0));

        inventory.HasMap = true;
        inventory.HasCompass = true;
    }
    // end debug mode

    private void ResetMaps()
    {
        int dungeon = GameServices.CurrentDungeon;
        inventory.HasMap = false;
        inventory.HasCompass = false;
        gameplayHUD.ResetMaps(levelLoader, dungeon);
        invMap = new InventoryMap(levelLoader.GetCurrentLevel(), levelLoader.GetCurrentLevelGridLoc(), false);
        GameServices.inventoryMap = invMap;
        doorTransitionHandler.ReloadMapReferences();
    }
}
