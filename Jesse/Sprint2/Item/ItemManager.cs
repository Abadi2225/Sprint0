using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Item;

public class ItemManager
{
    internal List<AbstractItem> Items { get; }

	// Projectile instances spawned by items
	internal List<ISprite> Projectiles { get; } = new List<ISprite>();
	public int ActiveItem { get; set; }
	public static ItemManager? Current { get; private set; }
	public ItemManager()
    {
		Current = this;
		Items = new List<AbstractItem>();

    }

    internal void CreateItem(AbstractItem item)
    {
        Items.Add(item);
    }

	public void SpawnProjectile(ISprite projectile)
	{
		if (projectile != null)
			Projectiles.Add(projectile);
	}

	public void DrawAllItems(SpriteBatch sb)
    {
        foreach (AbstractItem item in Items)
        {
            item.Draw(sb, Vector2.Zero);
        }
    }

    public void DrawActiveItem(SpriteBatch sb)
    {
        Items[ActiveItem].Draw(sb, Vector2.Zero);
    }

    public void Update(GameTime time)
    {
        foreach (AbstractItem item in Items)
        {
            item.Update(time);
        }

		for (int i = Projectiles.Count - 1; i >= 0; i--)
		{
			int done = Projectiles[i].Update(time);
			if (done != 0)
				Projectiles.RemoveAt(i);
		}
	}

	public void DrawProjectiles(SpriteBatch sb)
	{
		foreach (var p in Projectiles)
			p.Draw(sb, Vector2.Zero);
	}

	internal AbstractItem GetActiveItem()
    {
        return Items[ActiveItem];
    }
	internal AbstractItem GetItem(int index)
	{
		if (index < 0 || index >= Items.Count) return null;
		return Items[index];
	}
	public void CycleNext()
    {
        if (ActiveItem < Items.Count - 1)
        {
            ActiveItem++;
        }
    }
    public void CyclePrevious()
    {
        if (ActiveItem > 0)
        {
            ActiveItem--;
        }
    }
}
