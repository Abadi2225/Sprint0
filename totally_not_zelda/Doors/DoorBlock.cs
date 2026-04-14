using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint.Doors;

public class DoorBlock
{
    // Maps door type name to column index in Doors.png
    private static readonly Dictionary<string, int> TypeColumn = new()
    {
        ["wall"]   = 0,
        ["open"]   = 1,
        ["key"]    = 2,
        ["enemy"]  = 3,
        ["bomb"]   = 4,
    };

    private static readonly Dictionary<string, (int width, int height, int rowX, int rowY)> DirectionInfo = new()
    {
        ["north"] = (32, 32, 36, 10),
        ["west"]  = (32, 32, 36, 43),
        ["east"]  = (32, 32, 36, 76),
        ["south"] = (32, 32, 36, 109),
    };

    // Unscaled screen position of each wall opening
    private static readonly Dictionary<string, Vector2> DoorOrigins = new()
    {
        ["north"] = new Vector2(112,   0),
        ["south"] = new Vector2(112, 144),
        ["west"]  = new Vector2(  0,  72),
        ["east"]  = new Vector2(224,  72),
    };

    private readonly Texture2D texture;
    private readonly Vector2 destination;
    private readonly float scale;
    private readonly int spriteWidth;
    private readonly int spriteHeight;
    private readonly int rowX;
    private readonly int rowY;

    public DoorBlock(Texture2D texture, string direction, float scale, float hudHeight, Vector2? customOrigin = null)
    {
        this.texture = texture;
        this.scale   = scale;

        (spriteWidth, spriteHeight, rowX, rowY) = DirectionInfo[direction];

        Vector2 origin = customOrigin ?? DoorOrigins[direction];
        destination    = new Vector2(origin.X * scale, origin.Y * scale + hudHeight);
    }

    public void Draw(SpriteBatch spriteBatch, string type)
    {
        int col  = TypeColumn[type];
        int srcX = rowX + col * (spriteWidth + 1);
        Rectangle sourceRect = new(srcX, rowY, spriteWidth, spriteHeight);
        spriteBatch.Draw(texture, destination, sourceRect,
            Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
    }
}