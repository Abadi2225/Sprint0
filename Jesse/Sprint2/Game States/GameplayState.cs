using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Character;

class GameplayState : IGameState
{
    private Texture2D credits;
    private Texture2D linkSheet;
    private Texture2D enemiesSheet;
    private Texture2D BossesSheet;

    private Link link;
    private GameServices services;

    public GameplayState(GameServices services)
    {
        this.services = services;
    }

    public void LoadContent()
    {
        linkSheet = services.Content.Load<Texture2D>("images/Link");

        Vector2 center = new Vector2(services.GameWidth / 2, services.GameHeight / 2);

        link = new Link(linkSheet, center);
    }

    public void Update(GameTime gameTime)
    {
        link.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        link.Draw(spriteBatch);
    }
}