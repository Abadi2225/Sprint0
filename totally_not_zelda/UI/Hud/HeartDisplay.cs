using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Item;
namespace Sprint.UI.Hud;

class HeartDisplay
{
    private static readonly float HEART_WIDTH = 8f;
    private static readonly float GAP = 0.25f;
    private static readonly float SCALE = 3f;

    private Vector2 origin;
    int capacity;
    private List<StillItem> emptyHearts;
    private List<StillItem> halfHearts;
    private List<StillItem> fullHearts;

    public HeartDisplay(Vector2 origin, int capacity)
    {
        this.origin = origin;
        this.capacity = capacity;
        emptyHearts = new List<StillItem>(capacity);
        halfHearts = new List<StillItem>(capacity);
        fullHearts = new List<StillItem>(capacity);
        for (int i = 0; i < this.capacity; i++)
        {
            Vector2 pos = new Vector2(
                    this.origin.X + i * (HEART_WIDTH + GAP) * SCALE,
                    this.origin.Y
                    );
            emptyHearts.Add(ItemFactory.CreateStillItem(
                        ItemFactory.StillType.ZeroHeart,
                        pos,
                        scale: SCALE
                        ));
            halfHearts.Add(ItemFactory.CreateStillItem(
                        ItemFactory.StillType.HalfHeart,
                        pos,
                        scale: SCALE
                        ));
            fullHearts.Add(ItemFactory.CreateStillItem(
                        ItemFactory.StillType.Heart,
                        pos,
                        scale: SCALE
                        ));
        }
    }

    public void Draw(int health, int maxHealth, SpriteBatch sb)
    {
        bool halfHeart = (health % 2) == 1;
        int hearts = health / 2;
        int maxHearts = maxHealth / 2;

        Vector2 dummy = Vector2.Zero;
        for (int i = 1; i <= maxHearts; i++)
        {
            if (i <= hearts)
            {
                fullHearts[i].Draw(sb, dummy);
                continue;
            }
            if (halfHeart && i == hearts + 1)
            {
                halfHearts[i].Draw(sb, dummy);
                continue;
            }
            emptyHearts[i].Draw(sb, dummy);
        }
    }
}
