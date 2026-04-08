using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.UI.InventoryElements;

internal class InventoryBar : IUIElement
{
    public static readonly int COLS = 4;
    public static readonly int ROWS = 2;
    private static readonly int LAST_SLOT = COLS * ROWS - 1;

    private readonly Vector2 activePosition;

    private StaticSprite background;
    private StaticSprite activeSlotBorder;

    private List<Vector2> slotPositions;
    public int X { get; set; }
    public int Y { get; set; }

    private List<IItem> inventory;
    private int activeSlot = 0;

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

        activeSlotBorder = new StaticSprite(
                GameServices.Content.Load<Texture2D>("images/ZeldaUIElements"),
                getBorderPosition(this.activeSlot),
                new Rectangle(519, 137, 16, 16)
                );

        activePosition = new Vector2(X + 68 * GameServices.ScaleFactor, Y + 48 * GameServices.ScaleFactor);
        this.inventory = inventory;
        for (int i = 0; i < MathHelper.Min(this.inventory.Count, ROWS * COLS); i++)
        {
            inventory[i].Position = getSlotPosition(i);
        }
    }

    public void Draw(SpriteBatch sb)
    {
        background.Draw(sb, background.Position);
        activeSlotBorder.Draw(sb, activeSlotBorder.Position);
        for (int i = 0; i < MathHelper.Min(inventory.Count, ROWS * COLS); i++)
        {
            inventory[i].Draw(sb, Vector2.Zero);
            if (i == activeSlot)
            {
                // jank way to draw one item in multiple positions
                inventory[i].Position = activePosition;
                inventory[i].Draw(sb, Vector2.Zero);
                inventory[i].Position = getSlotPosition(i);  // restore position
            }
        }
    }

    public void Update(GameTime time)
    {
        activeSlotBorder.Position = getBorderPosition(activeSlot);
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
