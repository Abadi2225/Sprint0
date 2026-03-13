using Microsoft.Xna.Framework;
using Sprint.Interfaces;
using Sprint.Block;
using System.Collections.Generic;
using Sprint.UI;
using Sprint.Character;

namespace Sprint.Collisions
{
	public class LinkWallCollisionHandler : ICollisionHandler
	{

		private readonly ILink link;
		private readonly DungeonWalls dungeonWalls;

		public LinkWallCollisionHandler(ILink link, DungeonWalls dungeonWalls)
		{
			this.link = link;
			this.dungeonWalls = dungeonWalls;
		}

		public void Handle()
		{
			ResolveCollision(link, dungeonWalls);
		}
		private static void ResolveCollision(ILink link, DungeonWalls dungeonWalls)
		{

			if (link.Position.X < dungeonWalls.InnerBounds.Left)
			{
				int pushX = (int)dungeonWalls.InnerBounds.Left - (int)link.Position.X;
				link.Position += new Vector2(pushX, 0);
			}
			if(link.Position.X > dungeonWalls.InnerBounds.Right - link.Rect.Width)
			{
				int pushX = (int)dungeonWalls.InnerBounds.Right - link.Rect.Width - (int)link.Position.X;
				link.Position += new Vector2(pushX, 0);
			}
			if(link.Position.Y < dungeonWalls.InnerBounds.Top)
			{
				int pushY = (int)dungeonWalls.InnerBounds.Top - (int)link.Position.Y;
				link.Position += new Vector2(0, pushY);
			}
			if(link.Position.Y > dungeonWalls.InnerBounds.Bottom - link.Rect.Height)
			{
				int pushY = (int)dungeonWalls.InnerBounds.Bottom - link.Rect.Height - (int)link.Position.Y;
				link.Position += new Vector2(0, pushY);
			}
		}
	}
}
