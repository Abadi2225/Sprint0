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

class GameplayState : IGameState
{
    private Texture2D linkSheet;
    private Texture2D enemiesSheet;
    private Texture2D BossesSheet;
    private Texture2D dustSheet;
    private Texture2D NPCSheet;
    private Texture2D tileSheet;
    private Texture2D dungeonBackground;
    private Texture2D hudElements;

    private Link link;
    private Dictionary<Keys, ICommand> pressedKeys;
    private ItemManager items;
    private EnemyManager enemyManager;
    private EnemyFactory enemyFactory;
    private LevelLoader levelLoader;
    private Level currentLevel;
    private UIManager uiManager;
    private CollisionManager collisionManager;
    // todo delete this
    private bool lmbReleased = true;
    private bool rmbReleased = true;

    public GameplayState()
    {
    }

    public void Exit() { }

    public void Enter()
    {
        pressedKeys = new Dictionary<Keys, ICommand>
        {
            {Keys.Q, new QuitCommand()},
            {Keys.O, new CycleEnemyCommand(enemyManager, true)},
            {Keys.P, new CycleEnemyCommand(enemyManager, false)},
            {Keys.I, new CycleItemCommand(items, true)},
            {Keys.U, new CycleItemCommand(items, false)},
            {Keys.D1, new UseItemCommand(items, link, 0)},
            {Keys.D2, new UseItemCommand(items, link, 1)},
            {Keys.D3, new UseItemCommand(items, link, 2)},
            {Keys.R, new SetStateCommand(new StartScreenState())}
        };

    }

    public void LoadContent()
    {
        linkSheet = GameServices.Content.Load<Texture2D>("images/Link");
        enemiesSheet = GameServices.Content.Load<Texture2D>("images/enemiesSheet");
        BossesSheet = GameServices.Content.Load<Texture2D>("images/BossesSpriteSheet");
        dustSheet = GameServices.Content.Load<Texture2D>("images/dustSheet");
        NPCSheet = GameServices.Content.Load<Texture2D>("images/NPC");
        tileSheet = GameServices.Content.Load<Texture2D>("blocks/tiles");
        dungeonBackground = GameServices.Content.Load<Texture2D>("images/ZeldaDungeonWalls");
        hudElements = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
        GameServices.TileSheet = tileSheet;
        GameServices.ItemSheet = GameServices.Content.Load<Texture2D>("items/sheet");
        GameServices.BoomerangSheet = GameServices.Content.Load<Texture2D>("items/boomerang");

        Vector2 center = new Vector2(GameServices.GameWidth / 2, GameServices.GameHeight / 2);

        link = new Link(linkSheet, center);

        GameServices.Link = link;

        levelLoader = new LevelLoader();
        // currentLevel = LevelBuilder.Build(levelLoader.Load("test_room"));
        currentLevel = LevelBuilder.Build(levelLoader.GetCurrentLevel(), enemyFactory);

        items = new ItemManager();
        enemyManager = new EnemyManager();
        enemyFactory = new EnemyFactory(enemiesSheet, BossesSheet, linkSheet, dustSheet, NPCSheet);
        collisionManager = new CollisionManager();
        collisionManager.Add(new LinkEnemyCollision(link, enemyManager));
        collisionManager.Add(new SwordEnemyCollision(link, enemyManager));
        collisionManager.Add(new EnemyBlockCollisionHandler(enemyManager.enemyList, currentLevel.Blocks));

        currentLevel = LevelBuilder.Build(levelLoader.GetCurrentLevel(), enemyFactory);
        collisionManager.Add(new EnemyBlockCollisionHandler(
            currentLevel.Enemies.enemyList,
            currentLevel.Blocks));
        collisionManager.Add(new LinkItemCollision(link, items, currentLevel.WorldItems));

        // inventory items — D1=Boomerang, D2=Bow, D3=Bomb
        items.Add(ItemFactory.CreateBoomerang(Vector2.Zero, Vector2.Zero, maxDistance: 160f));
        items.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bow,  Vector2.Zero, 2));
        items.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bomb, Vector2.Zero, 2));

        // world item test — walk over these to pick them up
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Heart,      new Vector2(200, 200), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.GoldRupee,  new Vector2(260, 200), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Key,        new Vector2(320, 200), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateStillItem(ItemFactory.StillType.Bow,        new Vector2(380, 200), 2));
        currentLevel.WorldItems.Add(ItemFactory.CreateBoomerang(new Vector2(440, 200), Vector2.Zero, maxDistance: 0));

        uiManager = new UIManager();
        uiManager.AddElement(new DungeonWalls(dungeonBackground));
        uiManager.AddElement(new HUDBar(hudElements));
    }

    public void Update(GameTime gameTime)
    {
        uiManager.Update(gameTime);
        currentLevel.Update(gameTime);
        link.Update(gameTime);
        items.Update(gameTime);
        enemyManager?.Update(gameTime);

        collisionManager.HandleAll();

        if (GameServices.KeyInput.IsKeyDown(Keys.W) || GameServices.KeyInput.IsKeyDown(Keys.Up)) link.SetMove(Directions.Up);
        else if (GameServices.KeyInput.IsKeyDown(Keys.S) || GameServices.KeyInput.IsKeyDown(Keys.Down)) link.SetMove(Directions.Down);
        else if (GameServices.KeyInput.IsKeyDown(Keys.A) || GameServices.KeyInput.IsKeyDown(Keys.Left)) link.SetMove(Directions.Left);
        else if (GameServices.KeyInput.IsKeyDown(Keys.D) || GameServices.KeyInput.IsKeyDown(Keys.Right)) link.SetMove(Directions.Right);
        else link.StopMove();
        if (GameServices.KeyInput.IsKeyDown(Keys.Z) || GameServices.KeyInput.IsKeyDown(Keys.N)) link.StartAttack();
        if (GameServices.KeyInput.IsKeyDown(Keys.E)) link.StartDamaged();
        foreach (var binding in pressedKeys)
        {
            if (GameServices.KeyInput.IsKeyPressed(binding.Key))
            {
                binding.Value.Execute();
            }
        }

        MouseState mouse = Mouse.GetState();
        if (mouse.RightButton == ButtonState.Pressed && rmbReleased)
        {
            rmbReleased = false;
            currentLevel = LevelBuilder.Build(levelLoader.CycleNext(), enemyFactory);
            collisionManager = new CollisionManager();
            collisionManager.Add(new LinkEnemyCollision(link, currentLevel.Enemies));
            collisionManager.Add(new SwordEnemyCollision(link, currentLevel.Enemies));
            collisionManager.Add(new EnemyBlockCollisionHandler(currentLevel.Enemies.enemyList, currentLevel.Blocks));
        }
        if (mouse.LeftButton == ButtonState.Pressed && lmbReleased)
        {
            lmbReleased = false;
            currentLevel = LevelBuilder.Build(levelLoader.CyclePrevious(), enemyFactory);
            collisionManager = new CollisionManager();
            collisionManager.Add(new LinkEnemyCollision(link, currentLevel.Enemies));
            collisionManager.Add(new SwordEnemyCollision(link, currentLevel.Enemies));
            collisionManager.Add(new EnemyBlockCollisionHandler(currentLevel.Enemies.enemyList, currentLevel.Blocks));
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
        uiManager.Draw(spriteBatch);
        currentLevel.Draw(spriteBatch);
        link.Draw(spriteBatch);
        items.Draw(spriteBatch);
    }
}
