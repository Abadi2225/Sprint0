using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Sprint.Interfaces;

namespace Sprint.UI;

class UIManager
{
    private List<IUIElement> elements;

    public UIManager()
    {
        elements = new List<IUIElement>();
    }

    public void Update(GameTime gameTime)
    {
        foreach(var e in elements)
            e.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        foreach(var e in elements)
            e.Draw(spriteBatch);
    }

    public void AddElement(IUIElement element)
    {
        elements.Add(element);
    }

    public void RemoveElement(IUIElement element)
    {
        elements.Remove(element);
    }

    public void Clear()
    {
        elements.Clear();
    }
}
