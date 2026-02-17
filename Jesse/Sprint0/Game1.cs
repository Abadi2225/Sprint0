using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint.Interfaces;
using Sprint.Controllers;
using Sprint.Sprites;
using Sprint.UI;
using Sprint.Character;

namespace Sprint;

public class Game1 : Game
{
    private Texture2D credits;
    private Texture2D linkSheet;
    private Texture2D titleSheet;
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

    private UIManager uiManager;
    private TitleScreen titleScreen;
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
        keyboard = new KeyboardController(this);
        mouse = new MouseController(this, graphics.PreferredBackBufferWidth, graphics.PreferredBackBufferHeight);

        uiManager = new UIManager();

        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);

        credits = Content.Load<Texture2D>("images/credits");
        linkSheet = Content.Load<Texture2D>("images/Link");

        titleSheet = Content.Load<Texture2D>("images/Title Screen & Story of Treasures");

        Vector2 center = new Vector2(Window.ClientBounds.Width / 2, Window.ClientBounds.Height / 2);

        staticSprite = new StaticSprite(linkSheet, center, new Rectangle(0, 11, 16, 16));

        animatedSprite = new AnimatedSprite(linkSheet, center, new int[] { 0, 17 }, 11, 16, 16, 0.2f);

        movingSprite = new MovingSprite(linkSheet, center, new int[] { 68, 85 }, 11, 16, 16, 0.2f);

        movingAnimatedSprite = new MovingAnimatedSprite(linkSheet, center, new int[] { 34, 51 }, 11, 16, 16, 0.2f);


        titleScreen = new TitleScreen(titleSheet, new Rectangle(1, 11, 256, 254));
        uiManager.AddElement(titleScreen);

        SetState(currState);

        link = new Link(linkSheet, center);
    }

    protected override void Update(GameTime gameTime)
    {
        keyboard.Update();
        mouse.Update();

        if (currSprite != null)
        {
            currSprite.Update(gameTime);
        }

        uiManager.Update(gameTime);

        base.Update(gameTime);
        link.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        float creditsScale = 0.3f;
        float creditsX = (Window.ClientBounds.Width - credits.Width * creditsScale) / 2;
        float creditsY = Window.ClientBounds.Height - credits.Height * creditsScale - 10;

        spriteBatch.Begin();

        spriteBatch.Draw(credits,
        new Vector2(creditsX, creditsY),
        null,
        Color.White,
        0f,
        Vector2.Zero,
        creditsScale,
        SpriteEffects.None,
        0f);

        if (currSprite != null)
        {
            currSprite.Draw(spriteBatch, currSprite.Position);
        }

        uiManager.Draw(spriteBatch);

        GraphicsDevice.Clear(Color.CornflowerBlue);


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
