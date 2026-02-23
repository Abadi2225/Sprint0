using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Character;
using Sprint.Sprites;
using Sprint.Commands;
using System.Collections.Generic;
using Sprint.Block;
using Microsoft.Xna.Framework.Input;
using Sprint.Item;
using Sprint.Enemies;

class GameplayState : IGameState
{
    private Texture2D linkSheet;
    private Texture2D enemiesSheet;
    private Texture2D BossesSheet;
    private Texture2D dustSheet;
    private Texture2D NPCSheet;

    private Link link;
    private GameServices services;
    private Dictionary<Keys, ICommand> pressedKeys;
    private MapManager mapManager;
    private ItemManager items = new ItemManager();
    private EnemyManager enemyManager;
    private EnemyFactory enemyFactory;

    public GameplayState(GameServices services)
    {
        this.services = services;
    }

    public void Enter()
    {
        pressedKeys = new Dictionary<Keys, ICommand>
        {
            {Keys.Q, new QuitCommand(services.GameActions)},
            {Keys.O, new CycleEnemyCommand(enemyManager, true)},
            {Keys.P, new CycleEnemyCommand(enemyManager, false)},
            {Keys.I, new CycleItemCommand(items, true)},
            {Keys.U, new CycleItemCommand(items, false)},
            {Keys.Y, new CycleBlockCommand(mapManager, true)},
            {Keys.T, new CycleBlockCommand(mapManager, false)},
			{Keys.D1, new UseItemCommand(items, link, 0) },
            {Keys.D2, new UseItemCommand(items, link, 1) },
            //{Keys.D3, new UseItemCommand(items, link, 2) },
            //{Keys.D4, new UseItemCommand(items, link, 3) },
		};
    }

    public void LoadContent()
    {
        linkSheet = services.Content.Load<Texture2D>("images/Link");

        Vector2 center = new Vector2(services.GameWidth / 2, services.GameHeight / 2);

        link = new Link(linkSheet, center);

        mapManager = new MapManager(services.Content, new Vector2(100, 50));

        // item test
        items.CreateItem
        (
            new Compass
            (
                new Vector2(50, 50),
                services.Content
            )
        );
		items.CreateItem
		(
		    new Boomerang(
		        new Vector2(70, 50),
		        new Vector2(5, 0),
		        services.Content
		    )
		);
		items.CreateItem
        (
			new Boomerang(
				link.Position,
				new Vector2(5, 0),
				services.Content
			)
		);

        enemiesSheet = services.Content.Load<Texture2D>("images/enemiesSheet");
        BossesSheet = services.Content.Load<Texture2D>("images/BossesSpriteSheet");
        dustSheet = services.Content.Load<Texture2D>("images/dustSheet");
        NPCSheet = services.Content.Load<Texture2D>("images/NPC");

        enemyManager = new EnemyManager();
        enemyFactory = new EnemyFactory(enemiesSheet, BossesSheet, linkSheet, dustSheet, services.Content, NPCSheet);

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
    }

    public void Update(GameTime gameTime)
    {
        link.Update(gameTime);
        items.Update(gameTime);
        enemyManager?.Update(gameTime);

        if (services.KeyInput.IsKeyDown(Keys.W) || services.KeyInput.IsKeyDown(Keys.Up)) link.SetMove(Directions.Up);
        else if (services.KeyInput.IsKeyDown(Keys.S) || services.KeyInput.IsKeyDown(Keys.Down)) link.SetMove(Directions.Down);
        else if (services.KeyInput.IsKeyDown(Keys.A) || services.KeyInput.IsKeyDown(Keys.Left)) link.SetMove(Directions.Left);
        else if (services.KeyInput.IsKeyDown(Keys.D) || services.KeyInput.IsKeyDown(Keys.Right)) link.SetMove(Directions.Right);
        else link.StopMove();
		if (services.KeyInput.IsKeyDown(Keys.Z) || services.KeyInput.IsKeyDown(Keys.N)) link.StartAttack();
		if (services.KeyInput.IsKeyDown(Keys.E)) link.StartDamaged();
		foreach (var binding in pressedKeys)
        {
            if (services.KeyInput.IsKeyPressed(binding.Key))
            {
                binding.Value.Execute();
            }
        }

	}

    public void Draw(SpriteBatch spriteBatch)
    {
        link.Draw(spriteBatch);
        mapManager.DrawMap(spriteBatch);
        items.DrawActiveItem(spriteBatch);
        enemyManager?.Draw(spriteBatch);
		items.DrawProjectiles(spriteBatch);
	}
}