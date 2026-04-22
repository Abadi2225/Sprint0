using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Character;
using Sprint.Doors;
using Sprint.Interfaces;
using Sprint.Levels;
using Sprint.UI;
using System;

namespace Sprint.GameStates;

internal class RoomTransitionState : IGameState
{
    private readonly Level oldLevel;
    private readonly DoorManager oldDoorManager;
    private readonly Level newLevel;
    private readonly DoorManager newDoorManager;
    private readonly OuterDungeonWalls dungeonWalls;
    private readonly InnerDungeonWalls innerWalls;
    private readonly Link link;
    private readonly GameplayState gameplayState;

    private float elapsed;
    private const float Duration = 2f;

    private readonly Vector2 oldStart;
    private readonly Vector2 newStart;
    private readonly Vector2 scrollDelta;

    private readonly RasterizerState scissorRasterizer;

    public RoomTransitionState(
        Level oldLevel, DoorManager oldDoorManager,
        Level newLevel, DoorManager newDoorManager,
        OuterDungeonWalls dungeonWalls, InnerDungeonWalls innerWalls,
        Link link, string direction, GameplayState gameplayState)
    {
        this.oldLevel = oldLevel;
        this.oldDoorManager = oldDoorManager;
        this.newLevel = newLevel;
        this.newDoorManager = newDoorManager;
        this.dungeonWalls = dungeonWalls;
        this.innerWalls = innerWalls;
        this.link = link;
        this.gameplayState = gameplayState;

        float W = dungeonWalls.OuterBounds.Width;
        float H = dungeonWalls.OuterBounds.Height;

        (oldStart, newStart, scrollDelta) = direction switch
        {
            "east"  => (Vector2.Zero, new Vector2( W, 0), new Vector2(-W,  0)),
            "west"  => (Vector2.Zero, new Vector2(-W, 0), new Vector2( W,  0)),
            "north" => (Vector2.Zero, new Vector2(0, -H), new Vector2( 0,  H)),
            "south" => (Vector2.Zero, new Vector2(0,  H), new Vector2( 0, -H)),
            _       => (Vector2.Zero, Vector2.Zero, Vector2.Zero)
        };

        scissorRasterizer = new RasterizerState
        {
            CullMode = CullMode.None,
            ScissorTestEnable = true
        };
    }

    public void Enter() { }
    public void Exit() { }
    public void LoadContent() { }

    public void Update(GameTime gameTime)
    {
        elapsed += (float)gameTime.ElapsedGameTime.TotalSeconds;
        if (elapsed >= Duration)
            Game1.Instance.ForceState(gameplayState);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.End();

        float t = Math.Min(elapsed / Duration, 1f);
        Vector2 oldOffset = oldStart + scrollDelta * t;
        Vector2 newOffset = newStart + scrollDelta * t;

        GameServices.GraphicsDevice.ScissorRectangle = dungeonWalls.OuterBounds;

        // Old room
        spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend,
            SamplerState.PointClamp, null, scissorRasterizer, null,
            Matrix.CreateTranslation(oldOffset.X, oldOffset.Y, 0));
        dungeonWalls.Draw(spriteBatch);
        gameplayState.DrawRoomContent(spriteBatch, oldLevel, oldDoorManager, true);
        spriteBatch.End();

        // New room with Link
        spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend,
            SamplerState.PointClamp, null, scissorRasterizer, null,
            Matrix.CreateTranslation(newOffset.X, newOffset.Y, 0));
        dungeonWalls.Draw(spriteBatch);
        gameplayState.DrawRoomContent(spriteBatch, newLevel, newDoorManager, true);
        link.Draw(spriteBatch);
        spriteBatch.End();

        // Leave the batch open so Game1's spriteBatch.End() closes it cleanly
        spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend,
            SamplerState.PointClamp, null, null);
        gameplayState.DrawHUDOnly(spriteBatch);
    }
}
