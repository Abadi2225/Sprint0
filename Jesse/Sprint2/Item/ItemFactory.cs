using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Item;

internal class ItemFactory
{
    public enum AnimatedItemType
    {
        Boomerang,
        Arrow,
        Bomb,

    }
    public enum StillItemType
    {
        Heart,
        Fairy,
        HeartContainer,
        Clock,
        Compass,
        Rupee,
        BluePotion,
        Map,
        Bow,
        BlueCandle,
        Key,
        Triforce
    }
    ContentManager contentManager;
    public ItemFactory(ContentManager contentManager)
    {
        this.contentManager = contentManager;
    }

    public StillItem CreateStillItem(StillItemType type, Vector2 pos, float rotation, float scale = 1)
    {
        Rectangle mask;
        switch (type)
        {
        }
        // todo remove
        return null;
    }
}
