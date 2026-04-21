using Microsoft.Xna.Framework;
using Sprint.Character;

namespace Sprint.Interfaces;

public interface ILink
{
    Vector2 Position { get; set; }
    Rectangle Rect { get; }
    Rectangle BlockRect { get; }
    Directions Facing { get; }
    int Health { get; }
    int MaxHealth { get; }
    Rectangle SwordRect { get; }
    bool TriforceActive { get; }
    double TriforceTimer { get; }  
    void StartAttack();
    void StartUseItem();
    void StartPickUpWeapon(Rectangle itemRect);
    void StartPickUpTriforce(Rectangle itemRect);
    bool ShouldEndTriforceSequence();
    void EndTriforceSequence();
    int Keys { get; }
    void AddKey();
    bool UseKey();
    void AddBomb();
    void TakeDamage(int amount);
    void GetHealed(int amount);
    void AddHeartContainer();
    void IncreaseRubies(int amount);
    public bool IsGrabbed { get; set; }
    void StopMove();
}
