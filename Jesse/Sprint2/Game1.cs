using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Sprint.Interfaces;
using Sprint.Controllers;
using Sprint.Sprites;
using Sprint.UI;
using Sprint.Enemies;
using Sprint.Enemies.Concrete;
using Sprint.Item;
using Sprint.Block;
using System.Runtime.InteropServices.Marshalling;
using System.ComponentModel;

namespace Sprint;

public class Game1 : Game, IGameActions
{
    private GraphicsDeviceManager graphics;
    private SpriteBatch spriteBatch;

    private IController mouse;

    private IGameState currentState;
    private GameServices services;

    public Game1()
    {
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

        //currentState = new StartScreenState(services);
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
        // Changed to remove the brouder from the sprites, might result in pixelation when scalling.
        spriteBatch.Begin(
            SpriteSortMode.Deferred,
            BlendState.AlphaBlend,
            SamplerState.PointClamp,  // No interpolation
            null, null
        );

        GraphicsDevice.Clear(Color.CornflowerBlue);

        currentState.Draw(spriteBatch);

        spriteBatch.End();
        base.Draw(gameTime);
    }

    public void ChangeState(IGameState newState)
    {
        currentState = newState;
        currentState.LoadContent();
        currentState.Enter();
    }

    /*
    public GameState GetCurrentState()
    {
        return currState;
    }

    public EnemyManager GetEnemyManager()
    {
        return enemyManager;
    }

    internal ItemManager GetItemManager()
    {
        return items;
    }
    */

    public void Quit()
    {
        Exit();
    }
}
