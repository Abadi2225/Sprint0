using System;
using Microsoft.Xna.Framework;
using Sprint.Interfaces;

namespace Sprint.Item;

// Carried by an enemy, drops into the world when the carrier dies.
public class CarriedItem
{
    private readonly AbstractItem item;
    private readonly IEnemy carrier;
    private readonly Action<AbstractItem> onDropped;
    private bool dropped;

    public CarriedItem(AbstractItem item, IEnemy carrier, Action<AbstractItem> onDropped)
    {
        this.item = item;
        this.carrier = carrier;
        this.onDropped = onDropped;
    }

    public void Update()
    {
        if (dropped || carrier.IsAlive) return;

        item.Position = carrier.Position;
        onDropped(item);
        dropped = true;
    }
}
