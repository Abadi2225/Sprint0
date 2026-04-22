using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint;
using Sprint.Block;
using Sprint.Character;
using Sprint.Collision;
using Sprint.Collisions;
using Sprint.Commands;
using Sprint.Doors;
using Sprint.Enemies;
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
    private EnemyManager enemyManager;
    private EnemyFactory enemyFactory;
    private LevelLoader levelLoader;
    private Level currentLevel;
    private LevelData currentLevelData;

    private UIManager uiManager;
    private HUDBar hud;
    private IUIElement currentBackground;
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
    private GameOverText gameOverText;

    public GameplayState()
    {
    }

    public void Exit() { }

    public void Enter()
    {
        inputHandler = new GameplayInputHandler(this, link, inventory, items, hud, invMap);
		MusicPlayer.Play(MusicType.DUNGEON);
	}

    public void LoadContent()
    {
        fontSheet = GameServices.Content.Load<Texture2D>("images/Fonts");
        linkSheet = GameServices.Content.Load<Texture2D>("images/Link");
        enemiesSheet = GameServices.Content.Load<Texture2D>("images/enemiesSheet");
        bossesSheet = GameServices.Content.Load<Texture2D>("images/BossesSpriteSheet");
        dustSheet = GameServices.Content.Load<Texture2D>("images/dustSheet");
        NPCSheet = GameServices.Content.Load<Texture2D>("images/NPC");
        outerWallsTexture = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonOuterWalls");
        innerWallsTexture = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonInnerWalls");
        staircaseTexture = GameServices.Content.Load<Texture2D>("dungeonWalls/Underground");
        hudElements = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
        GameServices.ItemSheet = GameServices.Content.Load<Texture2D>("items/sheet");
        GameServices.LinkSheet = linkSheet;
        GameServices.BoomerangSheet = GameServices.Content.Load<Texture2D>("items/boomerang");
        doorSheet = GameServices.Content.Load<Texture2D>("blocks/Doors");
        GameServices.TileSheet = GameServices.Content.Load<Texture2D>("blocks/tiles");

        pixel = new Texture2D(GameServices.GraphicsDevice, 1, 1);
        pixel.SetData([Color.White]);
        GameServices.OnLinkGrabbed = () =>
        {
            levelLoader.ResetToFirst();
            currentLevelData = levelLoader.GetCurrentLevel();
            DoorStateRegistry.Reset();
            doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes,
            currentLevelData.doorOffsets, levelLoader.GetCurrentLevelName());
            UpdateBackground();
            currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, GetInnerBounds());
            RebuildCollisionManager();
            link.Position = GameServices.DungeonEntrancePosition;
            GameServices.hudMap.SetLinkPos(levelLoader.GetCurrentLevelGridLoc());
            GameServices.inventoryMap.SetLinkPos(levelLoader.GetCurrentLevelGridLoc());
        };

        Vector2 center = new Vector2(GameServices.GameWidth / 2, GameServices.GameHeight / 2);

        link = new Link(linkSheet, dustSheet, center);
        GameServices.Link = link;

        enemyManager = new EnemyManager();
        enemyFactory = new EnemyFactory(enemiesSheet, bossesSheet, linkSheet, dustSheet, NPCSheet);

        uiManager = new UIManager();
        dungeonWalls = new OuterDungeonWalls(outerWallsTexture);
        innerWalls = new InnerDungeonWalls(innerWallsTexture);

        uiManager.AddElement(dungeonWalls);
        innerWalls = new InnerDungeonWalls(innerWallsTexture);

        triforceOverlay = new TriforceOverlay(link, pixel);
        GameServices.DungeonEntrancePosition = new Vector2(
            (dungeonWalls.BottomDoorLeft + dungeonWalls.BottomDoorRight) / 2,
            dungeonWalls.BottomDoorTop - 16 * GameServices.ScaleFactor
        );
        link.Position = GameServices.DungeonEntrancePosition;

        levelLoader = new LevelLoader();
        currentLevelData = levelLoader.GetCurrentLevel();

        invMap = new InventoryMap(levelLoader.GetCurrentLevel(), levelLoader.GetCurrentLevelGridLoc(), true);
        GameServices.inventoryMap = invMap;

        items = new ItemManager();
        inventory = new Inventory();

        inventory.Add(ItemFactory.CreateBoomerang(Vector2.Zero, Vector2.Zero, maxDistance: 160f));
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bow, Vector2.Zero, GameServices.ScaleFactor));
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bomb, Vector2.Zero, GameServices.ScaleFactor));

        hud = new HUDBar(0, 0, inventory, hudElements);
        GameServices.hudMap = hud.Map;
        uiManager.AddElement(hud);

        doorManager = new DoorManager(doorSheet, GameServices.ScaleFactor, 48 * GameServices.ScaleFactor);
        doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes,
        currentLevelData.doorOffsets, levelLoader.GetCurrentLevelName());

        gameOverText = new GameOverText(fontSheet);
        gameOverTransition = new GameOverTransition(
            dungeonWalls.OuterBounds,
            Game1.Instance.GraphicsDevice,
            gameOverText
        );

        doorManager = new DoorManager(doorSheet, GameServices.ScaleFactor, 48 * GameServices.ScaleFactor);
        doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes);
        doorTransitionHandler = new DoorTransitionHandler(
            doorManager, link,
            () => GetInnerBounds(),
            () => dungeonWalls.TopDoorLeft,
            () => dungeonWalls.TopDoorRight,
            () => dungeonWalls.SideDoorTop,
            () => dungeonWalls.SideDoorBottom,
            levelLoader, enemyFactory,
            (data, level) => { currentLevelData = data; currentLevel = level; },
            RebuildCollisionManager,
            hud.Map.UpdateLinkMapPos,
            invMap.UpdateInventoryMap);

        UpdateBackground();
        currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, dungeonWalls.InnerBounds);

        RebuildCollisionManager();
    }

    private bool IsUnderground => currentLevelData?.background == "Underground";
    private Rectangle GetInnerBounds()
    {
        if (IsUnderground && currentBackground is StaircaseBackground sb)
            return sb.InnerBounds;
        return dungeonWalls.InnerBounds;
    }

    private void UpdateBackground()
    {
        if (currentBackground != null)
            uiManager.RemoveElement(currentBackground);

        if (IsUnderground)
            currentBackground = new StaircaseBackground(staircaseTexture);
        else
            currentBackground = dungeonWalls;

        uiManager.AddElement(currentBackground);
    }
    private void RebuildCollisionManager()
    {
        collisionManager = new CollisionManager();
        collisionManager.Add(new LinkEnemyCollision(link, currentLevel.Enemies));
        collisionManager.Add(new SwordEnemyCollision(link, currentLevel.Enemies));
        collisionManager.Add(new EnemyBlockCollisionHandler(currentLevel.Enemies.enemyList, currentLevel.Blocks));
        collisionManager.Add(new LinkBlockPushHandler(link, currentLevel.Blocks));
        collisionManager.Add(new LinkBlockCollisionHandler(link, currentLevel.Blocks));
        collisionManager.Add(new LinkItemCollision(link, inventory, currentLevel.WorldItems));
        collisionManager.Add(new ActiveItemEnemyCollision(items, currentLevel.Enemies));
        collisionManager.Add(new LinkEnemyProjectileCollision(link, currentLevel.Enemies));
        collisionManager.Add(new EnemyWallCollisionHandler(currentLevel.Enemies.enemyList, dungeonWalls));
        if (!IsUnderground)
        collisionManager.Add(new LinkWallCollisionHandler(link, dungeonWalls, doorManager, HandleDoorExit));

        if (currentLevelData?.stairTarget != null)
            collisionManager.Add(new StairCollisionHandler(
                link, currentLevel.Blocks,
                currentLevelData.stairTarget,
                HandleStairTransition));
    }

    private void HandleDoorExit(string direction)
    {
        Level oldLevel = currentLevel;

        // Snapshot old room's door state before Handle() resets doorManager for the new room
        var oldDoorManager = new DoorManager(doorSheet, GameServices.ScaleFactor, 48 * GameServices.ScaleFactor);
        oldDoorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes,
            currentLevelData.doorOffsets, levelLoader.GetCurrentLevelName());

        doorTransitionHandler.Handle(direction);
        Level newLevel = currentLevel;

        var transition = new RoomTransitionState(
            oldLevel, oldDoorManager,
            newLevel, doorManager,
            dungeonWalls, innerWalls, link,
            direction, this);

        roomTransitionActive = true;
        Game1.Instance.ForceState(transition);
    }

    private void HandleStairTransition(string targetRoom)
    {
        LevelData newData = LevelLoader.Load(targetRoom);
        doorManager.Reset(newData.doors, newData.doorTypes, newData.doorOffsets, targetRoom);
        currentLevelData = newData;
        UpdateBackground();
        currentLevel = LevelBuilder.Build(newData, enemyFactory, GetInnerBounds());

        link.Position = new Vector2(
            49 * GameServices.ScaleFactor + GetInnerBounds().Left,
            GetInnerBounds().Top + 16 * GameServices.ScaleFactor);

        RebuildCollisionManager();
        hud.Map.UpdateLinkMapPos("stair");
        invMap.UpdateInventoryMap(newData, "stair");
    }

    public void Update(GameTime gameTime)
    {
        uiManager.Update(gameTime);
        currentLevel.Update(gameTime);
        link.Update(gameTime);
        inventory.Update(gameTime);
        items.Update(gameTime);

        if (currentLevel.Enemies.AllDead)
            doorManager.UnlockEnemyDoors();

        if (currentLevel.Enemies.AllDead && currentLevel.Blocks.blocksList.Exists(b => b.HasBeenPushed))
            doorManager.TryUnlockEnemyBlockDoors();

        foreach (var item in items.JustFinished)
            if (item.Name == "TimeBomb")
                doorManager.TryUnlockBomb(item.Position, 80f);

        // if statements to handle Link Triforce pickup
        if(!link.TriforceActive)
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
            currentLevelData = levelLoader.CycleNext();
            doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes,
                currentLevelData.doorOffsets, levelLoader.GetCurrentLevelName());
            UpdateBackground();
            currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, GetInnerBounds());
            RebuildCollisionManager();
        }
        if (mouse.LeftButton == ButtonState.Pressed && lmbReleased)
        {
            lmbReleased = false;
            currentLevelData = levelLoader.CyclePrevious();
            doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes,
                currentLevelData.doorOffsets, levelLoader.GetCurrentLevelName());
            UpdateBackground();
            currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, GetInnerBounds());
            RebuildCollisionManager();
        }
        if (mouse.RightButton == ButtonState.Released)
        {
            rmbReleased = true;
        }
        if (mouse.LeftButton == ButtonState.Released)
        {
            lmbReleased = true;
        }

        if (link.IsDead && !gameOverTransition.Finished)
        {
            gameOverTransition.Start();
        }

        gameOverTransition.Update(gameTime, link);

        if (gameOverTransition.Finished)
        {
            MenuState menu = new MenuState();
            menu.LoadContent();
            menu.Enter();
            Game1.Instance.ForceState(menu);
            return;
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        currentLevel.Draw(spriteBatch);
        if (!IsUnderground)
            innerWalls.Draw(spriteBatch);
        doorManager.Draw(spriteBatch);
        uiManager.Draw(spriteBatch);
        currentLevel.DrawOnTop(spriteBatch);
		gameOverTransition.DrawBlackOut(spriteBatch);
        gameOverTransition.DrawGameOverText(spriteBatch);
		link.Draw(spriteBatch);
		items.Draw(spriteBatch);
        triforceOverlay.Draw(spriteBatch);

	}

    internal void DrawRoomContent(SpriteBatch sb, Level level, DoorManager doors, bool drawDoors)
    {
        level.Draw(sb);
        if (!IsUnderground) innerWalls.Draw(sb);
        if (drawDoors) doors.Draw(sb);
        level.DrawOnTop(sb);
    }

    internal void DrawHUDOnly(SpriteBatch sb) => hud.Draw(sb);
}
