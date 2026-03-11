using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Sprint.Block;

public class BlockManager
{
    private readonly List<Block> blocks = [];
	public List<Block> blocksList => blocks;
	public void Add(Block block)
    {
        blocks.Add(block);
    }

    public void Update(GameTime gameTime)
    {
        foreach (var block in blocks)
            block.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        foreach (var block in blocks)
            block.Draw(spriteBatch);
    }
}