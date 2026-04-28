using Microsoft.Xna.Framework;
using Sprint.Block;
using Sprint.Character;
using Sprint.Collision;
using Sprint.Collisions;
using Sprint.Doors;
using Sprint.Enemies;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;
using Sprint.Item;
using Sprint.UI;
using System;
using System.Collections.Generic;

namespace Sprint.GameStates
{
    internal class GameplayCollisionManager
    {
        private readonly Link link;
        private readonly Inventory inventory;
        private readonly ItemManager items;
        private readonly OuterDungeonWalls dungeonWalls;
        private readonly DoorManager doorManager;
        private readonly Action<string> onDoorExit;

        private CollisionManager collisionManager;

        public GameplayCollisionManager(
            Link link,
            Inventory inventory,
            ItemManager items,
            OuterDungeonWalls dungeonWalls,
            DoorManager doorManager,
            Action<string> onDoorExit)
        {
            this.link         = link;
            this.inventory    = inventory;
            this.items        = items;
            this.dungeonWalls = dungeonWalls;
            this.doorManager  = doorManager;
            this.onDoorExit   = onDoorExit;
        }

        public void Rebuild(RoomManager roomManager)
        {
            collisionManager = new CollisionManager();

            // Moldorm — handled separately since it has custom head/tail/middle logic
            var moldorms = new List<Moldorm>();
            foreach (var enemy in roomManager.CurrentLevel.Enemies.EnemyList)
            {
                var actual = enemy is EnemyEffectWrapper w ? w.InnerEnemy : enemy;
                if (actual is Moldorm m)
                    moldorms.Add(m);
            }
            if (moldorms.Count > 0)
                collisionManager.Add(new MoldormCollisionHandler(link, moldorms));

            collisionManager.Add(new LinkEnemyCollision(link, roomManager.CurrentLevel.Enemies));
            collisionManager.Add(new SwordEnemyCollision(link, roomManager.CurrentLevel.Enemies));
            collisionManager.Add(new EnemyBlockCollisionHandler(
                roomManager.CurrentLevel.Enemies.EnemyList,
                roomManager.CurrentLevel.Blocks));
            collisionManager.Add(new LinkBlockPushHandler(link, roomManager.CurrentLevel.Blocks, roomManager.CurrentLevel.Enemies));
            collisionManager.Add(new LinkBlockCollisionHandler(link, roomManager.CurrentLevel.Blocks));
            collisionManager.Add(new LinkItemCollision(link, inventory, roomManager.CurrentLevel.WorldItems));
            collisionManager.Add(new ProjectileCollision(link, items, roomManager.CurrentLevel.Enemies));
            collisionManager.Add(new EnemyWallCollisionHandler(
                roomManager.CurrentLevel.Enemies.EnemyList,
                dungeonWalls));

            if (!roomManager.IsUnderground)
                collisionManager.Add(new LinkWallCollisionHandler(
                    link, dungeonWalls, doorManager, onDoorExit));

            if (roomManager.CurrentLevelData?.stairTarget != null)
                collisionManager.Add(new StairCollisionHandler(
                    link,
                    roomManager.CurrentLevel.Blocks,
                    roomManager.CurrentLevelData.stairTarget,
                    targetRoom => roomManager.HandleStairTransition(targetRoom, doorManager, link)));
        }

        public void HandleAll() => collisionManager?.HandleAll();
    }
}