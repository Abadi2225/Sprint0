using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.UI;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint.Commands;

class StartScreenState : IGameState
{

    private UIManager uiManager;
    private Texture2D titleSheet;
    private TitleScreen titleScreen;
    private GameServices services;

    private Dictionary<Keys, ICommand> pressedKeys;

    public StartScreenState(GameServices services)
    {
        this.services = services;

        // UIManager should be initialized before loading content, since LoadContent adds elements to it
        uiManager = new UIManager();
    }

    public void Enter()
    {
        // Set up key bindings
        pressedKeys = new Dictionary<Keys, ICommand>
        {
            {Keys.Q, new QuitCommand(services.GameActions)},
            {Keys.Enter, new SetStateCommand(services.GameActions, new GameplayState(services))}
        };
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

        
        foreach (var binding in pressedKeys)
        {
            if (services.KeyInput.IsKeyPressed(binding.Key))
            {
                binding.Value.Execute();
            }
        }
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        uiManager.Draw(spriteBatch);
    }
}