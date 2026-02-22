using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Character;
using Sprint.Sprites;
using Sprint.Commands;
using System.Collections.Generic;
using Sprint.Block;
using Microsoft.Xna.Framework.Input;
using Sprint.Item;

class GameplayState : IGameState
{
    private Texture2D credits;
    private Texture2D linkSheet;
    private Texture2D enemiesSheet;
    private Texture2D BossesSheet;

    private Link link;
    private GameServices services;
    private Dictionary<Keys, ICommand> pressedKeys;
    private MapManager mapManager;
    private ItemManager items = new ItemManager();

    public GameplayState(GameServices services)
    {
        this.services = services;
    }

    public void LoadContent()
    {
        linkSheet = services.Content.Load<Texture2D>("images/Link");

        Vector2 center = new Vector2(services.GameWidth / 2, services.GameHeight / 2);

        link = new Link(linkSheet, center);

        mapManager = new MapManager(services.Content, new Vector2(100, 50));

        // item test
        items.CreateItem(new Compass(
                    new Vector2(50, 50),
                    services.Content
                    ));
        items.CreateItem(new Boomerang(
                    new Vector2(70, 50),
                    new Vector2(5, 0),
                    services.Content
                    ));
    }

    public void Enter()
    {
        pressedKeys = new Dictionary<Keys, ICommand>
        {
            {Keys.Q, new QuitCommand(services.GameActions)},
            // {Keys.O, new CycleEnemyCommand(this.services, true)},
            // {Keys.P, new CycleEnemyCommand(this.services, false)},
            {Keys.I, new CycleItemCommand(items, true)},
            {Keys.U, new CycleItemCommand(items, false)},
            {Keys.Y, new CycleBlockCommand(mapManager, true)},
            {Keys.T, new CycleBlockCommand(mapManager, false)},
        };
    }

    public void Update(GameTime gameTime)
    {
        link.Update(gameTime);
        items.Update(gameTime);

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
        link.Draw(spriteBatch);
        mapManager.DrawMap(spriteBatch);
        items.DrawActiveItem(spriteBatch);
    }
}