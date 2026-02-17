using System.Collections.Generic;

namespace Sprint.Item;

public class ItemStack<T> where T : AbstractItem
{
    public T Item;
    public int StackLimit;

    public ItemStack(T item)
    {
        Item = item;
        StackLimit = item.StackLimit;
    }
}
