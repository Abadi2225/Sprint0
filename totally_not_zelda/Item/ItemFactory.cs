using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Item;

internal class ItemFactory
{
    public enum StillType
    {
        Heart,
        BlueHeart,
        HalfHeart,
        ZeroHeart,
        HeartContainer,
        Fairy,
        Clock,
        GoldRupee,
        PurpleRupee,
        BluePotion,
        Map,
        Bomb,
        Bow,
        BlueCandle,
        Key,
        Compass,
        GoldTriforce,
        PurpleTriforce,
    }
    private static ContentManager contentManager = Game1.Instance.Content;
    public static Boomerang CreateBoomerang(Vector2 pos, Vector2 vel, float maxDistance)
    {
        return new Boomerang(pos, vel, maxDistance, contentManager);
    }

    public static Arrow CreateArrow(Vector2 pos, Vector2 vel, float rotation, float scale = 1f, float maxDistance = 600)
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

    public static TimeBomb CreateTimeBomb(double explodeDelayMillis, Vector2 pos, float scale, float rotation = 0)
    {
        Rectangle mask = new Rectangle(136, 0, 8, 14);
        return new TimeBomb(
                explodeDelayMillis,
                "TimeBomb",
                contentManager,
                pos,
                mask,
                rotation,
                scale
                );
    }

    public static StillItem CreateStillItem(StillType type, Vector2 pos, float rotation, float scale = 1)
    {
        Rectangle mask = new Rectangle(0, 0, 0, 0);
        switch (type)
        {
            case StillType.Heart:
                mask = new Rectangle(0, 0, 7, 8);
                break;
            case StillType.BlueHeart:
                mask = new Rectangle(0, 8, 7, 8);
                break;
            case StillType.HalfHeart:
                mask = new Rectangle(8, 0, 7, 8);
                break;
            case StillType.ZeroHeart:
                mask = new Rectangle(16, 0, 7, 8);
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
            case StillType.GoldRupee:
                mask = new Rectangle(72, 0, 8, 16);
                break;
            case StillType.PurpleRupee:
                mask = new Rectangle(72, 16, 8, 16);
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
            case StillType.GoldTriforce:
                mask = new Rectangle(275, 3, 10, 10);
                break;
            case StillType.PurpleTriforce:
                mask = new Rectangle(275, 19, 10, 10);
                break;
        }
        // todo remove
        return new StillItem(type.ToString(), contentManager, pos, mask, rotation, scale);
    }
}
