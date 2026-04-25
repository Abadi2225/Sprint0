using Sprint.Interfaces;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint.Sprites;
using Sprint.Block;

namespace Sprint.UI;

public class OuterDungeonWalls : IUIElement
{
    private StaticSprite background;
    private Rectangle sourceRect;
    private readonly float scale;
    private readonly float hudHeight;

    private const int TOP_DOOR_LEFT = 112;
    private const int TOP_DOOR_RIGHT = 144;

    private const int LEFT_DOOR_TOP = 72;
    private const int LEFT_DOOR_BOTTOM = 104;

    private const int CENTER_TOP = 31;
    private const int CENTER_BOTTOM = 144;
    private const int CENTER_LEFT = 31;
    private const int CENTER_RIGHT = 224;

    public OuterDungeonWalls(Texture2D backgroundTexture)
    {
        scale = GameServices.ScaleFactor;
        hudHeight = 48 * scale;
        sourceRect = new Rectangle(0, 0, 256, 176);
        background = new StaticSprite(backgroundTexture, new Vector2(0, 0), sourceRect, BlockFactory.tileColors[GameServices.CurrentDungeon]);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        background.Draw(spriteBatch, new Vector2(0, hudHeight));
    }

    public void Update(GameTime gameTime) { }

    public Rectangle InnerBounds =>
        new Rectangle(
            (int)(CENTER_LEFT * scale),
            (int)(CENTER_TOP * scale + hudHeight),
            (int)((CENTER_RIGHT - CENTER_LEFT) * scale),
            (int)((CENTER_BOTTOM - CENTER_TOP) * scale)
        );

	public Rectangle OuterBounds =>
	    new Rectangle(
		    0,
		    (int)hudHeight,
		    (int)(256 * scale),
		    (int)(176 * scale)
	    );

	public int TopDoorLeft => (int)(TOP_DOOR_LEFT * scale);
    public int TopDoorRight => (int)(TOP_DOOR_RIGHT * scale);
    public int SideDoorTop => (int)(LEFT_DOOR_TOP * scale) + (int)hudHeight;
    public int SideDoorBottom => (int)(LEFT_DOOR_BOTTOM * scale) + (int)hudHeight;
    public int SideDoorEntryBottom => SideDoorBottom - (int)(8 * scale);
    public int BottomDoorLeft => (int)(TOP_DOOR_LEFT * scale);
    public int BottomDoorRight => (int)(TOP_DOOR_RIGHT * scale);
    public int BottomDoorTop => (int)(CENTER_BOTTOM * scale) + (int)hudHeight;
    public int DoorExitDepth => (int)(15 * scale);
}
