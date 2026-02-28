using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Block;

internal class Block : AbstractBlock
{
    internal const int DEFAULT_TILE_WIDTH = 32;

    public Block(Texture2D texture, Vector2 pos, Rectangle textureMask, int width = DEFAULT_TILE_WIDTH)
     : base(texture, pos, walkable: false)
    {
        Sprite = new TileSprite(
                texture,
                textureMask,
                pos,
                width
                );
    }
}
