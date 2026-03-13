using Microsoft.Xna.Framework;
using Sprint.Interfaces;
using Sprint.Item;
using System.Collections.Generic;

namespace Sprint.Collision;

internal class LinkItemCollision : ICollisionHandler
{
    private readonly ILink link;
    private readonly Inventory inventory;
    private readonly List<AbstractItem> worldItems;

    internal LinkItemCollision(ILink link, Inventory inventory, List<AbstractItem> worldItems)
    {
        this.link = link;
        this.inventory = inventory;
        this.worldItems = worldItems;
    }

    public void Handle()
    {
        Rectangle linkRect = link.Rect;

        for (int i = worldItems.Count - 1; i >= 0; i--)
        {
            AbstractItem item = worldItems[i];

            if (linkRect.Intersects(item.Rect))
            {
                worldItems.RemoveAt(i);
                HandlePickup(item);
            }
        }
    }

    private void HandlePickup(AbstractItem item)
    {
        switch (item.Name)
        {
            case "GoldRupee":   link.IncreaseRubies(1); return;
            case "PurpleRupee": link.IncreaseRubies(5); return;

            case "Heart":
            case "BlueHeart":
            case "HalfHeart":   link.GetHealed(1); return;
            case "Fairy":       link.GetHealed(link.MaxHealth); return;
        }

        // All other items go into the inventory
        inventory.Add(item);

        // Weapon items trigger the weapon pickup animation
        if (item is Boomerang || item.Name == "Bow")
        {
            link.StartPickUpWeapon(item.SourceRect);
        }

        // Triforce items trigger the triforce pickup animation
        if (item.Name == "GoldTriforce" || item.Name == "PurpleTriforce")
        {
            link.StartPickUpTriforce();
        }
    }
}