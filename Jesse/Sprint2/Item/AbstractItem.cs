namespace Sprint.Item;

public abstract class AbstractItem
{
    public string Id { get; }
    public string DisplayName { get; }
    public int StackLimit { get; set; }

    public AbstractItem(string id, string displayName, int stackLimit)
    {
        Id = id;
        DisplayName = displayName;
        StackLimit = stackLimit;
    }

    public abstract void Use();
}
