using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Block;

internal abstract class AbstractBlock : IBlock
{
    protected readonly Texture2D texture;
    public IPositionedSprite Sprite { get; protected init; }
    public bool Walkable { get; init; }
    public Rectangle Rect { get; private set; }

    private readonly int size;
    private Vector2 position;
    public Vector2 Position
    {
        get => position;
        set
        {
            position = value;
            Rect = new Rectangle((int)value.X, (int)value.Y, size, size);
            if (Sprite != null)
                Sprite.Position = value;
        }
    }

    protected AbstractBlock(Texture2D texture, Vector2 pos, int size, bool walkable)
    {
        this.texture = texture;
        this.size = size;
        Walkable = walkable;
        Position = pos;
    }

    public virtual void Draw(SpriteBatch sb, Vector2 location)
    {
        Sprite?.Draw(sb, location);
    }

    public virtual void Update(GameTime time)
    {
    }
}
