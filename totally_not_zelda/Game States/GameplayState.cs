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
using Sprint.Collisions;
using Sprint.Levels;
using Sprint.UI;
using Sprint.InputHandling;

class GameplayState : IGameState
{
    private Texture2D linkSheet;
    private Texture2D enemiesSheet;
    private Texture2D BossesSheet;
    private Texture2D dustSheet;
    private Texture2D NPCSheet;
    private Texture2D outerWallsTexture;
    private Texture2D innerWallsTexture;
    private Texture2D hudElements;

    private Link link;
    private ItemManager items;
    private Inventory inventory;
    private EnemyManager enemyManager;
    private EnemyFactory enemyFactory;
    private LevelLoader levelLoader;
    private Level currentLevel;
    private LevelData currentLevelData;
    private UIManager uiManager;
    private CollisionManager collisionManager;
    // todo delete this
    private bool lmbReleased = true;
    private bool rmbReleased = true;
    private InnerDungeonWalls innerWalls;
    private GameplayInputHandler inputHandler;
    private JesseDungeonWalls dungeonWalls;

    public GameplayState()
    {
    }

    public void Exit() { }

    public void Enter()
    {
        inputHandler = new GameplayInputHandler(link, inventory, items);
    }

    public void LoadContent()
    {
        linkSheet = GameServices.Content.Load<Texture2D>("images/Link");
        enemiesSheet = GameServices.Content.Load<Texture2D>("images/enemiesSheet");
        BossesSheet = GameServices.Content.Load<Texture2D>("images/BossesSpriteSheet");
        dustSheet = GameServices.Content.Load<Texture2D>("images/dustSheet");
        NPCSheet = GameServices.Content.Load<Texture2D>("images/NPC");
        outerWallsTexture = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonOuterWalls");
        innerWallsTexture = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonInnerWalls");
        hudElements = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
        GameServices.TileSheet = GameServices.Content.Load<Texture2D>("blocks/tiles");;
        GameServices.ItemSheet = GameServices.Content.Load<Texture2D>("items/sheet");
        GameServices.BoomerangSheet = GameServices.Content.Load<Texture2D>("items/boomerang");

        Vector2 center = new Vector2(GameServices.GameWidth / 2, GameServices.GameHeight / 2);

        link = new Link(linkSheet, center);

        GameServices.Link = link;

        enemyFactory = new EnemyFactory(enemiesSheet, BossesSheet, linkSheet, dustSheet, NPCSheet);

        levelLoader = new LevelLoader();
        currentLevelData = levelLoader.GetCurrentLevel();

        uiManager = new UIManager();
        uiManager.AddElement(new HUDBar(hudElements));
        uiManager.AddElement(new OuterDungeonWalls(outerWallsTexture));
        innerWalls = new InnerDungeonWalls(innerWallsTexture);
        
        // Remove in future.
        // Currnt dependency of collision handling.
        dungeonWalls = new JesseDungeonWalls(innerWallsTexture);
        
        currentLevel = LevelBuilder.Build(levelLoader.GetCurrentLevel(), enemyFactory, dungeonWalls.InnerBounds);

        items = new ItemManager();
        inventory = new Inventory();
        enemyManager = new EnemyManager();
        enemyFactory = new EnemyFactory(enemiesSheet, BossesSheet, linkSheet, dustSheet, NPCSheet);

        // inventory items — D1=Boomerang, D2=Bow, D3=Bomb
        inventory.Add(ItemFactory.CreateBoomerang(Vector2.Zero, Vector2.Zero, maxDistance: 160f));
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bow,  Vector2.Zero, 2));
        inventory.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bomb, Vector2.Zero, 2));

        // Hardcoded world items for testing pickup and collision should be replaced by level-specific placements in the future
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Heart,          new Vector2(126, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.BlueHeart,      new Vector2(222, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.HalfHeart,      new Vector2(366, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.ZeroHeart,      new Vector2(558, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.HeartContainer, new Vector2(654, 270), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Fairy,          new Vector2(222, 318), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Clock,          new Vector2(270, 318), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.GoldRupee,      new Vector2(510, 318), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.PurpleRupee,    new Vector2(654, 318), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.BluePotion,     new Vector2(126, 366), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Map,            new Vector2(270, 366), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Key,            new Vector2(300, 366), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Compass,        new Vector2(558, 366), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bow,            new Vector2(222, 414), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.BlueCandle,     new Vector2(366, 414), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.GoldTriforce,   new Vector2(510, 414), 2));
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
        collisionManager.Add(new LinkBlockCollisionHandler(link, currentLevel.Blocks));
        collisionManager.Add(new LinkItemCollision(link, inventory, currentLevel.WorldItems));
        collisionManager.Add(new ActiveItemEnemyCollision(items, currentLevel.Enemies));
        collisionManager.Add(new LinkEnemyProjectileCollision(link, currentLevel.Enemies));
        collisionManager.Add(new LinkWallCollisionHandler(link, dungeonWalls, HandleDoorExit));
        collisionManager.Add(new EnemyWallCollisionHandler(currentLevel.Enemies.enemyList, dungeonWalls));
        collisionManager.Add(new LinkBlockPushHandler(link, currentLevel.Blocks));
    }

    private void HandleDoorExit(string exitDirection)
    {
        if (currentLevelData.doors == null || !currentLevelData.doors.TryGetValue(exitDirection, out string targetRoom))
        {
            // No connection — push Link back inside
            int s = link.Rect.Width;
            link.Position = exitDirection switch
            {
                "west"  => new Vector2(dungeonWalls.InnerBounds.Left, link.Position.Y),
                "east"  => new Vector2(dungeonWalls.InnerBounds.Right - s, link.Position.Y),
                "north" => new Vector2(link.Position.X, dungeonWalls.InnerBounds.Top),
                "south" => new Vector2(link.Position.X, dungeonWalls.InnerBounds.Bottom - s),
                _       => link.Position
            };
            return;
        }

        currentLevelData = levelLoader.Load(targetRoom);
        currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, dungeonWalls.InnerBounds);

        // Place Link at the entry door opposite to where he exited
        int spriteSize = link.Rect.Width;
        int doorCenterX = (dungeonWalls.TopDoorLeft + dungeonWalls.TopDoorRight) / 2;
        int doorCenterY = (dungeonWalls.SideDoorTop + dungeonWalls.SideDoorBottom) / 2;
        link.Position = exitDirection switch
        {
            "east"  => new Vector2(dungeonWalls.InnerBounds.Left, doorCenterY - spriteSize / 2),
            "west"  => new Vector2(dungeonWalls.InnerBounds.Right - spriteSize, doorCenterY - spriteSize / 2),
            "south" => new Vector2(doorCenterX - spriteSize / 2, dungeonWalls.InnerBounds.Top),
            "north" => new Vector2(doorCenterX - spriteSize / 2, dungeonWalls.InnerBounds.Bottom - spriteSize),
            _       => link.Position
        };

        RebuildCollisionManager();
    }

    public void Update(GameTime gameTime)
    {
        uiManager.Update(gameTime);
        currentLevel.Update(gameTime);
        link.Update(gameTime);
        inventory.Update(gameTime);
        items.Update(gameTime);
        collisionManager.HandleAll();
        inputHandler.HandleInput();

        MouseState mouse = Mouse.GetState();
        if (mouse.RightButton == ButtonState.Pressed && rmbReleased)
        {
            rmbReleased = false;
            currentLevelData = levelLoader.CycleNext();
            currentLevel = LevelBuilder.Build(currentLevelData, enemyFactory, dungeonWalls.InnerBounds);
            RebuildCollisionManager();
        }
        if (mouse.LeftButton == ButtonState.Pressed && lmbReleased)
        {
            lmbReleased = false;
            currentLevelData = levelLoader.CyclePrevious();
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
        link.Draw(spriteBatch);
        inventory.Draw(spriteBatch);
        items.Draw(spriteBatch);
        currentLevel.DrawOnTop(spriteBatch); // Keese on top
        uiManager.Draw(spriteBatch);       // rest of UI (minus DungeonWalls)
    }
}
