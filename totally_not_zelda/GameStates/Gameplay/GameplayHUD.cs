using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Character;
using Sprint.Item;
using Sprint.Levels;
using Sprint.UI;
using Sprint.UI.InventoryElements;
using Sprint.UI.Text;

namespace Sprint.GameStates.Gameplay
{
    internal class GameplayHUD
    {
        private readonly UIManager uiManager;
        private readonly HUDBar hud;
        private readonly TriforceOverlay triforceOverlay;
        private readonly InnerDungeonWalls innerWalls;
        private TextWriterSequence NPCText;

        public UIManager UIManager => uiManager;
        public HUDBar HUD => hud;
        public InventoryMap InvMap { get; private set; }

        public GameplayHUD(
            Texture2D fontSheet,
            Texture2D hudElements,
            Texture2D innerWallsTexture,
            Texture2D pixel,
            Link link,
            Inventory inventory,
            LevelLoader levelLoader,
            OuterDungeonWalls dungeonWalls)
        {
            uiManager = new UIManager();
            innerWalls = new InnerDungeonWalls(innerWallsTexture);

            uiManager.AddElement(dungeonWalls);

            hud = new HUDBar(0, 0, inventory, hudElements);
            GameServices.hudMap = hud.Map;
            uiManager.AddElement(hud);

            triforceOverlay = new TriforceOverlay(link, pixel);

            InvMap = new InventoryMap(levelLoader.GetCurrentLevel(), levelLoader.GetCurrentLevelGridLoc(), false);
            GameServices.inventoryMap = InvMap;

        }

        public void Update(GameTime gameTime, bool isNPCRoom)
        {
            uiManager.Update(gameTime);

            if (isNPCRoom)
                NPCText?.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch, bool isUnderground, bool isNPCRoom)
        {
            if (!isUnderground)
                innerWalls.Draw(spriteBatch);

            uiManager.Draw(spriteBatch);

            if (isNPCRoom)
                NPCText?.Draw(spriteBatch);

            triforceOverlay.Draw(spriteBatch);
        }

        public void DrawHUDOnly(SpriteBatch spriteBatch) => hud.Draw(spriteBatch);

        public void DrawInnerWalls(SpriteBatch spriteBatch) => innerWalls.Draw(spriteBatch);

        public void RefreshWallColor() => innerWalls.RefreshColor();

        public void ResetMaps(LevelLoader levelLoader, int dungeon)
        {
            InvMap = new InventoryMap(levelLoader.GetCurrentLevel(), levelLoader.GetCurrentLevelGridLoc(), false);
            GameServices.inventoryMap = InvMap;
            hud.SetMap(levelLoader.GetCurrentLevelName(), LevelLoader.getTriforceGridLoc(dungeon), false, dungeon);
        }

        public void UpdateNPCText(Texture2D fontSheet, LevelData currentLevelData, int dungeon)
        {
            if (currentLevelData?.npcText != null && currentLevelData.npcText.Length > 0)
            {
                NPCText = new TextWriterSequence(
                    TextWriter.CreateNPCText(fontSheet, currentLevelData.npcText, dungeon));
            }
            else
            {
                NPCText = null;
            }
        }
    }
}
