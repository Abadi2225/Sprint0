using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Block;

internal class Block : AbstractBlock
{
    internal int tileWidth = (int)(16 * GameServices.ScaleFactor);

    public Block(Texture2D texture, Vector2 pos, Rectangle textureMask)
     : this(texture, pos, textureMask, (int)(16 * GameServices.ScaleFactor))
    {
    }

    public Block(Texture2D texture, Vector2 pos, Rectangle textureMask, int width)
     : base(texture, pos, width, walkable: false)
    {
        Sprite = new TileSprite(
                texture,
                textureMask,
                pos,
                width
                );
    }
}
