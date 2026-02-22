using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.UI;

class StartScreenState : IGameState
{

    private UIManager uiManager;
    private Texture2D titleSheet;
    private TitleScreen titleScreen;
    private GameServices services;

    public StartScreenState(GameServices services)
    {
        this.services = services;

        // UIManager should be initialized before loading content, since LoadContent adds elements to it
        uiManager = new UIManager();
    }

    public void LoadContent()
    {
        titleSheet = services.Content.Load<Texture2D>("images/Title Screen & Story of Treasures");

        // Just shows that it exists
        titleScreen = new TitleScreen(titleSheet);
        uiManager.AddElement(titleScreen);
    }

    public void Update(GameTime gameTime)
    {
        uiManager.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        uiManager.Draw(spriteBatch);
    }
}