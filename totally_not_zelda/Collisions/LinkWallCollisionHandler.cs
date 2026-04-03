using Microsoft.Xna.Framework;
using Sprint.Interfaces;
using Sprint.UI;
using System;

namespace Sprint.Collisions
{
	public class LinkWallCollisionHandler : ICollisionHandler
	{
		private readonly ILink link;
		private readonly JesseDungeonWalls dungeonWalls;
		private readonly Action<string> onDoorExit;

		public LinkWallCollisionHandler(ILink link, JesseDungeonWalls dungeonWalls, Action<string> onDoorExit = null)
		{
			this.link = link;
			this.dungeonWalls = dungeonWalls;
			this.onDoorExit = onDoorExit;
		}

		public void Handle()
		{
			ResolveCollision(link, dungeonWalls, onDoorExit);
		}

		private static void ResolveCollision(ILink link, JesseDungeonWalls dungeonWalls, Action<string> onDoorExit)
		{
			int spriteSize = link.Rect.Width; // 48 — full sprite width (unchanged by lower-half rect)
			int centerX = (int)link.Position.X + spriteSize / 2;
			int centerY = (int)link.Position.Y + spriteSize / 2;

			bool inTopDoorX  = centerX >= dungeonWalls.TopDoorLeft  && centerX <= dungeonWalls.TopDoorRight;
			bool inSideDoorY = centerY >= dungeonWalls.SideDoorTop   && centerY <= dungeonWalls.SideDoorBottom;

			bool doorExited = false;

			if (link.Position.X < dungeonWalls.InnerBounds.Left)
			{
				if (inSideDoorY && onDoorExit != null) 
				{ 
					onDoorExit("west"); 
					doorExited = true; 
				}
				else { link.Position += new Vector2(dungeonWalls.InnerBounds.Left - (int)link.Position.X, 0); }
			}

			if (!doorExited && link.Position.X > dungeonWalls.InnerBounds.Right - spriteSize)
			{
				if (inSideDoorY && onDoorExit != null) { onDoorExit("east"); doorExited = true; }
				else { link.Position += new Vector2(dungeonWalls.InnerBounds.Right - spriteSize - (int)link.Position.X, 0); }
			}

			if (!doorExited && link.Position.Y < dungeonWalls.InnerBounds.Top)
			{
				if (inTopDoorX && onDoorExit != null) { onDoorExit("north"); doorExited = true; }
				else { link.Position += new Vector2(0, dungeonWalls.InnerBounds.Top - (int)link.Position.Y); }
			}

			if (!doorExited && link.Position.Y > dungeonWalls.InnerBounds.Bottom - spriteSize)
			{
				if (inTopDoorX && onDoorExit != null) { onDoorExit("south"); doorExited = true; }
				else { link.Position += new Vector2(0, dungeonWalls.InnerBounds.Bottom - spriteSize - (int)link.Position.Y); }
			}
		}
	}
}
