using Microsoft.Xna.Framework;
using Sprint.Character;

namespace Sprint.Interfaces;

public interface ILink
{
    Vector2 Position { get; set; }
    Rectangle Rect { get; }
    Directions Facing { get; }
    int Health { get; }
    int MaxHealth { get; }
    Rectangle SwordRect { get; }
    void StartAttack();
    void StartUseItem();
    void TakeDamage(int amount);
}