using System.Collections.Generic;
using Sprint.Interfaces;

namespace Sprint.Collision;

public class CollisionManager
{
    private readonly List<ICollisionHandler> handlers = [];

    public void Add(ICollisionHandler handler)
    {
        handlers.Add(handler);
    }

    public void HandleAll()
    {
        foreach (var handler in handlers)
            handler.Handle();
    }
}
