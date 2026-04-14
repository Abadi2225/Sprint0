using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Sprites;

namespace Sprint.Item;

internal static class ItemHudSprites
{
    private static readonly Texture2D spriteSheet = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
    private static readonly Rectangle sword = new Rectangle(555, 137, 8, 16);
    private static readonly Rectangle boomerang = new Rectangle(584, 137, 8, 16);
    private static readonly Rectangle bomb = new Rectangle(604, 137, 8, 16);
    private static readonly Rectangle bow = new Rectangle(633, 137, 8, 16);
    private static readonly Rectangle blueCandle = new Rectangle(644, 137, 8, 16);
    private static readonly Rectangle bluePotion = new Rectangle(695, 137, 8, 16);
    private static readonly Rectangle notFound = new Rectangle(519, 117, 8, 8);

    private static readonly Dictionary<string, Rectangle> nameMap = new Dictionary<string, Rectangle> {
        {"Sword", sword},
        {"Boomerang", boomerang},
        {"Bomb", bomb},
        {"Bow", bow},
        {"BlueCandle", blueCandle},
        {"BluePotion", bluePotion},
        {"Unknown", notFound},
    };

    public static StaticSprite GetSprite(string itemName, Vector2 position)
    {
        if (!nameMap.ContainsKey(itemName))
        {
            itemName = "Unknown";
        }
        return new StaticSprite(
                spriteSheet,
                position,
                nameMap[itemName]
                );
    }
}
