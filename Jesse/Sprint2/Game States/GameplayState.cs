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
    }

    public void Enter()
    {
        pressedKeys = new Dictionary<Keys, ICommand>
        {
            {Keys.Q, new QuitCommand(services.GameActions)},
            // {Keys.O, new CycleEnemyCommand(this.services, true)},
            // {Keys.P, new CycleEnemyCommand(this.services, false)},
            // {Keys.I, new CycleItemCommand(this.services, true)},
            // {Keys.U, new CycleItemCommand(this.services, false)},
            {Keys.Y, new CycleBlockCommand(mapManager, true)},
            {Keys.T, new CycleBlockCommand(mapManager, false)},
        };
    }

    public void Update(GameTime gameTime)
    {
        link.Update(gameTime);

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
    }
}