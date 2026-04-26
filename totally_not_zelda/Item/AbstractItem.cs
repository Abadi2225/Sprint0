using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

public abstract class AbstractItem : IItem
{
    protected Texture2D texture;
    private Vector2 position;

    public Vector2 Position
    {
        get => position;
        set
        {
            position = value;
            if (sprite != null)
            {
                sprite.Position = value;
            }
            Rect = new Rectangle((int)value.X, (int)value.Y, Rect.Width, Rect.Height);
        }
    }

    public string Name { get; }
    public Rectangle Rect { get; protected set; } = Rectangle.Empty;
    public Rectangle SourceRect { get; protected set; }
    public virtual bool IsCollected => false;
    protected bool cancelled;
    public void Cancel() => cancelled = true;
    public virtual bool IsFinished => cancelled;

    public virtual bool DamagesEnemies => false;
    public virtual bool DamagesPlayer => false;
    public virtual bool StopsOnHit => false;
    public virtual void OnEnemyHit() { }

    protected IPositionedSprite sprite;

    public AbstractItem(string name, Texture2D texture, Vector2 position)
    {
        Name = name;
        this.texture = texture;
        Position = position;
    }

    public virtual void OnCollect(ILink link) { }

    public virtual void Draw(SpriteBatch sb, Vector2 location)
    {
        sprite?.Draw(sb, position);
    }

    public virtual void Update(GameTime time)
    {
        sprite?.Update(time);
    }
}
