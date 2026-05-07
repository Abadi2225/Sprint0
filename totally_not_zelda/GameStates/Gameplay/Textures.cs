using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.GameStates.Gameplay;

internal class Textures
{
    public Texture2D fontSheet { get; } = GameServices.Content.Load<Texture2D>("images/Fonts");
    public Texture2D linkSheet { get; } = GameServices.Content.Load<Texture2D>("images/Link");
    public Texture2D enemiesSheet { get; } = GameServices.Content.Load<Texture2D>("images/enemiesSheet");
    public Texture2D bossesSheet { get; } = GameServices.Content.Load<Texture2D>("images/BossesSpriteSheet");
    public Texture2D dustSheet { get; } = GameServices.Content.Load<Texture2D>("images/dustSheet");
    public Texture2D NPCSheet { get; } = GameServices.Content.Load<Texture2D>("images/NPC");
    public Texture2D outerWallsTexture { get; } = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonOuterWalls");
    public Texture2D innerWallsTexture { get; } = GameServices.Content.Load<Texture2D>("dungeonWalls/ZeldaDungeonInnerWalls");
    public Texture2D staircaseTexture { get; } = GameServices.Content.Load<Texture2D>("dungeonWalls/Underground");
    public Texture2D hudElements { get; } = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
    public Texture2D doorSheet = GameServices.Content.Load<Texture2D>("blocks/Doors");
    public Texture2D pixel { get; } = new Texture2D(GameServices.GraphicsDevice, 1, 1);

    public Textures()
    {
        pixel.SetData([Color.White]);
    }

    public void UpdateGlobalRefs()
    {
        GameServices.ItemSheet = GameServices.Content.Load<Texture2D>("items/sheet");
        GameServices.LinkSheet = linkSheet;
        GameServices.BoomerangSheet = GameServices.Content.Load<Texture2D>("items/boomerang");
        GameServices.TileSheet = GameServices.Content.Load<Texture2D>("blocks/tiles");
    }
}
