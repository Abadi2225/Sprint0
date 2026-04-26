using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Sprint.Sprites;
using Sprint.Levels;

namespace Sprint.UI.InventoryElements;

internal class InventoryMap
{
    private static readonly Vector2 NODE_OFFSET = new Vector2(128, 8);
    private static readonly Vector2 DOT_OFFSET = new Vector2(2, 2);
    private static readonly int ROWS = 8;
    private static readonly int COLS = 8;
    private static readonly int NODE_WIDTH = 8;
    private static readonly int NODE_HEIGHT = 8;


    private static readonly int NO_DOORS = 0b0000;
    private static readonly int NORTH = 0b0001;
    private static readonly int SOUTH = 0b0010;
    private static readonly int WEST = 0b0100;
    private static readonly int EAST = 0b1000;

    private static readonly Texture2D spriteSheet = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");

    private static readonly Rectangle linkDotMask = new Rectangle(519, 126, 3, 3);
    private static readonly Rectangle[] nodeTypes = new Rectangle[16];
    static InventoryMap()
    {
        nodeTypes[NO_DOORS] = rect(0);
        nodeTypes[EAST] = rect(1);
        nodeTypes[WEST] = rect(2);
        nodeTypes[EAST | WEST] = rect(3);
        nodeTypes[SOUTH] = rect(4);
        nodeTypes[SOUTH | EAST] = rect(5);
        nodeTypes[WEST | SOUTH] = rect(6);
        nodeTypes[WEST | SOUTH | EAST] = rect(7);
        nodeTypes[NORTH] = rect(8);
        nodeTypes[NORTH | EAST] = rect(9);
        nodeTypes[WEST | NORTH] = rect(10);
        nodeTypes[WEST | NORTH | EAST] = rect(11);
        nodeTypes[NORTH | SOUTH] = rect(12);
        nodeTypes[NORTH | EAST | SOUTH] = rect(13);
        nodeTypes[NORTH | SOUTH | WEST] = rect(14);
        nodeTypes[NORTH | EAST | SOUTH | WEST] = rect(15);
    }
    private static Rectangle rect(int index)
    {
        return new Rectangle(519 + index * 9, 108, 8, 8);
    }
    // -------------------------------------------------------------------------------------------------

    public int X { get; set; }
    public int Y { get; set; }

    private int linkPos;
    public bool Enabled { get; set; }

    private StaticSprite[,] map = new StaticSprite[ROWS, COLS];
    private StaticSprite linkDot;

    public InventoryMap(LevelData startingRoom, int linkPos, bool enabled)
    {
        Enabled = enabled;
        this.linkPos = linkPos;
        UpdateInventoryMap(startingRoom, null);  // add current room
        linkDot = new StaticSprite(
                spriteSheet,
                getDotPosition(this.linkPos),
                linkDotMask
                );
    }

    public void Draw(SpriteBatch sb)
    {
        if (Enabled)
        {
            drawMap(sb);
            linkDot.Draw(sb, linkDot.Position);
        }
    }

    public void SetPosition(int x, int y)
    {
        X = x;
        Y = y;

        linkDot.Position = getDotPosition(this.linkPos);
        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                StaticSprite node = map[r, c];
                if (node != null)
                {
                    node.Position = getPosition(r, c);
                }
            }
        }
    }

    public void UpdateInventoryMap(LevelData room, string exitDirection)
    {
        int newPos = linkPos;
        switch (exitDirection)
        {
            case "north":
                newPos -= COLS;
                break;
            case "south":
                newPos += COLS;
                break;
            case "west":
                newPos -= 1;
                break;
            case "east":
                newPos += 1;
                break;
        }
        if (newPos >= 0 && newPos < ROWS * COLS)
        {
            linkPos = newPos;
        }
        else
        {
            return;
        }

        Dictionary<string, string> doors = room.doors;
        int mask = 0;
        if (doors.ContainsKey("north"))
            mask |= NORTH;
        if (doors.ContainsKey("east"))
            mask |= EAST;
        if (doors.ContainsKey("south"))
            mask |= SOUTH;
        if (doors.ContainsKey("west"))
            mask |= WEST;

        Rectangle textureMask = nodeTypes[mask];

        int row = getRow(linkPos);
        int col = getCol(linkPos);

        map[row, col] = new StaticSprite(
                spriteSheet,
                getPosition(row, col),
                textureMask
                );

    }

    public void SetLinkPos(int newPos)
    {
        if (newPos >= 0 && newPos < ROWS * COLS)
        {
            linkPos = newPos;
            linkDot.Position = getDotPosition(linkPos);
        }
    }


    private void drawMap(SpriteBatch sb)
    {
        for (int r = 0; r < ROWS; r++)
        {
            for (int c = 0; c < COLS; c++)
            {
                StaticSprite node = map[r, c];
                if (node != null)
                {
                    node.Draw(sb, node.Position);
                }
            }
        }
    }

    private Vector2 getPosition(int row, int col)
    {
        return new Vector2(X, Y)
            + (NODE_OFFSET
            + new Vector2(
                (col * NODE_WIDTH),
                (row * NODE_HEIGHT)
                )) * GameServices.ScaleFactor;
    }

    private Vector2 getDotPosition(int pos)
    {
        return getDotPosition(getRow(pos), getCol(pos));
    }
    private Vector2 getDotPosition(int row, int col)
    {
        return getPosition(row, col) + DOT_OFFSET * GameServices.ScaleFactor;
    }

    private int getRow(int pos)
    {
        return pos / COLS;
    }
    private int getCol(int pos)
    {
        return pos % COLS;
    }
}
