using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Sprint.Block;

public class BlockManager
{
    private List<Block> blocks = new();

    public BlockManager()
    {
        
    }

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