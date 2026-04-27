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
using System.Collections.Generic;

class GameplayState : IGameState
{
    private Texture2D linkSheet;
    private Texture2D enemiesSheet;
    private Texture2D bossesSheet;
    private Texture2D dustSheet;
    private Texture2D NPCSheet;
    private Texture2D fontSheet;
    private Texture2D outerWallsTexture;
    private Texture2D innerWallsTexture;
    private Texture2D staircaseTexture;
    private Texture2D hudElements;
    private Texture2D doorSheet;
    private Texture2D pixel;

    private Link link;
    private ItemManager items;
    private Inventory inventory;
    private InventoryMap invMap;
    private EnemyFactory enemyFactory;
    private LevelLoader levelLoader;
    private RoomManager roomManager;

    private UIManager uiManager;
    private HUDBar hud;
    private TriforceOverlay triforceOverlay;

    private CollisionManager collisionManager;
    private DoorManager doorManager;
    private DoorTransitionHandler doorTransitionHandler;
    private bool lmbReleased = true;
    private bool rmbReleased = true;
    private bool roomTransitionActive;
    private InnerDungeonWalls innerWalls;
    private GameplayInputHandler inputHandler;
    private OuterDungeonWalls dungeonWalls;

    private GameOverTransition gameOverTransition;
    private TextWriter gameOverText;
    private TextWriter NPCRoomTextRowOne;
    private TextWriter NPCRoomTextRowTwo;

    public GameplayState() { }

    public void Exit() { }

    public void Enter()
    {
        inputHandler = new GameplayInputHandler(this, link, inventory, items, hud, invMap);
    }

    public void LoadContent()
    {
        fontSheet         = GameServices.Content.Load<Texture2D>("images/Fonts");
        linkSheet         = GameServices.Content.Load<Texture2D>("images/Link");
        enemiesSheet      = GameServices.Content.Load<Texture2D>("images/enemiesSheet");
        bossesSheet       = GameServices.Content.Load<Texture2D>("images/BossesSpriteSheet");
        dustSheet         = GameServices.Content.Load<Texture2D>("images/dustSheet");
        NPCSheet          = GameServices.Content.Load<Texture2D>("images/NPC");
        outerWallsTexture = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonOuterWalls");
        innerWallsTexture = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonInnerWalls");
        staircaseTexture  = GameServices.Content.Load<Texture2D>("dungeonWalls/Underground");
        hudElements       = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
        GameServices.ItemSheet      = GameServices.Content.Load<Texture2D>("items/sheet");
        GameServices.LinkSheet      = linkSheet;
        GameServices.BoomerangSheet = GameServices.Content.Load<Texture2D>("items/boomerang");
        doorSheet         = GameServices.Content.Load<Texture2D>("blocks/Doors");
        GameServices.TileSheet = GameServices.Content.Load<Texture2D>("blocks/tiles");

        pixel = new Texture2D(GameServices.GraphicsDevice, 1, 1);
        pixel.SetData([Color.White]);

        link = new Link(linkSheet, dustSheet, new Vector2(GameServices.GameWidth / 2, GameServices.GameHeight / 2));
        GameServices.Link = link;

        items     = new ItemManager();
        inventory = new Inventory();
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bomb, Vector2.Zero, GameServices.ScaleFactor));

        enemyFactory = new EnemyFactory(enemiesSheet, bossesSheet, linkSheet, dustSheet, NPCSheet);

        uiManager    = new UIManager();
        dungeonWalls = new OuterDungeonWalls(outerWallsTexture);
        innerWalls   = new InnerDungeonWalls(innerWallsTexture);
        triforceOverlay = new TriforceOverlay(link, pixel);

        GameServices.DungeonEntrancePosition = new Vector2(
            (dungeonWalls.BottomDoorLeft + dungeonWalls.BottomDoorRight) / 2,
            dungeonWalls.BottomDoorTop - 16 * GameServices.ScaleFactor);
        link.Position = GameServices.DungeonEntrancePosition;

        levelLoader = new LevelLoader();

        invMap = new InventoryMap(levelLoader.GetCurrentLevel(), levelLoader.GetCurrentLevelGridLoc(), false);
        GameServices.inventoryMap = invMap;

        hud = new HUDBar(0, 0, inventory, hudElements);
        GameServices.hudMap = hud.Map;
        uiManager.AddElement(hud);

        doorManager = new DoorManager(doorSheet, GameServices.ScaleFactor, 48 * GameServices.ScaleFactor);

        gameOverText = TextWriter.CreateGameOverText(fontSheet);
        gameOverTransition = new GameOverTransition(
            dungeonWalls.OuterBounds,
            Game1.Instance.GraphicsDevice,
            gameOverText);

        NPCRoomTextRowOne = TextWriter.CreateNPCText1(fontSheet);
        NPCRoomTextRowTwo = TextWriter.CreateNPCText2(fontSheet);

        roomManager = new RoomManager(
            levelLoader, enemyFactory, uiManager, dungeonWalls,
            staircaseTexture, RebuildCollisionManager, items.SpawnItem);

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
            },
            RebuildCollisionManager,
            hud.Map.UpdateLinkMapPos,
            invMap.UpdateInventoryMap,
            items.SpawnItem);

        GameServices.OnLinkGrabbed = () =>
        {
            DoorStateRegistry.Reset();
            roomManager.ResetToFirst();
            doorManager.Reset(
                roomManager.CurrentLevelData.doors,
                roomManager.CurrentLevelData.doorTypes,
                roomManager.CurrentLevelData.doorOffsets,
                roomManager.CurrentLevelName);
            link.Position = GameServices.DungeonEntrancePosition;
            GameServices.hudMap.SetLinkPos(levelLoader.GetCurrentLevelGridLoc());
            GameServices.inventoryMap.SetLinkPos(levelLoader.GetCurrentLevelGridLoc());
        };

        MusicPlayer.Play(MusicType.DUNGEON);
        RebuildCollisionManager();
        ResetMaps();
    }

    private void RebuildCollisionManager()
    {
        collisionManager = new CollisionManager();

        var moldorms = new List<Moldorm>();
        foreach (var enemy in roomManager.CurrentLevel.Enemies.EnemyList)
        {
            var actual = enemy is EnemyEffectWrapper w ? w.InnerEnemy : enemy;
            if (actual is Moldorm m)
                moldorms.Add(m);
        }
        if (moldorms.Count > 0)
            collisionManager.Add(new MoldormCollisionHandler(link, moldorms));

        collisionManager.Add(new LinkEnemyCollision(link, roomManager.CurrentLevel.Enemies));
        collisionManager.Add(new SwordEnemyCollision(link, roomManager.CurrentLevel.Enemies));
        collisionManager.Add(new EnemyBlockCollisionHandler(roomManager.CurrentLevel.Enemies.EnemyList, roomManager.CurrentLevel.Blocks));
        collisionManager.Add(new LinkBlockPushHandler(link, roomManager.CurrentLevel.Blocks));
        collisionManager.Add(new LinkBlockCollisionHandler(link, roomManager.CurrentLevel.Blocks));
        collisionManager.Add(new LinkItemCollision(link, inventory, roomManager.CurrentLevel.WorldItems));
        collisionManager.Add(new ProjectileCollision(link, items, roomManager.CurrentLevel.Enemies));
        collisionManager.Add(new EnemyWallCollisionHandler(roomManager.CurrentLevel.Enemies.EnemyList, dungeonWalls));

        if (!roomManager.IsUnderground)
            collisionManager.Add(new LinkWallCollisionHandler(link, dungeonWalls, doorManager, HandleDoorExit));

        if (roomManager.CurrentLevelData?.stairTarget != null)
            collisionManager.Add(new StairCollisionHandler(
                link, roomManager.CurrentLevel.Blocks,
                roomManager.CurrentLevelData.stairTarget,
                targetRoom => roomManager.HandleStairTransition(targetRoom, doorManager, link)));
    }

    private void HandleDoorExit(string direction)
    {
        Level oldLevel = roomManager.CurrentLevel;

        var oldDoorManager = new DoorManager(doorSheet, GameServices.ScaleFactor, 48 * GameServices.ScaleFactor);
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
            dungeonWalls, innerWalls, link,
            direction, this);

        roomTransitionActive = true;
        Game1.Instance.ForceState(transition);
    }

    public void Update(GameTime gameTime)
    {
        uiManager.Update(gameTime);
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
        }

        if (link.ShouldEndTriforceSequence())
        {
            link.EndTriforceSequence();
            MenuState menu = new MenuState();
            menu.LoadContent();
            menu.Enter();
            Game1.Instance.ForceState(menu);
        }

        MouseState mouse = Mouse.GetState();
        if (mouse.RightButton == ButtonState.Pressed && rmbReleased)
        {
            rmbReleased = false;
            roomManager.CycleNext();
            doorManager.Reset(
                roomManager.CurrentLevelData.doors,
                roomManager.CurrentLevelData.doorTypes,
                roomManager.CurrentLevelData.doorOffsets,
                roomManager.CurrentLevelName);
        }
        if (mouse.LeftButton == ButtonState.Pressed && lmbReleased)
        {
            lmbReleased = false;
            roomManager.CyclePrevious();
            doorManager.Reset(
                roomManager.CurrentLevelData.doors,
                roomManager.CurrentLevelData.doorTypes,
                roomManager.CurrentLevelData.doorOffsets,
                roomManager.CurrentLevelName);
        }
        if (mouse.RightButton == ButtonState.Released) rmbReleased = true;
        if (mouse.LeftButton  == ButtonState.Released) lmbReleased = true;

        if (link.IsDead && !gameOverTransition.Finished)
            gameOverTransition.Start();

        gameOverTransition.Update(gameTime, link);

        if (gameOverTransition.Finished)
        {
            MenuState menu = new MenuState();
            menu.LoadContent();
            menu.Enter();
            Game1.Instance.ForceState(menu);
            return;
        }

        if (roomManager.IsNPCRoom)
        {
            NPCRoomTextRowOne.Update(gameTime);
            NPCRoomTextRowTwo.Update(gameTime);
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        roomManager.CurrentLevel.Draw(spriteBatch);
        if (!roomManager.IsUnderground)
            innerWalls.Draw(spriteBatch);
        doorManager.Draw(spriteBatch);
        uiManager.Draw(spriteBatch);
        roomManager.CurrentLevel.DrawOnTop(spriteBatch);
        if (roomManager.IsNPCRoom)
        {
            NPCRoomTextRowOne.Draw(spriteBatch);
            NPCRoomTextRowTwo.Draw(spriteBatch);
        }
        gameOverTransition.DrawBlackOut(spriteBatch);
        gameOverTransition.DrawGameOverText(spriteBatch);
        link.Draw(spriteBatch);
        items.Draw(spriteBatch);
        triforceOverlay.Draw(spriteBatch);
    }

    internal void SwitchDungeon(int dungeon)
    {
        roomManager.SwitchDungeon(dungeon);
        doorManager.Reset(
            roomManager.CurrentLevelData.doors,
            roomManager.CurrentLevelData.doorTypes,
            roomManager.CurrentLevelData.doorOffsets,
            roomManager.CurrentLevelName);
        innerWalls.RefreshColor();
        ResetMaps();
    }

    internal void DrawRoomContent(SpriteBatch sb, Level level, DoorManager doors, bool drawDoors)
    {
        level.Draw(sb);
        if (!roomManager.IsUnderground) innerWalls.Draw(sb);
        if (drawDoors) doors.Draw(sb);
        level.DrawOnTop(sb);
    }

    internal void DrawHUDOnly(SpriteBatch sb) => hud.Draw(sb);

    private void ResetMaps()
    {
        int dungeon = GameServices.CurrentDungeon;
        inventory.HasMap = false;
        inventory.HasCompass = false;
        hud.SetMap(levelLoader.GetCurrentLevelName(), LevelLoader.getTriforceGridLoc(dungeon), false, dungeon);
        invMap = new InventoryMap(levelLoader.GetCurrentLevel(), levelLoader.GetCurrentLevelGridLoc(), false);
        GameServices.inventoryMap = invMap;
        doorTransitionHandler.ReloadMapReferences();
    }
}