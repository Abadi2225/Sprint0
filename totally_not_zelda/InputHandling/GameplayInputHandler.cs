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
                        invMap,
                        state
                        ));
        }

        if (GameServices.KeyInput.IsKeyPressed(Keys.K))
        {
            link.StartDeath();
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
