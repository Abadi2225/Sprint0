using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint.Interfaces;
using Sprint.Controllers;
using Sprint.Sprites;
using Sprint.UI;
using Sprint.Enemies;
using Sprint.Enemies.Concrete;
using Sprint.Item;
using Sprint.Block;
using System.Runtime.InteropServices.Marshalling;
using System.ComponentModel;

namespace Sprint;

public class Game1 : Game
{
    
    private GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;

    private IController keyboard;
    private IController mouse;

    //private EnemyManager enemyManager;
    //private EnemyFactory enemyFactory;

    //private ItemManager items = new ItemManager();
    //private MapManager mapManager;

    private IGameState currentState;

    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        GameServices services = new GameServices
        {
            Content = Content,
            GraphicsDevice = GraphicsDevice,
            ScaleFactor = 3
        };

        //currentState = new StartScreenState(services);
        currentState = new GameplayState(services);

        // Set the window size to be 3 times the original NES resolution (256x224)
        graphics.PreferredBackBufferWidth = services.GameWidth;
        graphics.PreferredBackBufferHeight = services.GameHeight;
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

        currentState.LoadContent();

        /*
        credits = Content.Load<Texture2D>("images/credits");
        enemiesSheet = Content.Load<Texture2D>("images/enemiesSheet");
        BossesSheet = Content.Load<Texture2D>("images/BossesSpriteSheet");

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

        GraphicsDevice.Clear(Color.CornflowerBlue);

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
        currentState.LoadContent();
    }

    /*
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

    */
}
