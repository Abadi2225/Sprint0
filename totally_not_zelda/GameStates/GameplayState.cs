using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint.Character;
using Sprint.Collision;
using Sprint.Commands;
using Sprint.Interfaces;
using Sprint.Enemies;
using Sprint.Item;
using System.Collections.Generic;
using Sprint.Block;
using Sprint.Collisions;
using Sprint.Levels;
using Sprint.UI;
using Sprint.InputHandling;
using Sprint.UI.InventoryElements;

class GameplayState : IGameState
{
    private Texture2D linkSheet;
    private Texture2D enemiesSheet;
    private Texture2D bossesSheet;
    private Texture2D dustSheet;
    private Texture2D NPCSheet;
    private Texture2D outerWallsTexture;
    private Texture2D innerWallsTexture;
    private Texture2D hudElements;
    private Texture2D doorSheet;

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

    private CollisionManager collisionManager;
    private DoorManager doorManager;
    private DoorTransitionHandler doorTransitionHandler;
    // todo delete this
    private bool lmbReleased = true;
    private bool rmbReleased = true;
    private InnerDungeonWalls innerWalls;
    private GameplayInputHandler inputHandler;
    private OuterDungeonWalls dungeonWalls;

    public GameplayState()
    {
    }

    public void Exit() { }

    public void Enter()
    {
        inputHandler = new GameplayInputHandler(this, link, inventory, items, hud, invMap);
    }

    public void LoadContent()
    {
        linkSheet = GameServices.Content.Load<Texture2D>("images/Link");
        enemiesSheet = GameServices.Content.Load<Texture2D>("images/enemiesSheet");
        bossesSheet = GameServices.Content.Load<Texture2D>("images/BossesSpriteSheet");
        dustSheet = GameServices.Content.Load<Texture2D>("images/dustSheet");
        NPCSheet = GameServices.Content.Load<Texture2D>("images/NPC");
        outerWallsTexture = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonOuterWalls");
        innerWallsTexture = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonInnerWalls");
        hudElements = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
        GameServices.ItemSheet = GameServices.Content.Load<Texture2D>("items/sheet");
        GameServices.BoomerangSheet = GameServices.Content.Load<Texture2D>("items/boomerang");
        doorSheet = GameServices.Content.Load<Texture2D>("blocks/Doors");
        GameServices.TileSheet = GameServices.Content.Load<Texture2D>("blocks/tiles");
        GameServices.OnLinkGrabbed = () =>
        {
            levelLoader.ResetToFirst();
            currentLevelData = levelLoader.GetCurrentLevel();
            doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes);
            currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, dungeonWalls.InnerBounds);
            RebuildCollisionManager();
            link.Position = GameServices.DungeonEntrancePosition;
        };

        Vector2 center = new Vector2(GameServices.GameWidth / 2, GameServices.GameHeight / 2);

        link = new Link(linkSheet, center);
        GameServices.Link = link;

        enemyManager = new EnemyManager();
        enemyFactory = new EnemyFactory(enemiesSheet, bossesSheet, linkSheet, dustSheet, NPCSheet);

        uiManager = new UIManager();
        dungeonWalls = new OuterDungeonWalls(outerWallsTexture);
        uiManager.AddElement(dungeonWalls);
        innerWalls = new InnerDungeonWalls(innerWallsTexture);

        GameServices.DungeonEntrancePosition = new Vector2(
            (dungeonWalls.BottomDoorLeft + dungeonWalls.BottomDoorRight) / 2,
            dungeonWalls.BottomDoorTop - 16 * GameServices.ScaleFactor
        );


        levelLoader = new LevelLoader();
        currentLevelData = levelLoader.GetCurrentLevel();

        invMap = new InventoryMap(levelLoader.GetCurrentLevel(), 58, true);

        items = new ItemManager();
        inventory = new Inventory();

        // inventory items — D1=Boomerang, D2=Bow, D3=Bomb
        inventory.Add(ItemFactory.CreateBoomerang(Vector2.Zero, Vector2.Zero, maxDistance: 160f));
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bow, Vector2.Zero, GameServices.ScaleFactor));
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bomb, Vector2.Zero, GameServices.ScaleFactor));

        hud = new HUDBar(0, 0, inventory.Get(inventory.ActiveSlot), hudElements);
        uiManager.AddElement(hud);

        doorManager = new DoorManager(doorSheet, GameServices.ScaleFactor, 48 * GameServices.ScaleFactor);
        doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes);
        doorTransitionHandler = new DoorTransitionHandler(doorManager, link, dungeonWalls, levelLoader, enemyFactory,
            (data, level) => { currentLevelData = data; currentLevel = level; }, RebuildCollisionManager, hud.Map.UpdateLinkMapPos, invMap.UpdateInventoryMap);

        currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, dungeonWalls.InnerBounds);
        RebuildCollisionManager();
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
        collisionManager.Add(new LinkWallCollisionHandler(link, dungeonWalls, doorManager, doorTransitionHandler.Handle));
        collisionManager.Add(new EnemyWallCollisionHandler(currentLevel.Enemies.enemyList, dungeonWalls));
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

        foreach (var item in items.JustFinished)
            if (item.Name == "TimeBomb")
                doorManager.TryUnlockBomb(item.Position, 80f);

        collisionManager.HandleAll();
        inputHandler.HandleInput();

        MouseState mouse = Mouse.GetState();
        if (mouse.RightButton == ButtonState.Pressed && rmbReleased)
        {
            rmbReleased = false;
            currentLevelData = levelLoader.CycleNext();
            doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes);
            currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, dungeonWalls.InnerBounds);
            RebuildCollisionManager();
        }
        if (mouse.LeftButton == ButtonState.Pressed && lmbReleased)
        {
            lmbReleased = false;
            currentLevelData = levelLoader.CyclePrevious();
            doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes);
            currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, dungeonWalls.InnerBounds);
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
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        currentLevel.Draw(spriteBatch);
        innerWalls.Draw(spriteBatch);       // blocks, then WallMaster entering
        doorManager.Draw(spriteBatch);     // locked door visuals over openings
        link.Draw(spriteBatch);
        items.Draw(spriteBatch);
        currentLevel.DrawOnTop(spriteBatch); // Keese on top
        uiManager.Draw(spriteBatch);       // rest of UI (minus DungeonWalls)
    }
}
