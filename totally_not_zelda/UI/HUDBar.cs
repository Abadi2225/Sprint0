using Sprint.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Microsoft.Xna.Framework;
using Sprint.UI.Hud;
using Sprint.Item;

namespace Sprint.UI;

class HUDBar : IUIElement
{
    private readonly Vector2 B_ITEM_OFFSET = new Vector2(128, 16);

    private Texture2D texture;
    private StaticSprite background;
    private Rectangle sourceRect;

    public int X { get; set; }
    public int Y { get; set; }

    public IItem ActiveItem { get; set; }
    private HeartDisplay hearts;
    private TwoDigitDisplay rupees;
    private TwoDigitDisplay keys;
    private TwoDigitDisplay bombs;
    public HudMap Map { get; }

    public HUDBar(int x, int y, IItem activeItem, Texture2D backgroundTexture)
    {
        texture = backgroundTexture;
        X = x;
        Y = y;
        ActiveItem = activeItem;

        sourceRect = new Rectangle(258, 19, 256, 48);
        background = new StaticSprite(texture, new Vector2(X, Y), sourceRect);

        rupees = new TwoDigitDisplay(
            new Vector2(X + 96 * GameServices.ScaleFactor, Y + 8 * GameServices.ScaleFactor),
            new Vector2(X + 104 * GameServices.ScaleFactor, Y + 8 * GameServices.ScaleFactor),
            new Vector2(X + 112 * GameServices.ScaleFactor, Y + 8 * GameServices.ScaleFactor),
            texture
        );

        keys = new TwoDigitDisplay(
            new Vector2(X + 96 * GameServices.ScaleFactor, Y + 24 * GameServices.ScaleFactor),
            new Vector2(X + 104 * GameServices.ScaleFactor, Y + 24 * GameServices.ScaleFactor),
            new Vector2(X + 112 * GameServices.ScaleFactor, Y + 24 * GameServices.ScaleFactor),
            texture
        );

        bombs = new TwoDigitDisplay(
            new Vector2(X + 96 * GameServices.ScaleFactor, Y + 32 * GameServices.ScaleFactor),
            new Vector2(X + 104 * GameServices.ScaleFactor, Y + 32 * GameServices.ScaleFactor),
            new Vector2(X + 112 * GameServices.ScaleFactor, Y + 32 * GameServices.ScaleFactor),
            texture
        );
        hearts = new HeartDisplay(new Vector2(X + 505, Y + 100), 10);

        Map = new HudMap(
                (int)(X + 16 * GameServices.ScaleFactor),
                Y,
                "template",
                58,
                58,
                30,
                true,
                true,
                1
                );
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, background.Position);

        // draw active item in inventory and hud at the same time
        Vector2 prev = ActiveItem.Position;
        ActiveItem.Position = new Vector2(X, Y) + B_ITEM_OFFSET * GameServices.ScaleFactor;
        ActiveItem.Draw(spriteBatch, Vector2.Zero);
        ActiveItem.Position = prev;

        hearts.Draw(GameServices.Link.Health, GameServices.Link.MaxHealth, spriteBatch);
        rupees.Draw(spriteBatch);
        keys.Draw(spriteBatch);
        bombs.Draw(spriteBatch);
        Map.Draw(spriteBatch);
    }

    public void Update(GameTime gameTime)
    {
        int linkRupees = GameServices.Link.Rubies;
        rupees.SetNumber(GameServices.Link.Rubies);
        // keys.SetNumber(GameServices.Link.Keys);
        // bombs.SetNumber(GameServices.Link.Bombs);
    }
}
