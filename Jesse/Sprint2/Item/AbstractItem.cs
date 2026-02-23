using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal abstract class AbstractItem : ISprite
{
    protected Texture2D texture;
    public Vector2 DrawPos { get; set; }
    public string Name { get; }
    public string DisplayName { get; }

    public ISprite sprite;

    public delegate void UseActionDelegate(ISprite entity);
    public UseActionDelegate UseAction;

    public Vector2 Position { get; set; } // unused

    private AbstractItem(string name)
    {
        Name = name;
        DrawPos = new Vector2(0f, 0f);
    }

    public AbstractItem(string name, ContentManager contentManager, string resourceName, Vector2 drawPos) : this(name)
    {
        texture = contentManager.Load<Texture2D>(resourceName);
        DrawPos = drawPos;
    }

    public virtual void SetDefaultUseAction()
    {
        UseAction = null;
    }

    public AbstractItem SetUseAction(UseActionDelegate useAction)
    {
        UseAction = useAction;
        return this;
    }

    public virtual void Use(ISprite entity)
    {
        UseAction?.Invoke(entity);
    }

    public virtual void Draw(SpriteBatch sb, Vector2 pos)
    {
        sprite.Draw(sb, Vector2.Zero);
    }

    public virtual int Update(GameTime time)
    {
        return 0;
    }
}
