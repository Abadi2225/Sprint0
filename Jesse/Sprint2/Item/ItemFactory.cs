using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Item;

internal class ItemFactory
{
    public enum StillType
    {
        Heart,
        HeartContainer,
        Fairy,
        Clock,
        Rupee,
        BluePotion,
        Map,
        Bomb,
        Bow,
        BlueCandle,
        Key,
        Compass,
        Triforce
    }
    ContentManager contentManager;
    public ItemFactory(ContentManager contentManager)
    {
        this.contentManager = contentManager;
    }

    public Boomerang CreateBoomerang(Vector2 pos, Vector2 vel, float maxDistance)
    {
        return new Boomerang(pos, vel, maxDistance, contentManager);
    }

    public Arrow CreateArrow(Vector2 pos, Vector2 vel, float rotation, float scale = 1f, float maxDistance = 600)
    {
        return new Arrow(
                texMask: new Rectangle(154, 0, 5, 16),
                pos,
                vel,
                maxDistance,
                rotation,
                origin: new Vector2(2.5f, 8f),
                scale,
                contentManager
                );
    }

    public StillItem CreateStillItem(StillType type, Vector2 pos, float rotation, float scale = 1)
    {
        Rectangle mask = new Rectangle(0, 0, 0, 0);
        switch (type)
        {
            case StillType.Heart:
                mask = new Rectangle(0, 0, 7, 8);
                break;
            case StillType.HeartContainer:
                mask = new Rectangle(25, 1, 13, 13);
                break;
            case StillType.Fairy:
                mask = new Rectangle(40, 0, 7, 16);
                break;
            case StillType.Clock:
                mask = new Rectangle(58, 0, 11, 16);
                break;
            case StillType.Rupee:
                mask = new Rectangle(72, 0, 8, 16);
                break;
            case StillType.BluePotion:
                mask = new Rectangle(80, 16, 8, 16);
                break;
            case StillType.Map:
                mask = new Rectangle(87, 0, 9, 16);
                break;
            case StillType.Bomb:
                mask = new Rectangle(136, 0, 8, 14);
                break;
            case StillType.Bow:
                mask = new Rectangle(144, 0, 8, 16);
                break;
            case StillType.BlueCandle:
                mask = new Rectangle(160, 16, 8, 16);
                break;
            case StillType.Key:
                mask = new Rectangle(240, 0, 8, 16);
                break;
            case StillType.Compass:
                mask = new Rectangle(258, 1, 11, 12);
                break;
            case StillType.Triforce:
                mask = new Rectangle(275, 3, 10, 10);
                break;
        }
        // todo remove
        return new StillItem(type.ToString(), contentManager, pos, mask, rotation, scale);
    }
}
