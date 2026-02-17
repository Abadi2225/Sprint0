using Sprint.Interfaces;

namespace Sprint.Item;

public abstract class AbstractItem
{
    public string Id { get; }
    public string DisplayName { get; }
    public int StackLimit { get; set; }
    public ISprite Sprite { get; }

    public AbstractItem(string id, string displayName, int stackLimit, ISprite sprite)
    {
        Id = id;
        DisplayName = displayName;
        StackLimit = stackLimit;
        Sprite = sprite;
    }

    public abstract void Use();
    public abstract void Draw();
}
