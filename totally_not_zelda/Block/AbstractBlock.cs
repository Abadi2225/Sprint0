using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Block;

internal abstract class AbstractBlock : IPositionedSprite
{
    protected readonly Texture2D texture;
    public IPositionedSprite Sprite { get; protected init; }
    public bool Walkable { get; init; }

    private Vector2 position;
    public Vector2 Position
    {
        get => position;
        set
        {
            position = value;
            if (Sprite != null)
                Sprite.Position = value;
        }
    }

    protected AbstractBlock(Texture2D texture, Vector2 pos, bool walkable)
    {
        this.texture = texture;
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
