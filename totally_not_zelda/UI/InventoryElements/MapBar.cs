using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;

namespace Sprint.UI.InventoryElements;

internal class MapBar
{
    private static readonly Vector2 MAP_ITEM_OFFSET = new Vector2(48, 24);
    private static readonly Vector2 COMPASS_ITEM_OFFSET = new Vector2(44, 64);
    private static readonly Texture2D spriteSheet = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
    private static readonly Rectangle frameMask = new Rectangle(258, 112, 256, 88);
    private static readonly Rectangle mapItemMask = new Rectangle(601, 156, 8, 16);
    private static readonly Rectangle compassMask = new Rectangle(612, 156, 15, 16);

    private StaticSprite frame;
    private StaticSprite mapItem;
    private StaticSprite compassItem;
    private InventoryMap map;
    private bool hasCompass;

    public bool Enabled { get; private set; }

    public int X { get; set; }
    public int Y { get; set; }

    public MapBar(int x, int y, InventoryMap map, bool enabled, bool hasCompass)
    {
        X = x;
        Y = y;
        this.hasCompass = hasCompass;
        frame = new StaticSprite(
                spriteSheet,
                new Vector2(X, Y),
                frameMask
                );
        mapItem = new StaticSprite(
                spriteSheet,
                new Vector2(X, Y) + MAP_ITEM_OFFSET * GameServices.ScaleFactor,
                mapItemMask
                );
        compassItem = new StaticSprite(
                spriteSheet,
                new Vector2(X, Y) + COMPASS_ITEM_OFFSET * GameServices.ScaleFactor,
                compassMask
                );

        this.map = map;
        this.map.SetPosition(x, y);

        SetEnabled(enabled);
    }

    public void SetEnabled(bool enabled)
    {
        Enabled = enabled;
        map.Enabled = enabled;
    }

    public void Draw(SpriteBatch sb)
    {
        frame.Draw(sb, frame.Position);
        map.Draw(sb);
        if (Enabled)
        {
            mapItem.Draw(sb, mapItem.Position);
        }
        if (hasCompass)
        {
            compassItem.Draw(sb, compassItem.Position);
        }
    }
}
