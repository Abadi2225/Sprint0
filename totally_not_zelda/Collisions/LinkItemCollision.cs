using Microsoft.Xna.Framework;
using Sprint.Interfaces;
using Sprint.Item;
using System.Collections.Generic;

namespace Sprint.Collision;

internal class LinkItemCollision : ICollisionHandler
{
    private readonly ILink link;
    private readonly ItemManager itemManager;
    private readonly List<AbstractItem> worldItems;

    internal LinkItemCollision(ILink link, ItemManager itemManager, List<AbstractItem> worldItems)
    {
        this.link = link;
        this.itemManager = itemManager;
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
                HandlePickup(item);
                worldItems.RemoveAt(i);
            }
        }
    }

    private void HandlePickup(AbstractItem item)
    {
        itemManager.Add(item);

        // Only "special" items trigger pickup animation
        if (item is Boomerang || item is Bow)
        {
            link.PlayPickupAnimation();
        }
        // TODO: expand when more special items are added
    }
}