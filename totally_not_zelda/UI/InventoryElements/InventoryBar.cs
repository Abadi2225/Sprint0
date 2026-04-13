using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Sprint.Interfaces;
using Sprint.Sprites;
using Sprint.Item;

namespace Sprint.UI.InventoryElements;

internal class InventoryBar : IUIElement
{
    public static readonly int COLS = 4;
    public static readonly int ROWS = 2;
    private static readonly int LAST_SLOT = COLS * ROWS - 1;

    private static readonly Vector2 ACTIVE_ITEM_OFFSET = new Vector2(68, 48);

    private StaticSprite background;
    private StaticSprite selectedSlotBorder;

    private List<Vector2> slotPositions;
    public int X { get; set; }
    public int Y { get; set; }

    private int activeSlot = 0;
    private StaticSprite activeItem;
    private List<StaticSprite> itemSprites = new List<StaticSprite>();

    public InventoryBar(List<IItem> inventory, int activeSlot, int x, int y)
    {
        this.activeSlot = activeSlot;
        X = x;
        Y = y;

        background = new StaticSprite(
            GameServices.Content.Load<Texture2D>("images/ZeldaUIElements"),
            new Vector2(X, Y),
            new Rectangle(1, 11, 256, 88)
        );

        selectedSlotBorder = new StaticSprite(
                GameServices.Content.Load<Texture2D>("images/ZeldaUIElements"),
                getBorderPosition(this.activeSlot),
                new Rectangle(519, 137, 16, 16)
                );

        for (int i = 0; i < MathHelper.Min(inventory.Count, ROWS * COLS); i++)
        {
            itemSprites.Add(ItemHudSprites.GetSprite(inventory[i].Name, getSlotPosition(i)));
        }
    }

    public void Draw(SpriteBatch sb)
    {
        background.Draw(sb, background.Position);
        selectedSlotBorder.Draw(sb, selectedSlotBorder.Position);
        for (int i = 0; i < itemSprites.Count; i++)
        {
            StaticSprite toDraw = itemSprites[i];
            toDraw.Draw(sb, toDraw.Position);
            if (i == activeSlot)
            {
                // also draw in active slot
                toDraw.Draw(sb, new Vector2(X, Y) + ACTIVE_ITEM_OFFSET * GameServices.ScaleFactor);
            }
        }
    }

    public void Update(GameTime time)
    {
        selectedSlotBorder.Position = getBorderPosition(activeSlot);
    }

    public void SetActiveSlot(int newSlot)
    {
        activeSlot = newSlot;
    }

    // position of the item, not the selection box
    private Vector2 getSlotPosition(int slot)
    {
        int row = slot / COLS;
        int col = slot % COLS;
        return new Vector2(X + (132 + 24 * col) * GameServices.ScaleFactor, Y + (48 + 16 * row) * GameServices.ScaleFactor);
    }

    private Vector2 getBorderPosition(int slot)
    {
        return getSlotPosition(slot) - new Vector2(4 * GameServices.ScaleFactor, 0);
    }
}
