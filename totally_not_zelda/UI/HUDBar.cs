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
    private readonly Vector2 HEART_DISPLAY_OFFSET = new Vector2(176, 40) - new Vector2(8, 8);

    private Texture2D texture;
    private StaticSprite background;
    private Rectangle sourceRect;

    public int X { get; set; }
    public int Y { get; set; }

    private Inventory inventory;
    private StaticSprite activeItem;
    private HeartDisplay hearts;
    private TwoDigitDisplay rupees;
    private TwoDigitDisplay keys;
    private TwoDigitDisplay bombs;
    public HudMap Map { get; }

    public HUDBar(int x, int y, Inventory inventory, Texture2D backgroundTexture)
    {
        texture = backgroundTexture;
        X = x;
        Y = y;
        this.inventory = inventory;
        UpdateActiveItem();

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
        hearts = new HeartDisplay(new Vector2(X, Y) + HEART_DISPLAY_OFFSET * GameServices.ScaleFactor, 10);

        Map = new HudMap(
                (int)(X + 16 * GameServices.ScaleFactor),
                Y,
                "12statues",
                LevelLoader.Load("12statues").gridPos,
                LevelLoader.Load("12statues").gridPos,
                30,
                false,
                false,
                1
                );
    }

    public void UpdateActiveItem()
    {
        this.activeItem = ItemHudSprites.GetSprite(
                inventory.Get(inventory.ActiveSlot).Name,
                new Vector2(X, Y) + B_ITEM_OFFSET * GameServices.ScaleFactor
                );
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, background.Position);

        activeItem.Draw(spriteBatch, activeItem.Position);

        hearts.Draw(GameServices.Link.Health, GameServices.Link.MaxHealth, spriteBatch);
        rupees.Draw(spriteBatch);
        keys.Draw(spriteBatch);
        bombs.Draw(spriteBatch);
        Map.Draw(spriteBatch);
    }

    public void Update(GameTime gameTime)
    {
        if (!Map.Enabled && inventory.HasMap)
        {
            Map.Enabled = true;
        }
        if (!Map.ShowTriforceLoc && inventory.HasCompass)
        {
            Map.ShowTriforceLoc = true;
        }
        int linkRupees = GameServices.Link.Rubies;
        rupees.SetNumber(GameServices.Link.Rubies);
        // keys.SetNumber(GameServices.Link.Keys);
        // bombs.SetNumber(GameServices.Link.Bombs);
    }
}
