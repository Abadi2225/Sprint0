using Microsoft.Xna.Framework;

namespace Sprint.Interfaces;

public interface IItem : IPositionedSprite
{
    string Name { get; }
    Rectangle Rect { get; }
    bool IsCollected { get; }
    void OnCollect(ILink link);
    int ID { get; set; }
}
