using Microsoft.Xna.Framework;
using System.Collections.Generic;

using Sprint.Interfaces;
using Sprint.Item;
using Sprint.Sound;
using Sprint.Character;

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
                GameServices.currentRoomState.CollectedItems.Add(item.ID);
                worldItems.RemoveAt(i);
                HandlePickup(item);
            }
        }
    }

    private void HandlePickup(AbstractItem item)
    {
        switch (item.Name)
        {
            case "GoldRupee":
                link.IncreaseRubies(1);
                SoundPlayer.Play(SoundType.PICKUP_RUPEE);
                return;
            case "PurpleRupee":
                link.IncreaseRubies(5);
                SoundPlayer.Play(SoundType.PICKUP_RUPEE);
                return;
            case "Heart":
                link.GetHealed(2);
                SoundPlayer.Play(SoundType.LINK_HEALED);
                return;
            case "BlueHeart":
            case "HalfHeart":
                link.GetHealed(1);
                SoundPlayer.Play(SoundType.LINK_HEALED);
                return;
            case "HeartContainer":
                link.AddHeartContainer();
                SoundPlayer.Play(SoundType.PICKUP_ITEM);
                return;
            case "Fairy":
                link.GetHealed(link.MaxHealth);
                SoundPlayer.Play(SoundType.PICKUP_ITEM);
                return;
            case "Key":
                link.AddKey();
                SoundPlayer.Play(SoundType.PICKUP_ITEM);
                return;
            case "Bomb":
                link.AddBomb();
                SoundPlayer.Play(SoundType.PICKUP_ITEM);
                return;
            case "ZeroHeart":
                // not sure what this does, but it shouldn't go in the inventory
                return;
            case "Clock":
                // not sure what this does
                return;
        }

        // All other items go into the inventory

        // Weapon items trigger the weapon pickup animation
        if (item is Boomerang || item.Name == "Bow")
        {
            link.StartPickUpWeapon(item.SourceRect);
            SoundPlayer.Play(SoundType.PICKUP_VALUABLE);
            return;
        }

        // Triforce items trigger the triforce pickup animation
        if (item.Name == "GoldTriforce" || item.Name == "PurpleTriforce")
        {
            link.StartPickUpTriforce(item.SourceRect);
            SoundPlayer.Play(SoundType.PICKUP_ITEM);
            return;
        }

        inventory.Add(item);
        SoundPlayer.Play(SoundType.PICKUP_ITEM);
    }
}
