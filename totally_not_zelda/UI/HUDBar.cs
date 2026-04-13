using Sprint.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;
using Microsoft.Xna.Framework;
using Sprint.UI.Hud;
using Sprint.Item;

namespace Sprint.UI;

class HUDBar : IUIElement
{
    private static readonly Vector2 CROP = new Vector2(0, 8);
    private static readonly Vector2 B_ITEM_OFFSET = new Vector2(128, 24) - CROP;
    private static readonly Vector2 HEART_DISPLAY_OFFSET = new Vector2(176, 40) - CROP;

    private Texture2D texture;
    private StaticSprite background;
    private Rectangle sourceRect = new Rectangle((int)(258 + CROP.X), (int)(11 + CROP.Y), 256, 48);

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

        background = new StaticSprite(texture, new Vector2(X, Y), sourceRect);

        Vector2 origin = new Vector2(X, Y);
        rupees = new TwoDigitDisplay(
            origin + (new Vector2(96, 16) - CROP) * GameServices.ScaleFactor,
            origin + (new Vector2(96 + 8, 16) - CROP) * GameServices.ScaleFactor,
            origin + (new Vector2(96 + 16, 16) - CROP) * GameServices.ScaleFactor
        );

        keys = new TwoDigitDisplay(
            new Vector2(X + 96 * GameServices.ScaleFactor, Y + 24 * GameServices.ScaleFactor),
            new Vector2(X + 104 * GameServices.ScaleFactor, Y + 24 * GameServices.ScaleFactor),
            new Vector2(X + 112 * GameServices.ScaleFactor, Y + 24 * GameServices.ScaleFactor)
        );

        bombs = new TwoDigitDisplay(
            new Vector2(X + 96 * GameServices.ScaleFactor, Y + 32 * GameServices.ScaleFactor),
            new Vector2(X + 104 * GameServices.ScaleFactor, Y + 32 * GameServices.ScaleFactor),
            new Vector2(X + 112 * GameServices.ScaleFactor, Y + 32 * GameServices.ScaleFactor)
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
        keys.SetNumber(GameServices.Link.Keys);
        // bombs.SetNumber(GameServices.Link.Bombs);
    }
}
