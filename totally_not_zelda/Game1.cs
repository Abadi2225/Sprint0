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

    // private IController mouse;

    private IGameState currentState;

    public Game1()
    {
        Instance = this;

        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        currentState = new StartScreenState();
        currentState.Enter();

        // Set the window size to be 3 times the original NES resolution (256x224)
        graphics.PreferredBackBufferWidth = GameServices.GameWidth;
        graphics.PreferredBackBufferHeight = GameServices.GameHeight;
    }

    protected override void Initialize()
    {
        // mouse = new MouseController(this, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight, services);
        
        // Initialize GameServices
        GameServices.GameActions = this;
        GameServices.Content = Content;

        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

        currentState.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        GameServices.KeyInput.Update();

        currentState.Update(gameTime);
        // mouse.Update();

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

    public void Quit()
    {
        Exit();
    }
}