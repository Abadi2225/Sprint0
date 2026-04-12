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
    void StartPickUpWeapon(Rectangle itemRect);
    void StartPickUpTriforce();
    int Keys { get; }
    void AddKey();
    bool UseKey();
    void TakeDamage(int amount);
    void GetHealed(int amount);
    void IncreaseRubies(int amount);
    public bool IsGrabbed { get; set; }
}