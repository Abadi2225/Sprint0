using Microsoft.Xna.Framework.Input;
using Sprint.Character;
using Sprint.Commands;
using Sprint.GameStates.Gameplay;
using Sprint.Interfaces;
using Sprint.Item;
using Sprint.UI;
using Sprint.UI.InventoryElements;
using System.Collections.Generic;
using Sprint.GameStates;

namespace Sprint.InputHandling;

internal class GameplayInputHandler : IInputHandler
{
    private GameplayState state;
    private Link link;
    private Inventory inventory;
    private ItemManager items;
    private HUDBar hud;

    private Dictionary<Keys, ICommand> commands;

    private bool cReleased = true;
    private bool lmbReleased = true;
    private bool rmbReleased = true;

    public GameplayInputHandler(GameplayState thisState, Link link, Inventory inventory, ItemManager items, HUDBar hud)
    {
        this.state = thisState;
        this.link = link;
        this.inventory = inventory;
        this.items = items;
        this.hud = hud;

        commands = new Dictionary<Keys, ICommand>
        {
            {Keys.D1, new UseItemCommand(items, inventory, link)},
            {Keys.E, new TriggerDamageCommand(link)},
            {Keys.H, new SwitchDungeonCommand(state, 1)},
            {Keys.J, new SwitchDungeonCommand(state, 2)},
            {Keys.K, new KillLinkCommand(link)},
            {Keys.M, new ToggleMusicCommand()},
            {Keys.Q, new QuitCommand()},
            {Keys.R, new RestartGameCommand()},
            {Keys.X, new AttackCommand(link)},
            {Keys.Z, new UseItemCommand(items, inventory, link)}
        };
    }

    public void HandleInput()
    {
        if (GameServices.KeyInput.IsKeyDown(Keys.Up)) link.SetMove(Directions.Up);
        else if (GameServices.KeyInput.IsKeyDown(Keys.Down)) link.SetMove(Directions.Down);
        else if (GameServices.KeyInput.IsKeyDown(Keys.Left)) link.SetMove(Directions.Left);
        else if (GameServices.KeyInput.IsKeyDown(Keys.Right)) link.SetMove(Directions.Right);
        else link.StopMove();

        if (GameServices.KeyInput.IsKeyPressed(Keys.I) || GameServices.KeyInput.IsKeyPressed(Keys.S))
        {
            GameServices.GameActions.ChangeState(new InventoryScreen(
                        inventory,
                        inventory.ActiveSlot,
                        hud,
                        GameServices.inventoryMap,
                        state
                        ));
        }

        if (GameServices.KeyInput.IsKeyDown(Keys.C) && cReleased)
        {
            cReleased = false;
            state.DebugToggle();
        }
        cReleased = !GameServices.KeyInput.IsKeyDown(Keys.C);

        foreach (var command in commands)
        {
            if (GameServices.KeyInput.IsKeyPressed(command.Key))
            {
                command.Value.Execute();
            }
        }
    }

    public void HandleMouseInput()
    {
        MouseState mouse = Mouse.GetState();
        if (mouse.RightButton == ButtonState.Pressed && rmbReleased)
        {
            rmbReleased = false;
            state.DebugCycleRoom(true);
        }
        if (mouse.LeftButton == ButtonState.Pressed && lmbReleased)
        {
            lmbReleased = false;
            state.DebugCycleRoom(false);
        }
        rmbReleased = (mouse.RightButton == ButtonState.Released);
        lmbReleased = (mouse.LeftButton == ButtonState.Released);
    }
}
