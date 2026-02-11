using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TheLegendOfZilda
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _texture;

		private Dictionary<int, ISprite> sprites;
		private ISprite currentSprite;
		private IController mouseController;
        private IController keyboardController;

		private ISprite textSprite;
		public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

		public void SetSprite(int id)
		{
			currentSprite = sprites[id];
		}

		protected override void Initialize()
        {

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _texture = Content.Load<Texture2D>("mario");
			ISprite staticSprite = new OriginalSprite(_texture, GraphicsDevice.Viewport);    
			ISprite animatedSprite = new AnimatedSprite(_texture, GraphicsDevice.Viewport);        
			ISprite movingSprite = new MovingSprite(_texture, GraphicsDevice.Viewport);          
			ISprite movingAnimatedSprite = new MovingAnimatedSprite(_texture, GraphicsDevice.Viewport);
			SpriteFont font = Content.Load<SpriteFont>("Font");
			textSprite = new TextSprite(font);

			sprites = new Dictionary<int, ISprite>
            {
                {1, staticSprite},
                {2, animatedSprite},
                {3, movingSprite},
                {4, movingAnimatedSprite}
            };

			currentSprite = sprites[1];

			keyboardController = new KeyboardController(this);
            mouseController = new MouseController(this);



		}

		protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


			keyboardController.Update(gameTime);
			mouseController.Update(gameTime);
			currentSprite.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

  
            _spriteBatch.Begin();
            currentSprite.Draw(_spriteBatch);
			textSprite.Draw(_spriteBatch);
			_spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
