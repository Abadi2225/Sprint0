using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Item;
using Sprint.UI;
using Sprint.UI.InventoryElements;
using Sprint.Commands;

namespace Sprint.GameStates;

internal class InventoryScreen : IGameState
{
    private Inventory inventory;
    private InventoryBar inventoryBar;
    private int activeSlot;  // use this field while in this screen. only update inventory.activeSlot on screen close
    private MapBar mapBar;
    private HUDBar hud;
    private int hudOriginalX;
    private int hudOriginalY;
    private IGameState restoreState;

    public InventoryScreen(Inventory inventory, int activeSlot, HUDBar hud, InventoryMap invMap, IGameState restoreState)
    {
        this.inventory = inventory;
        this.activeSlot = activeSlot;
        this.inventoryBar = new InventoryBar(
                this.inventory.GetItems(),
                this.activeSlot,
                0, 48 * (int)GameServices.ScaleFactor
                );
        this.mapBar = new MapBar(
                0,
                136 * (int)GameServices.ScaleFactor,
                invMap,
                this.inventory.HasMap,
                this.inventory.HasCompass
                );
        this.hudOriginalX = hud.X;
        this.hudOriginalY = hud.Y;
        this.hud = hud;
        this.restoreState = restoreState;
    }

    public void Update(GameTime time)
    {
        if (GameServices.KeyInput.IsKeyPressed(Keys.I) || GameServices.KeyInput.IsKeyPressed(Keys.Escape) || GameServices.KeyInput.IsKeyPressed(Keys.S))
        {
            hud.X = hudOriginalX;
            hud.Y = hudOriginalY;
            inventory.ActiveSlot = this.activeSlot;
            hud.UpdateActiveItem();
            Game1.Instance.ForceState(restoreState);
            return;
        }
        if (GameServices.KeyInput.IsKeyPressed(Keys.Q))
        {
            GameServices.GameActions.Quit();
            return;
        }

        int slots = MathHelper.Min(inventory.Count, InventoryBar.COLS * InventoryBar.ROWS);  // this is 1-indexed
        if (slots == 0)
        {
            inventoryBar.SetActiveSlot(0);
        }
        else
        {
            int nextSlot = activeSlot;  // 0-indexed
            if (GameServices.KeyInput.IsKeyPressed(Keys.Right))
            {
                nextSlot++;
            }
            else if (GameServices.KeyInput.IsKeyPressed(Keys.Down))
            {
                nextSlot += InventoryBar.COLS;
            }
            else if (GameServices.KeyInput.IsKeyPressed(Keys.Left))
            {
                nextSlot--;
            }
            else if (GameServices.KeyInput.IsKeyPressed(Keys.Up))
            {
                nextSlot -= InventoryBar.COLS;
            }

            if (nextSlot >= 0 && nextSlot < slots)
            {
                // valid move
                this.activeSlot = nextSlot;
            }
        }
        inventoryBar.SetActiveSlot(this.activeSlot);


        inventoryBar.Update(time);  // should be called after setting active slot

    }
    public void Draw(SpriteBatch sb)
    {
        this.inventoryBar.Draw(sb);
        this.mapBar.Draw(sb);
        this.hud.Draw(sb);
    }

    public void Exit()
    {
    }

    public void Enter() { }
    public void LoadContent() { }
}
