using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Level
{
    public BlockManager Blocks { get; private set; }

    public Level(BlockManager blockManager)
    {
        Blocks = blockManager;
    }

    public void Update(GameTime gameTime)
    {
        Blocks.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        Blocks.Draw(spriteBatch);
    }
}