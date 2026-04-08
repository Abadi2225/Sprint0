using Sprint.Interfaces;
using Sprint.Commands;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Sprint.Item;
using Sprint.Character;
using Sprint.GameStates;
using Sprint.UI;

namespace Sprint.InputHandling;

internal class GameplayInputHandler : IInputHandler
{
    private GameplayState state;
    private Link link;
    private Inventory inventory;
    private ItemManager items;
    private HUDBar hud;

    private Dictionary<Keys, ICommand> commands;

    public GameplayInputHandler(GameplayState thisState, Link link, Inventory inventory, ItemManager items, HUDBar hud)
    {
        this.state = thisState;
        this.link = link;
        this.inventory = inventory;
        this.items = items;
        this.hud = hud;

        commands = new Dictionary<Keys, ICommand>
        {
            {Keys.D1, new UseItemCommand(items, inventory, link, 0)},
            {Keys.D2, new UseItemCommand(items, inventory, link, 1)},
            {Keys.D3, new UseItemCommand(items, inventory, link, 2)},

            {Keys.E, new TriggerDamageCommand(link)},
            {Keys.Q, new QuitCommand()},
            {Keys.R, new SetStateCommand(new MenuState())},
            {Keys.X, new AttackCommand(link)}
        };
    }

    public void HandleInput()
    {
        if (GameServices.KeyInput.IsKeyDown(Keys.Up)) link.SetMove(Directions.Up);
        else if (GameServices.KeyInput.IsKeyDown(Keys.Down)) link.SetMove(Directions.Down);
        else if (GameServices.KeyInput.IsKeyDown(Keys.Left)) link.SetMove(Directions.Left);
        else if (GameServices.KeyInput.IsKeyDown(Keys.Right)) link.SetMove(Directions.Right);
        else link.StopMove();

        if (GameServices.KeyInput.IsKeyPressed(Keys.I))
        {
            GameServices.GameActions.ChangeState(new InventoryScreen(
                        inventory,
                        inventory.ActiveSlot,
                        hud,
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
