using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.UI;
using Sprint;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint.Commands;
using Sprint.InputHandling;

class MenuState : IGameState
{

    private UIManager uiManager;
    private Texture2D titleSheet;
    private TitleScreen titleScreen;
    private MenuInputHandler inputHandler;

    public MenuState()
    {

        // UIManager should be initialized before loading content, since LoadContent adds elements to it
        uiManager = new UIManager();
    }

    public void Exit() { }

    public void Enter()
    {
        inputHandler = new MenuInputHandler();
    }

    public void LoadContent()
    {
        titleSheet = GameServices.Content.Load<Texture2D>("images/Title Screen & Story of Treasures");

        // Just shows that it exists
        titleScreen = new TitleScreen(titleSheet);
        uiManager.AddElement(titleScreen);
    }

    public void Update(GameTime gameTime)
    {
        uiManager.Update(gameTime);
        inputHandler.HandleInput();
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        uiManager.Draw(spriteBatch);
    }
}