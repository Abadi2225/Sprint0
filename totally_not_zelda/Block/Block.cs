using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Block;

internal class Block : AbstractBlock
{
    private const string ResourceName = "blocks/tiles";

    public Block(ContentManager content, Vector2 pos, Rectangle textureMask, int width = 32) : base(content, ResourceName, pos, false)
    {
        Sprite = new TileSprite(
                texture,
                textureMask,
                pos,
                width
                );
    }
}
