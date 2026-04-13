using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Item;
using Sprint.Sprites;
namespace Sprint.UI.Hud;

class HeartDisplay
{
    private static readonly float HEART_WIDTH = 8f;
    private static readonly float GAP = 0f;

    private static readonly Texture2D spriteSheet = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
    private static readonly Rectangle emptyHeartMask = new Rectangle(627, 117, 8, 8);
    private static readonly Rectangle halfHeartMask = new Rectangle(636, 117, 8, 8);
    private static readonly Rectangle fullHeartMask = new Rectangle(645, 117, 8, 8);


    private Vector2 origin;
    int capacity;
    private List<StaticSprite> emptyHearts;
    private List<StaticSprite> halfHearts;
    private List<StaticSprite> fullHearts;

    public HeartDisplay(Vector2 origin, int capacity)
    {
        this.origin = origin;
        this.capacity = capacity;
        emptyHearts = new List<StaticSprite>(capacity);
        halfHearts = new List<StaticSprite>(capacity);
        fullHearts = new List<StaticSprite>(capacity);
        for (int i = 0; i < this.capacity; i++)
        {
            Vector2 pos = new Vector2(
                    this.origin.X + i * (HEART_WIDTH + GAP) * GameServices.ScaleFactor,
                    this.origin.Y
                    );
            emptyHearts.Add(
                    new StaticSprite(
                        spriteSheet,
                        pos,
                        emptyHeartMask
                        ));
            halfHearts.Add(
                    new StaticSprite(
                        spriteSheet,
                        pos,
                        halfHeartMask
                        ));
            fullHearts.Add(
                    new StaticSprite(
                        spriteSheet,
                        pos,
                        fullHeartMask
                        ));
        }
    }

    public void Draw(int health, int maxHealth, SpriteBatch sb)
    {
        bool halfHeart = (health % 2) == 1;
        int hearts = health / 2;
        int maxHearts = maxHealth / 2;

        for (int i = 1; i <= maxHearts; i++)
        {
            if (i <= hearts)
            {
                fullHearts[i].Draw(sb, fullHearts[i].Position);
                continue;
            }
            if (halfHeart && i == hearts + 1)
            {
                halfHearts[i].Draw(sb, halfHearts[i].Position);
                continue;
            }
            emptyHearts[i].Draw(sb, emptyHearts[i].Position);
        }
    }
}
