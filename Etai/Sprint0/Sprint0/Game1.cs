using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;
using System.Collections.Generic;

namespace Sprint0;

public class Game1 : Core
{
    private ISprite currentSprite;
    private List<IController> controllers = new List<IController>();
    private Texture2D _texture;
    Rectangle[] walkingFrames;

    ISprite staticSprite;
    ISprite animatedSprite;
    ISprite movingSprite;
    ISprite movingAnimatedSprite;

    Dictionary<Keys, ICommand> keyboardBindings;
    ICommand[] mouseCommands;

    SpriteFont font;
    ISprite textSprite;

    public Game1() : base("Sprint0", 1280, 720, true)
    {
        
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();

        controllers.Add(new KeyboardController(keyboardBindings));
        controllers.Add(new MouseController(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, mouseCommands));
    }

    protected override void LoadContent()
    {

        // TODO: use this.Content to load your game content here
        _texture = Content.Load<Texture2D>("Images/Link_Spritesheet");
        walkingFrames = new Rectangle[]
        {
            new Rectangle(1, 11, 16, 16),
            new Rectangle(18, 11, 16, 16)
        };

        CreateSprites();

        keyboardBindings = new Dictionary<Keys, ICommand>
        {
            { Keys.D1, new SetSpriteCommand(this, staticSprite) },
            { Keys.D2, new SetSpriteCommand(this, animatedSprite) },
            { Keys.D3, new SetSpriteCommand(this, movingSprite) },
            { Keys.D4, new SetSpriteCommand(this, movingAnimatedSprite) },
            { Keys.Escape, new QuitCommand(this) }
        };

        mouseCommands = new ICommand[]
        {
            new SetSpriteCommand(this, staticSprite),
            new SetSpriteCommand(this, animatedSprite),
            new SetSpriteCommand(this, movingSprite),
            new SetSpriteCommand(this, movingAnimatedSprite),
            new QuitCommand(this)
        };

        font = Content.Load<SpriteFont>("Fonts/FontPlz");

        textSprite = new TextSprite(
            font,
            "Etai Norris\nSprites from: https://www.spriters-resource.com/nes/legendofzelda/",
            new Vector2(50, 50)
        );

        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {

        // TODO: Add your update logic here
        foreach (var controller in controllers)
        {
            controller.Update();
        }

        currentSprite.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        SpriteBatch.Begin();
        currentSprite.Draw(SpriteBatch);
        textSprite.Draw(SpriteBatch);
        SpriteBatch.End();

        base.Draw(gameTime);
    }

    public void SetCurrentSprite(ISprite newSprite)
    {
        currentSprite = newSprite;
    }

    private void CreateSprites()
    {
        staticSprite = new StaticSprite(_texture, new Vector2(500, 300), new Rectangle(1, 11, 16, 16));
        animatedSprite = new AnimatedSprite(_texture, new Vector2(500, 300), walkingFrames);
        movingSprite = new MovingSprite(_texture, new Vector2(500, 300), new Rectangle(1, 11, 16, 16));
        movingAnimatedSprite = new MovingAnimatedSprite(_texture, new Vector2(500, 300), walkingFrames);

        currentSprite = staticSprite; // initial state (key 1)
    }
}