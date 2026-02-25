using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint.Interfaces;
using Sprint.Controllers;
using Sprint.Sprites;
using Sprint.UI;
using Sprint.Enemies;
using Sprint.Enemies.Concrete;
using Sprint.Item;
using Sprint.Block;

namespace Sprint;

public class Game1 : Game, IGameActions
{
    public static Game1 Instance { get; private set; }

    private GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;

    private IController mouse;

    private IGameState currentState;
    private GameServices services;

    public Game1()
    {
        Instance = this;

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

        currentState.LoadContent();
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
        GraphicsDevice.Clear(Color.CornflowerBlue);
        
        spriteBatch.Begin(
            SpriteSortMode.Deferred,
            BlendState.AlphaBlend,
            SamplerState.PointClamp,
            null, null
        );

        currentState.Draw(spriteBatch);

        spriteBatch.End();
        base.Draw(gameTime);
    }

    public void ChangeState(IGameState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.LoadContent();
        currentState.Enter();
    }

    public static void Quit()
    {
        Instance.Exit();
    }
}