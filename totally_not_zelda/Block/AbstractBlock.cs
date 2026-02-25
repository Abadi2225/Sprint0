using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Block;

internal abstract class AbstractBlock : ISprite
{
    protected readonly Texture2D texture;
    public ISprite Sprite { get; protected init; }
    public Vector2 Position { get; set; }
    public bool Walkable { get; init; }

    protected AbstractBlock(ContentManager content, string resourceName, Vector2 pos, bool walkable)
    {
        texture = content.Load<Texture2D>(resourceName);
        Position = pos;
        Walkable = walkable;
    }

    public virtual void Draw(SpriteBatch sb, Vector2 location)
    {
        Sprite?.Draw(sb, location);
    }

    public virtual void Update(GameTime time)
    {
    }
}
