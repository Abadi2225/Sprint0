using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint.Interfaces;
using Sprint.Controllers;
using Sprint.Sprites;
using Sprint.UI;
using Sprint.Character;
using Sprint.Enemies;
using Sprint.Enemies.Concrete;
using Sprint.Item;
using Sprint.Block;
using System.Runtime.InteropServices.Marshalling;
using System.ComponentModel;

namespace Sprint;

public class Game1 : Game
{
    private Texture2D credits;
    private Texture2D linkSheet;
    private Texture2D titleSheet;
    private Texture2D enemiesSheet;
    private Texture2D BossesSheet;
    private GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;

    private IController keyboard;
    private IController mouse;

    private GameState currState;

    private Link link;

    private EnemyManager enemyManager;
    private EnemyFactory enemyFactory;

    private ItemManager items = new ItemManager();
    private MapManager mapManager;

    private IGameState currentState;

    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        currState = GameState.Test;
        currentState = new StartScreenState();

        // Set the window size to be 3 times the original NES resolution (256x224)
        int scaleFactor = 3;
        int gameWidth = 256 * scaleFactor;
        int gameHeight = 224 * scaleFactor;
        graphics.PreferredBackBufferWidth = gameWidth;
        graphics.PreferredBackBufferHeight = gameHeight;
    }

    protected override void Initialize()
    {
        keyboard = new KeyboardController(this);
        mouse = new MouseController(this, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);

        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

        currentState.LoadContent(Content);

        /*
        credits = Content.Load<Texture2D>("images/credits");
        linkSheet = Content.Load<Texture2D>("images/Link");
        enemiesSheet = Content.Load<Texture2D>("images/enemiesSheet");
        BossesSheet = Content.Load<Texture2D>("images/BossesSpriteSheet");

        Vector2 center = new Vector2(Window.ClientBounds.Width / 2, Window.ClientBounds.Height / 2);
        enemyManager = new EnemyManager();
        enemyFactory = new EnemyFactory(enemiesSheet, BossesSheet);

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

        SetState(currState);

        link = new Link(linkSheet, center);

        // item test
        items.CreateItem(new Compass(
                    new Vector2(50, 50),
                    Content
                    ));
        items.CreateItem(new Boomerang(
                    new Vector2(70, 50),
                    new Vector2(5, 0),
                    Content
                    ));
        mapManager = new MapManager(Content, new Vector2(100, 50));

        */
    }

    protected override void Update(GameTime gameTime)
    {
        currentState.Update(gameTime);
        keyboard.Update();
        mouse.Update();

        /*
        enemyManager?.Update(gameTime);

        link.Update(gameTime);
        items.Update(gameTime);
        */

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {

        // Changed to remove the brouder from the sprites, might result in pixelation when scalling.
        spriteBatch.Begin(
            SpriteSortMode.Deferred,
            BlendState.AlphaBlend,
            SamplerState.PointClamp,  // No interpolation
            null, null
        );

        currentState.Draw(spriteBatch);

        /*
        float creditsScale = 0.3f;
        float creditsX = (Window.ClientBounds.Width - credits.Width * creditsScale) / 2;
        float creditsY = Window.ClientBounds.Height - credits.Height * creditsScale - 10;

        spriteBatch.Draw(credits,
        new Vector2(creditsX, creditsY),
        null,
        Color.White,
        0f,
        Vector2.Zero,
        creditsScale,
        SpriteEffects.None,
        0f);

        GraphicsDevice.Clear(Color.CornflowerBlue);

        link.Draw(spriteBatch);

        enemyManager?.Draw(spriteBatch);

        items.DrawActiveItem(spriteBatch);

        mapManager.DrawMap(spriteBatch);

        

        */

        spriteBatch.End();
        base.Draw(gameTime);
    }

    public void changeState(IGameState newState)
    {
        currentState = newState;
        currentState.LoadContent(Content);
    }


    public void SetState(GameState newState)
    {

        switch (currState)
        {
            case GameState.Test:
                break;

            case GameState.Running:
                break;

            case GameState.StartScreen:
                break;

            case GameState.Pause:
                break;

            case GameState.Inventory:
                break;
        }
    }

    public GameState GetCurrentState()
    {
        return currState;
    }

    public EnemyManager GetEnemyManager()
    {
        return enemyManager;
    }

    public ItemManager GetItemManager()
    {
        return items;
    }
    internal MapManager GetMapManager()
    {
        return mapManager;
    }
}
