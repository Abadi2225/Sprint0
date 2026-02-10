using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using sprint0.Controllers;
using sprint0.Interfaces;
using sprint0.Sprites;

namespace sprint0;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private ISprite currentSprite;
    private ISprite textSprite;
    private IController _keyboardController;
    private IController _mouseController;
    private Texture2D _image;
    private Vector2 window;
    private SpriteFont _font;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        window = new Vector2(Window.ClientBounds.Width, Window.ClientBounds.Height);
        _keyboardController = new KeyboardController();
        _mouseController = new MouseController(window);
        currentSprite = new StaticSprite();
        textSprite = new TextSprite();
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        _image = Content.Load<Texture2D>("images/TLZ");
        _font = Content.Load<SpriteFont>("fonts/myFont");
    }
    
    public void SetCurrentSprite(ISprite sprite)
    {
        currentSprite = sprite;
    }

    protected override void Update(GameTime gameTime)
    {
        _keyboardController.Update(gameTime, this);
        _mouseController.Update(gameTime, this);
        currentSprite.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        currentSprite.Draw(gameTime, _spriteBatch, _image, window, _font);
        textSprite.Draw(gameTime, _spriteBatch, _image, window, _font);
        _spriteBatch.End();

        base.Draw(gameTime);
    }

}
