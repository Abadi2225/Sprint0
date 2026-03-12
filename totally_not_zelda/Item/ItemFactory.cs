using Microsoft.Xna.Framework;

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

    public static Boomerang CreateBoomerang(Vector2 pos, Vector2 vel, float maxDistance)
    {
        return new Boomerang(pos, vel, maxDistance);
    }

    public static Arrow CreateArrow(Vector2 pos, Vector2 vel, float rotation, float scale = 1f, float maxDistance = 600)
    {
        return new Arrow(
                sourceRect: new Rectangle(154, 0, 5, 16),
                pos,
                vel,
                maxDistance,
                rotation,
                origin: new Vector2(2.5f, 8f),
                scale
                );
    }

    public static TimeBomb CreateTimeBomb(double explodeDelayMillis, Vector2 pos, float scale)
    {
        Rectangle sourceRect = new Rectangle(136, 0, 8, 14);
        return new TimeBomb(explodeDelayMillis, "TimeBomb", pos, sourceRect, scale);
    }

    public static StillItem CreateStillItem(StillType type, Vector2 pos, float scale = 1)
    {
        Rectangle sourceRect = type switch
        {
            StillType.Heart          => new Rectangle(0, 0, 7, 8),
            StillType.BlueHeart      => new Rectangle(0, 8, 7, 8),
            StillType.HalfHeart      => new Rectangle(8, 0, 7, 8),
            StillType.ZeroHeart      => new Rectangle(16, 0, 7, 8),
            StillType.HeartContainer => new Rectangle(25, 1, 13, 13),
            StillType.Fairy          => new Rectangle(40, 0, 7, 16),
            StillType.Clock          => new Rectangle(58, 0, 11, 16),
            StillType.GoldRupee      => new Rectangle(72, 0, 8, 16),
            StillType.PurpleRupee    => new Rectangle(72, 16, 8, 16),
            StillType.BluePotion     => new Rectangle(80, 16, 8, 16),
            StillType.Map            => new Rectangle(87, 0, 9, 16),
            StillType.Bomb           => new Rectangle(136, 0, 8, 14),
            StillType.Bow            => new Rectangle(144, 0, 8, 16),
            StillType.BlueCandle     => new Rectangle(160, 16, 8, 16),
            StillType.Key            => new Rectangle(240, 0, 8, 16),
            StillType.Compass        => new Rectangle(258, 1, 11, 12),
            StillType.GoldTriforce   => new Rectangle(275, 3, 10, 10),
            StillType.PurpleTriforce => new Rectangle(275, 19, 10, 10),
            _                        => new Rectangle(0, 0, 0, 0),
        };
        return new StillItem(type.ToString(), GameServices.ItemSheet, pos, sourceRect, scale);
    }
}
