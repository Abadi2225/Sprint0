using Sprint.Character;

namespace Sprint.Interfaces;

public interface ILink : IPositionedSprite
{
	Directions Facing{ get; }
	void StartAttack();
}
