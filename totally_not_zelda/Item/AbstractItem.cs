using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal abstract class AbstractItem : IItem
{
    protected Texture2D texture;
    private Vector2 position;

    public Vector2 Position
    {
        get => position;
        set
        {
            position = value;
            Rect = new Rectangle((int)value.X, (int)value.Y, Rect.Width, Rect.Height);
        }
    }

    public string Name { get; }
    public Rectangle Rect { get; protected set; } = Rectangle.Empty;
    public virtual bool IsCollected => false;
    public virtual bool IsFinished => false;

    protected ISprite sprite;

    public AbstractItem(string name, ContentManager contentManager, string resourceName, Vector2 position)
    {
        Name = name;
        texture = contentManager.Load<Texture2D>(resourceName);
        Position = position;
    }

    public virtual void OnCollect(ILink link) { }

    public virtual void Draw(SpriteBatch sb, Vector2 location)
    {
        sprite?.Draw(sb, Vector2.Zero);
    }

    public virtual void Update(GameTime time)
    {
        sprite?.Update(time);
    }
}
