using Microsoft.Xna.Framework;
using Sprint.Block;
using Sprint.Interfaces;
using System;
using System.Collections.Generic;

namespace Sprint.Collisions
{
    public class StairCollisionHandler : ICollisionHandler
    {
        private readonly ILink link;
        private readonly BlockManager blockManager;
        private readonly string targetRoom;
        private readonly Action<string> onStairEntered;

        public StairCollisionHandler(ILink link, BlockManager blockManager, 
            string targetRoom, Action<string> onStairEntered)
        {
            this.link          = link;
            this.blockManager  = blockManager;
            this.targetRoom    = targetRoom;
            this.onStairEntered = onStairEntered;
        }

        public void Handle()
        {
            if (targetRoom == null) return;

            foreach (var block in blockManager.blocksList)
            {
                if (!block.IsStair) continue;
                if (link.Rect.Intersects(block.Rect))
                {
                    onStairEntered?.Invoke(targetRoom);
                    return;
                }
            }
        }
    }
}