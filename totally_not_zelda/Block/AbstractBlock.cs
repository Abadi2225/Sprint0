using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Block;

internal abstract class AbstractBlock : ISprite
{
    protected Texture2D texture;
    public ISprite Sprite { get; set; }
    public Vector2 Position { get; set; }
    public bool Walkable { get; set; }

    public AbstractBlock(ContentManager content, string resourceName, Vector2 pos, bool walkable)
    {
        texture = content.Load<Texture2D>(resourceName);
        Position = pos;
        Walkable = walkable;
    }

    public virtual void Draw(SpriteBatch sb, Vector2 pos)
    {
        Sprite?.Draw(sb, Position);
    }

    public virtual int Update(GameTime time)
    {
        return 0;
    }
}
