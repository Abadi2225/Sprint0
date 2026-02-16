using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint.Interfaces;
using Sprint.Controllers;
using Sprint.Sprites;
using Sprint.Character;

namespace Sprint;

public class Game1 : Game
{
    private Texture2D credits;
    private Texture2D linkSheet;
    private GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;

    private IController keyboard;

    private IController mouse;

    private GameState currState;
    private ISprite currSprite;

     private ISprite staticSprite;
    private ISprite animatedSprite;
    private ISprite movingSprite;
    private ISprite movingAnimatedSprite;

    private Link link;

    public Game1()
    {
        graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        currState = GameState.StaticNonAnimated;
    }

    protected override void Initialize()
    {
        //keyboard = new KeyboardController(this);
        //mouse = new MouseController(this, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);

        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

        linkSheet = Content.Load<Texture2D>("images/Link");

        Vector2 center = new Vector2(Window.ClientBounds.Width / 4, Window.ClientBounds.Height / 4);

        link = new Link(linkSheet, center);
    }

    protected override void Update(GameTime gameTime)
    {
        link.Update(gameTime);
		base.Update(gameTime);
	}

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        spriteBatch.Begin();
        
        link.Draw(spriteBatch);

        spriteBatch.End();

        base.Draw(gameTime);

	}


    public void SetState(GameState newState)
    {
        //currState = newState;

        //switch (currState)
        //    {
        //        case GameState.StaticNonAnimated:
        //            currSprite = staticSprite;
        //            break;

        //        case GameState.StaticAnimated:
        //            currSprite = animatedSprite;
        //            break;

        //        case GameState.MovingNonAnimated:
        //            currSprite = movingSprite;
        //            break;

        //        case GameState.MovingAnimated:
        //            currSprite = movingAnimatedSprite;
        //            break;
        //    }        
    }

    public GameState GetCurrentState()
    {
        return currState;
    }
}
