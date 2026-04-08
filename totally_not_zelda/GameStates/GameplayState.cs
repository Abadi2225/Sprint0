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
        inputHandler = new GameplayInputHandler(this, link, inventory, items, hud);
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

        Vector2 center = new Vector2(GameServices.GameWidth / 2, GameServices.GameHeight / 2);

        link = new Link(linkSheet, center);
        GameServices.Link = link;

        enemyManager = new EnemyManager();
        enemyFactory = new EnemyFactory(enemiesSheet, bossesSheet, linkSheet, dustSheet, NPCSheet);

        uiManager = new UIManager();
        hud = new HUDBar(0, 0, hudElements);
        uiManager.AddElement(hud);
        dungeonWalls = new OuterDungeonWalls(outerWallsTexture);
        uiManager.AddElement(dungeonWalls);
        innerWalls = new InnerDungeonWalls(innerWallsTexture);

        levelLoader = new LevelLoader();
        currentLevelData = levelLoader.GetCurrentLevel();

        doorManager = new DoorManager(doorSheet, GameServices.ScaleFactor, 48 * GameServices.ScaleFactor);
        doorManager.Reset(currentLevelData.doors, currentLevelData.doorTypes);
        doorTransitionHandler = new DoorTransitionHandler(doorManager, link, dungeonWalls, levelLoader, enemyFactory,
            (data, level) => { currentLevelData = data; currentLevel = level; }, RebuildCollisionManager);

        currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, dungeonWalls.InnerBounds);

        items = new ItemManager();
        inventory = new Inventory();

        // inventory items — D1=Boomerang, D2=Bow, D3=Bomb
        inventory.Add(ItemFactory.CreateBoomerang(Vector2.Zero, Vector2.Zero, maxDistance: 160f));
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bow, Vector2.Zero, 2));
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bomb, Vector2.Zero, 2));

        // Hardcoded world items for testing pickup and collision should be replaced by level-specific placements in the future
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Heart, new Vector2(126, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.BlueHeart, new Vector2(222, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.HalfHeart, new Vector2(366, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.ZeroHeart, new Vector2(558, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.HeartContainer, new Vector2(654, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Fairy, new Vector2(222, 318), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Clock, new Vector2(270, 318), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.GoldRupee, new Vector2(510, 318), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.PurpleRupee, new Vector2(654, 318), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.BluePotion, new Vector2(126, 366), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Map, new Vector2(270, 366), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Key, new Vector2(300, 366), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Compass, new Vector2(558, 366), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bow, new Vector2(222, 414), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.BlueCandle, new Vector2(366, 414), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.GoldTriforce, new Vector2(510, 414), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.PurpleTriforce, new Vector2(654, 414), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateBoomerang(new Vector2(126, 462), Vector2.Zero, maxDistance: 0));
        currentLevel.WorldItems.Add(ItemFactory.CreateArrow(new Vector2(270, 462), Vector2.Zero, rotation: 0f, scale: 2f, maxDistance: 0));
        currentLevel.WorldItems.Add(ItemFactory.CreateTimeBomb(explodeDelayMillis: 0, new Vector2(414, 462), scale: 2f));


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
