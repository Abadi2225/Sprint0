using Microsoft.Xna.Framework;
using Sprint.Doors;
using Sprint.Interfaces;
using Sprint.UI;
using System;

namespace Sprint.Collisions
{
	public class LinkWallCollisionHandler : ICollisionHandler
	{
		private readonly ILink link;
		private readonly OuterDungeonWalls dungeonWalls;
        private readonly DoorManager doorManager;
		private readonly Action<string> onDoorExit;
        // Set when Link has entered a door opening but hasn't gone deep enough to transition yet.
        private string pendingExit;

		public LinkWallCollisionHandler(ILink link, OuterDungeonWalls dungeonWalls, DoorManager doorManager, Action<string> onDoorExit = null)
		{
			this.link = link;
			this.dungeonWalls = dungeonWalls;
			this.doorManager = doorManager;
			this.onDoorExit = onDoorExit;
		}

		public void Handle()
		{

            if (link.IsGrabbed) return;
			int spriteSize = link.Rect.Width;
			int exitDepth  = dungeonWalls.DoorExitDepth;

            bool inTopDoorX  = link.Position.X >= dungeonWalls.TopDoorLeft  && link.Position.X + spriteSize <= dungeonWalls.TopDoorRight;
            bool inSideDoorY = link.Position.Y >= dungeonWalls.SideDoorTop   && link.Position.Y + spriteSize <= dungeonWalls.SideDoorBottom;

            // If Link is mid-transition, check if he backed out first.
            if (pendingExit != null)
            {
                bool backedOut = pendingExit switch
                {
                    "west"  => link.Position.X >= dungeonWalls.InnerBounds.Left,
                    "east"  => link.Position.X <= dungeonWalls.InnerBounds.Right - spriteSize,
                    "north" => link.Position.Y >= dungeonWalls.InnerBounds.Top,
                    "south" => link.Position.Y <= dungeonWalls.InnerBounds.Bottom - spriteSize,
                    _       => true
                };
                if (backedOut)
                {
                    pendingExit = null;
                }
                else
                {
                    // This is so link won't appear on top of the wall
                    switch (pendingExit)
                    {
                        case "west":
                        case "east":
                            if (link.Position.Y < dungeonWalls.SideDoorTop)
                                link.Position = new Vector2(link.Position.X, dungeonWalls.SideDoorTop);
                            else if (link.Position.Y + spriteSize > dungeonWalls.SideDoorEntryBottom)
                                link.Position = new Vector2(link.Position.X, dungeonWalls.SideDoorEntryBottom - spriteSize);
                            break;
                        case "north":
                        case "south":
                            if (link.Position.X < dungeonWalls.TopDoorLeft)
                                link.Position = new Vector2(dungeonWalls.TopDoorLeft, link.Position.Y);
                            else if (link.Position.X + spriteSize > dungeonWalls.TopDoorRight)
                                link.Position = new Vector2(dungeonWalls.TopDoorRight - spriteSize, link.Position.Y);
                            break;
                    }

                    bool deepEnough = pendingExit switch
                    {
                        "west"  => link.Position.X < dungeonWalls.InnerBounds.Left - exitDepth,
                        "east"  => link.Position.X > dungeonWalls.InnerBounds.Right - spriteSize + exitDepth,
                        "north" => link.Position.Y < dungeonWalls.InnerBounds.Top - exitDepth,
                        "south" => link.Position.Y > dungeonWalls.InnerBounds.Bottom - spriteSize + exitDepth,
                        _       => false
                    };
                    if (deepEnough)
                    {
                        string dir = pendingExit;
                        pendingExit = null;
                        onDoorExit?.Invoke(dir);
                    }
                    return; // Still in door opening, skip wall collision.
                }
            }
            
            bool doorExited = false;

            if (link.Position.X < dungeonWalls.InnerBounds.Left)
            {
                if (inSideDoorY && TryEnterDoor("west"))
                    doorExited = true;
                else
                    link.Position += new Vector2(dungeonWalls.InnerBounds.Left - (int)link.Position.X, 0);
            }

            if (!doorExited && link.Position.X > dungeonWalls.InnerBounds.Right - spriteSize)
            {
                if (inSideDoorY && TryEnterDoor("east"))
                    doorExited = true;
                else
                    link.Position += new Vector2(dungeonWalls.InnerBounds.Right - spriteSize - (int)link.Position.X, 0);
            }

            if (!doorExited && link.Position.Y < dungeonWalls.InnerBounds.Top)
            {
                if (inTopDoorX && TryEnterDoor("north"))
                    doorExited = true;
                else
                    link.Position += new Vector2(0, dungeonWalls.InnerBounds.Top - (int)link.Position.Y);
            }

            if (!doorExited && link.Position.Y > dungeonWalls.InnerBounds.Bottom - spriteSize)
            {
                if (inTopDoorX && TryEnterDoor("south"))
                    doorExited = true;
                else
                    link.Position += new Vector2(0, dungeonWalls.InnerBounds.Bottom - spriteSize - (int)link.Position.Y);
            }
        }

        // Checks if the door is passable (consuming a key if needed) and starts the walkthrough.
        // Returns true if Link may enter the door opening; the transition triggers once deep enough.
        private bool TryEnterDoor(string direction)
        {
            if (doorManager == null || !doorManager.TryExit(direction, link)) return false;
            pendingExit = direction;
            return true;
        }
    }
}
