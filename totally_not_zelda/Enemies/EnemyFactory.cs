using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;
using Sprint.Item;
using Sprint.Sprites;
using System.Collections.Generic;
using BlockType = Sprint.Block.Block;

namespace Sprint.Enemies
{
    public enum EnemyType
    {
        Keese,
        Stalfos,
        Gel,
        Zol,
        Goriya,
        WallMaster,
        Trap,
        Rope,
        Aquamentus,
        Dodongo,
        OldMan,
        FlameLeft, FlameRight,

    }

    public class EnemyFactory
    {
        private readonly Texture2D enemySpriteSheet;
        private readonly Texture2D bossSpriteSheet;
        private readonly Texture2D linkSheet;
        private readonly Texture2D dustSheet;
        private readonly Texture2D NPCSheet;
        private readonly ContentManager contentManager;

        public EnemyFactory(Texture2D enemySpriteSheet, Texture2D bossSpriteSheet, Texture2D linkSheet, Texture2D dustSheet, Texture2D NPCSheet)
        {
            this.enemySpriteSheet = enemySpriteSheet;
            this.bossSpriteSheet = bossSpriteSheet;
            this.linkSheet = linkSheet;
            this.dustSheet = dustSheet;
            this.NPCSheet = NPCSheet;
            this.contentManager = GameServices.Content;
        }

        private static readonly Random Rng = new();

        private static AbstractItem CreateDrop(EnemyType type) => type switch
        {
            EnemyType.Aquamentus => ItemFactory.CreateStillItem(ItemFactory.StillType.HeartContainer, Vector2.Zero, scale: GameServices.ScaleFactor),
            EnemyType.Dodongo => ItemFactory.CreateStillItem(ItemFactory.StillType.HeartContainer, Vector2.Zero, scale: GameServices.ScaleFactor),
            EnemyType.OldMan or EnemyType.FlameLeft or EnemyType.FlameRight or EnemyType.Trap => null,
            _ => RollRandomDrop(),
        };

        private static AbstractItem RollRandomDrop()
        {
            int roll = Rng.Next(100);
            ItemFactory.StillType? drop = roll switch
            {
                // < 25 => ItemFactory.StillType.Heart,       // 25%
                // < 40 => ItemFactory.StillType.GoldRupee,   // 15%
                // < 50 => ItemFactory.StillType.PurpleRupee, // 10%
                // < 55 => ItemFactory.StillType.Fairy,       //  5%
                // _    => null,                              // 45% nothing
                // For testing 100% drops:
                < 25 => ItemFactory.StillType.Heart,       
                < 50 => ItemFactory.StillType.GoldRupee,   
                < 75 => ItemFactory.StillType.PurpleRupee, 
                <= 100 => ItemFactory.StillType.Fairy,
                _ => null,      
            };
            return drop.HasValue ? ItemFactory.CreateStillItem(drop.Value, Vector2.Zero, scale: GameServices.ScaleFactor) : null;
        }

        // skipRandomDrop: pass true when the enemy has a CarriedItem so it doesn't also roll a random drop
        public IEnemy CreateEnemy(EnemyType type, Vector2 position, List<BlockType> solidBlocks, Rectangle innerBounds,
            Action<AbstractItem> onItemDropped = null, bool skipRandomDrop = false)
        {
            IEnemy enemy = type switch
            {
            EnemyType.Goriya     => new Goriya(enemySpriteSheet, position, contentManager, solidBlocks, innerBounds),
            EnemyType.Dodongo    => new Dodongo(bossSpriteSheet, position, solidBlocks, innerBounds),
            EnemyType.Stalfos    => new Stalfos(enemySpriteSheet, position, solidBlocks, innerBounds),
            EnemyType.Rope       => new Rope(enemySpriteSheet, position, solidBlocks, innerBounds),
            EnemyType.Gel        => new Gel(enemySpriteSheet, position, solidBlocks, innerBounds),
            EnemyType.Zol        => new Zol(enemySpriteSheet, position, solidBlocks, innerBounds),
            EnemyType.Aquamentus => new Aquamentus(bossSpriteSheet, position, solidBlocks, innerBounds),
            EnemyType.Keese      => new Keese(enemySpriteSheet, position, innerBounds),
            EnemyType.WallMaster => new WallMaster(enemySpriteSheet, position, solidBlocks, innerBounds),
            EnemyType.Trap       => new Trap(enemySpriteSheet, position),
            EnemyType.OldMan     => new OldMan(NPCSheet, position),
            EnemyType.FlameLeft  => new FlameLeft(NPCSheet, position),
            EnemyType.FlameRight => new FlameRight(NPCSheet, position),
				_            => new Goriya(enemySpriteSheet, position, contentManager, solidBlocks, innerBounds),
            };

            if (type == EnemyType.OldMan)
                return enemy;

            AbstractItem drop = skipRandomDrop ? null : CreateDrop(type);
            bool skipSpawnCloud = type is EnemyType.Aquamentus or EnemyType.Dodongo or EnemyType.WallMaster or EnemyType.Trap or EnemyType.Gel;
            return WrapWithEffects(enemy, position, skipSpawnCloud, drop, onItemDropped);
        }

        private EnemyEffectWrapper WrapWithEffects(IEnemy enemy, Vector2 position, bool skipSpawnCloud = false,
            AbstractItem droppedItem = null, Action<AbstractItem> onItemDropped = null)
        {
            var spawnSprite = skipSpawnCloud ? null : new AnimatedSprite(linkSheet, position, [138, 155, 172], 185, 16, 16, 0.5f);
            var deathSprite = new AnimatedSprite(dustSheet, position, [0, 16, 32, 48], 0, 14, 15, 0.3f);
            return new EnemyEffectWrapper(enemy, spawnSprite, deathSprite, droppedItem, onItemDropped);
        }
    }
}
