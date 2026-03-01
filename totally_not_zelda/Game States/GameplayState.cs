using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Character;
using Sprint;
using Sprint.Sprites;
using Sprint.Commands;
using System;
using System.Collections.Generic;
using Sprint.Block;
using Microsoft.Xna.Framework.Input;
using Sprint.Item;
using Sprint.Enemies;
using Sprint.Levels;

class GameplayState : IGameState
{
    private Texture2D linkSheet;
    private Texture2D enemiesSheet;
    private Texture2D BossesSheet;
    private Texture2D dustSheet;
    private Texture2D NPCSheet;
    private Texture2D tileSheet;

    private Link link;
    private Dictionary<Keys, ICommand> pressedKeys;
    private BlockFactory blockFactory;
    private ItemManager items;
    private EnemyManager enemyManager;
    private EnemyFactory enemyFactory;
    private LevelLoader levelLoader;

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

        Vector2 center = new Vector2(GameServices.GameWidth / 2, GameServices.GameHeight / 2);

        link = new Link(linkSheet, center);

        levelLoader = new LevelLoader();
        blockFactory = new BlockFactory(tileSheet, new Vector2(0, 0));
        blockFactory.Build(levelLoader.Load("test_room"));

        enemyManager = new EnemyManager();
        enemyFactory = new EnemyFactory(enemiesSheet, BossesSheet, linkSheet, dustSheet, NPCSheet);

        // Can make this generated in the enemyFactory if we want to create more enemies
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.Gel, center + new Vector2(100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.Stalfos, center + new Vector2(100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.Keese, center + new Vector2(100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.Aquamentus, center + new Vector2(-100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.Goriya, center + new Vector2(100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.Rope, center + new Vector2(100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.Zol, center + new Vector2(100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.WallMaster, center + new Vector2(100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.Trap, center + new Vector2(100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.Dodongo, center + new Vector2(-100, 0)));
        enemyManager.AddEnemy(enemyFactory.CreateEnemy(EnemyType.OldMan, center + new Vector2(100, 0)));

        // item test
        items = new ItemManager();
        items.Add(ItemFactory.CreateBoomerang(          // slot 0 - D1
                    new Vector2(50, 50),
                    new Vector2(5, 0),
                    maxDistance: 400f
                    ));
        items.Add(ItemFactory.CreateStillItem(          // slot 1 - D2
                    ItemFactory.StillType.Bow,
                    new Vector2(50, 50),
                    0, 2
                    ));
        items.Add(ItemFactory.CreateStillItem(          // slot 2 - D3
                    ItemFactory.StillType.Bomb,
                    new Vector2(50, 50),
                    0, 2
                    ));
        foreach (ItemFactory.StillType type in Enum.GetValues<ItemFactory.StillType>())
        {
            items.Add(ItemFactory.CreateStillItem(
                        type,
                        new Vector2(50, 50),
                        0,
                        2
                        ));
        }
    }

    public void Update(GameTime gameTime)
    {
        link.Update(gameTime);
        items.Update(gameTime);
        enemyManager?.Update(gameTime);

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


    }

    public void Draw(SpriteBatch spriteBatch)
    {
        blockFactory.DrawMap(spriteBatch);
        link.Draw(spriteBatch);
        enemyManager?.Draw(spriteBatch);
        items.Draw(spriteBatch);
    }
}
