using Sprint.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Sprint.UI;

public class DungeonWalls : IUIElement
{
    private Texture2D texture;
    private float scale;

    // Door and center cutout coordinates
    private const int TOP_DOOR_LEFT = 112;
    private const int TOP_DOOR_RIGHT = 144;
    private const int TOP_DOOR_BOTTOM = 31;

    private const int LEFT_DOOR_TOP = 72;
    private const int LEFT_DOOR_BOTTOM = 104;
    private const int LEFT_DOOR_RIGHT = 31;

    private const int BOTTOM_DOOR_LEFT = 112;
    private const int BOTTOM_DOOR_RIGHT = 144;
    private const int BOTTOM_DOOR_TOP = 144;

    private const int RIGHT_DOOR_LEFT = 224;
    private const int RIGHT_DOOR_TOP = 72;
    private const int RIGHT_DOOR_BOTTOM = 104;

    private const int CENTER_TOP = 31;
	private const int CENTER_BOTTOM = 144;
	private const int CENTER_LEFT = 31;
	private const int CENTER_RIGHT = 224;

    private const int SHEET_WIDTH = 256;
    private const int SHEET_HEIGHT = 176;
    private readonly float hudHeight = 48 * GameServices.ScaleFactor;

    public DungeonWalls(Texture2D texture)
    {
        this.texture = texture;
        this.scale = GameServices.ScaleFactor;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        // Top-left corner
        DrawSection(spriteBatch, 0, 0, TOP_DOOR_LEFT, TOP_DOOR_BOTTOM);

        // Top door opening (red) - skip center, draw just the border above it
        // Top-right corner
        DrawSection(spriteBatch, TOP_DOOR_RIGHT, 0, SHEET_WIDTH - TOP_DOOR_RIGHT, TOP_DOOR_BOTTOM);

        // Left wall top (above left door)
        DrawSection(spriteBatch, 0, TOP_DOOR_BOTTOM, LEFT_DOOR_RIGHT, LEFT_DOOR_TOP - TOP_DOOR_BOTTOM);

        // Left door opening (yellow) - skip
        // Left wall bottom (below left door)
        DrawSection(spriteBatch, 0, LEFT_DOOR_BOTTOM, LEFT_DOOR_RIGHT, BOTTOM_DOOR_TOP - LEFT_DOOR_BOTTOM);

        // Right wall top (above right door)
        DrawSection(spriteBatch, RIGHT_DOOR_LEFT, TOP_DOOR_BOTTOM, SHEET_WIDTH - RIGHT_DOOR_LEFT, RIGHT_DOOR_TOP - TOP_DOOR_BOTTOM);

        // Right door opening (blue) - skip
        // Right wall bottom (below right door)
        DrawSection(spriteBatch, RIGHT_DOOR_LEFT, RIGHT_DOOR_BOTTOM, SHEET_WIDTH - RIGHT_DOOR_LEFT, BOTTOM_DOOR_TOP - RIGHT_DOOR_BOTTOM);

        // Bottom-left corner
        DrawSection(spriteBatch, 0, BOTTOM_DOOR_TOP, BOTTOM_DOOR_LEFT, SHEET_HEIGHT - BOTTOM_DOOR_TOP);

        // Bottom door opening (green) - skip
        // Bottom-right corner
        DrawSection(spriteBatch, BOTTOM_DOOR_RIGHT, BOTTOM_DOOR_TOP, SHEET_WIDTH - BOTTOM_DOOR_RIGHT, SHEET_HEIGHT - BOTTOM_DOOR_TOP);
    }

	public Rectangle InnerBounds =>
    new Rectangle(
        (int)(CENTER_LEFT * scale),
        (int)((CENTER_TOP * scale) + hudHeight),
        (int)((CENTER_RIGHT - CENTER_LEFT) * scale),
        (int)((CENTER_BOTTOM - CENTER_TOP) * scale)
	);

    // Door opening ranges in screen coordinates
    public int TopDoorLeft => (int)(TOP_DOOR_LEFT * scale);
    public int TopDoorRight => (int)(TOP_DOOR_RIGHT * scale);
    public int SideDoorTop => (int)(LEFT_DOOR_TOP * scale) + (int)hudHeight;
    public int SideDoorBottom => (int)(LEFT_DOOR_BOTTOM * scale) + (int)hudHeight;
    public int SideDoorEntryBottom => SideDoorBottom - (int)(8 * scale);

    // How far (in screen pixels) Link must walk into a wall opening before the room transitions.
    public int DoorExitDepth  => (int)(15 * scale);

	private void DrawSection(SpriteBatch spriteBatch, int srcX, int srcY, int srcW, int srcH)
    {
        Rectangle source = new Rectangle(srcX, srcY, srcW, srcH);
        Vector2 dest = new Vector2(srcX * scale, (srcY * scale) + hudHeight);
        spriteBatch.Draw(texture, dest, source, Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
    }

    public void Update(GameTime gameTime) { }
}