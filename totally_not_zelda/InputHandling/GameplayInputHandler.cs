using Microsoft.Xna.Framework.Input;
using Sprint.Character;
using Sprint.Commands;
using Sprint.GameStates;
using Sprint.Interfaces;
using Sprint.Item;
using Sprint.UI;
using Sprint.UI.InventoryElements;
using System.Collections.Generic;

namespace Sprint.InputHandling;

internal class GameplayInputHandler : IInputHandler
{
    private GameplayState state;
    private Link link;
    private Inventory inventory;
    private ItemManager items;
    private HUDBar hud;
    private InventoryMap invMap;

    private Dictionary<Keys, ICommand> commands;

    public GameplayInputHandler(GameplayState thisState, Link link, Inventory inventory, ItemManager items, HUDBar hud, InventoryMap invMap)
    {
        this.state = thisState;
        this.link = link;
        this.inventory = inventory;
        this.items = items;
        this.hud = hud;
        this.invMap = invMap;

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
                        invMap,
                        state
                        ));
        }

        foreach (var command in commands)
        {
            if (GameServices.KeyInput.IsKeyPressed(command.Key))
            {
                command.Value.Execute();
            }
        }
    }
}
