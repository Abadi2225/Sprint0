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

public class Game1 : Game, IGameActions
{
<<<<<<< Zelda-UI
    
=======
    private Texture2D credits;
    private Texture2D linkSheet;
    private Texture2D titleSheet;
    private Texture2D enemiesSheet;
    private Texture2D BossesSheet;
    private Texture2D dustSheet;
>>>>>>> main
    private GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;

    private IController keyboard;
    private IController mouse;

    private IGameState currentState;
    private GameServices services;

    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        services = new GameServices
        {
            Content = Content,
            KeyInput = new KeyboardController(this),
            GameActions = this,
            ScaleFactor = 3
        };

        //currentState = new StartScreenState(services);
        currentState = new StartScreenState(services);
        currentState.Enter();

        // Set the window size to be 3 times the original NES resolution (256x224)
        graphics.PreferredBackBufferWidth = services.GameWidth;
        graphics.PreferredBackBufferHeight = services.GameHeight;
    }

    protected override void Initialize()
    {
        mouse = new MouseController(this, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight, services);

        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

<<<<<<< Zelda-UI
        currentState.LoadContent();
=======
        credits = Content.Load<Texture2D>("images/credits");
        linkSheet = Content.Load<Texture2D>("images/Link");
        enemiesSheet = Content.Load<Texture2D>("images/enemiesSheet");
        BossesSheet = Content.Load<Texture2D>("images/BossesSpriteSheet");
        dustSheet = Content.Load<Texture2D>("images/dustSheet");

        titleSheet = Content.Load<Texture2D>("images/Title Screen & Story of Treasures");

        Vector2 center = new Vector2(Window.ClientBounds.Width / 2, Window.ClientBounds.Height / 2);
        enemyManager = new EnemyManager();
        enemyFactory = new EnemyFactory(enemiesSheet, BossesSheet, linkSheet, dustSheet, Content);

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

        // Just shows that it exists
        titleScreen = new TitleScreen(titleSheet, new Rectangle(1, 11, 256, 254));
        uiManager.AddElement(titleScreen);

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
>>>>>>> main
    }

    protected override void Update(GameTime gameTime)
    {
        services.KeyInput.Update();
        
        currentState.Update(gameTime);
        mouse.Update();

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

        spriteBatch.End();
        base.Draw(gameTime);
    }

    public void ChangeState(IGameState newState)
    {
        currentState = newState;
        currentState.LoadContent();
        currentState.Enter();
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
    */

    public void Quit()
    {
        Exit();
    }
}
