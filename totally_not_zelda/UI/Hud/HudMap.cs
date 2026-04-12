using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.UI.Hud;

internal class HudMap
{
    private static readonly int WIDTH = 64;
    private static readonly int HEIGHT = 32;
    private static readonly int MAP_Y_OFFSET = 4;
    private static readonly int NODE_WIDTH = 8;
    private static readonly int NODE_HEIGHT = 4;
    private static readonly int DOT_X_OFFSET = 3;
    private static readonly int ROWS = HEIGHT / NODE_HEIGHT;
    private static readonly int COLS = WIDTH / NODE_WIDTH;
    private static readonly Texture2D spriteSheet = GameServices.Content.Load<Texture2D>("images/ZeldaUIElements");
    private static readonly Rectangle nodeTextureMask = new Rectangle(663, 108, NODE_WIDTH, NODE_HEIGHT);
    private static readonly Rectangle disabledTextureMask = new Rectangle(519, 9, 64, 32);
    private static readonly Rectangle frameTextureMask = new Rectangle(584, 1, 64, 40);
    private static readonly Rectangle linkDotMask = new Rectangle(519, 126, 3, 3);
    private static readonly Rectangle triforceDotMask = new Rectangle(537, 126, 3, 3);


    public int X { get; set; }
    public int Y { get; set; }

    private StaticSprite frame;
    private NumberDisplay levelNumber;
    private StaticSprite disabledOverlay;
    private StaticSprite[,] map = new StaticSprite[ROWS, COLS];
    private StaticSprite linkDot;
    private StaticSprite triforceDot;
    // positions relative to the starting room provided in constructor
    private int startingRoomPos;
    private int linkPos;
    private int triforcePos;
    public bool Enabled { get; set; }
    public bool ShowTriforceLoc { get; set; }
    public int LevelNum { get; set; }

    public HudMap(int x, int y, string startingRoomName, int startingRoomPos, int linkPos, int triforcePos, bool enabled, bool showTriforceLoc, int levelNum = 1)
    {
        X = x;
        Y = y;
        this.startingRoomPos = startingRoomPos;
        this.linkPos = linkPos;
        this.triforcePos = triforcePos;
        Enabled = enabled;
        ShowTriforceLoc = showTriforceLoc;
        LevelNum = levelNum;

        // sprites
        frame = new StaticSprite(
                spriteSheet,
                new Vector2(X, Y),
                frameTextureMask
                );
        levelNumber = new NumberDisplay(
                spriteSheet,
                new Vector2(X + 48 * GameServices.ScaleFactor, Y),
                LevelNum
                );
        disabledOverlay = new StaticSprite(
                spriteSheet,
                new Vector2(X, Y + 8 * GameServices.ScaleFactor),
                disabledTextureMask
                );
        linkDot = new StaticSprite(
                spriteSheet,
                getDotPosition(linkPos),
                linkDotMask
                );
        triforceDot = new StaticSprite(
                spriteSheet,
                getDotPosition(getRow(triforcePos), getCol(triforcePos)),
                triforceDotMask
                );
        MapGraph.Node graph = MapGraph.buildGraph(startingRoomName);
        fillMap(graph, getRow(this.startingRoomPos), getCol(this.startingRoomPos));
    }

    public void UpdateLinkMapPos(string direction)
    {
        int newPos = linkPos;
        switch (direction)
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
            linkDot.Position = getDotPosition(linkPos);
        }
    }

    public void Draw(SpriteBatch sb)
    {
        frame.Draw(sb, frame.Position);
        levelNumber.Draw(sb);
        drawMap(sb);
        if (!Enabled)
        {
            disabledOverlay.Draw(sb, disabledOverlay.Position);
        }
        if (ShowTriforceLoc)
        {
            triforceDot.Draw(sb, triforceDot.Position);
        }
        linkDot.Draw(sb, linkDot.Position);
    }

    public void Update(GameTime time) { }

    // DFS traversal
    private void fillMap(MapGraph.Node node, int row, int col)
    {
        if (node == null) return;
        if (row >= ROWS) return;
        if (col >= COLS) return;
        if (map[row, col] != null) return;  // visited check

        map[row, col] = new StaticSprite(
                spriteSheet,
                getPosition(row, col),
                nodeTextureMask
                );

        fillMap(node.north, row - 1, col);
        fillMap(node.south, row + 1, col);
        fillMap(node.west, row, col - 1);
        fillMap(node.east, row, col + 1);

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
        return new Vector2(
                X + (col * NODE_WIDTH) * GameServices.ScaleFactor,
                Y + (MAP_Y_OFFSET + row * NODE_HEIGHT) * GameServices.ScaleFactor
                );
    }

    private Vector2 getDotPosition(int pos)
    {
        return getDotPosition(
                getRow(pos), getCol(pos)
                );
    }
    private Vector2 getDotPosition(int row, int col)
    {
        return new Vector2(
                X + (col * NODE_WIDTH + DOT_X_OFFSET) * GameServices.ScaleFactor,
                Y + (MAP_Y_OFFSET + row * NODE_HEIGHT) * GameServices.ScaleFactor
                );
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
