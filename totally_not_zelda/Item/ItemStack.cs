// using System;
// using System.Collections.Generic;
//
// namespace Sprint.Item;
//
// internal class ItemStack<T> where T : AbstractItem
// {
//     public T Item;
//     public int StackLimit;
//     public int Size;
//
//     public ItemStack(T item)
//     {
//         Item = item;
//         StackLimit = item.StackLimit;
//         Size = 1;
//     }
//
//     public ItemStack(T item, int count) : this(item)
//     {
//         Size = count;
//     }
//
//     public void IncreaseSize(int count)
//     {
//         Size = Math.floor(Size + count, StackLimit);
//     }
//
//     public void Increment()
//     {
//         IncreaseSize(1);
//     }
// }
