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

    public delegate void SetUseAction(Character.Link player);
    public SetUseAction UseAction;

    public Vector2 Position
    {
        get => DrawPos;
        set
        {
            DrawPos = value;
            if (sprite != null)
            {
                sprite.Position = value;
            }
        }
    }

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

    public virtual void Use(Character.Link player)
    {
        UseAction?.Invoke(player);
    }

    public virtual void Draw(SpriteBatch sb, Vector2 pos)
    { }

    public virtual int Update(GameTime time)
    {
        return 0;
    }
}
