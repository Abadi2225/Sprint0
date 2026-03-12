using Microsoft.Xna.Framework;

using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Item;

internal class Boomerang : AbstractItem
{
    public Boomerang(Vector2 pos, Vector2 vel, float maxDistance) : base("Boomerang", GameServices.BoomerangSheet, pos)
    {
        sprite = new BoomerangSprite(texture, Position, vel, maxDistance, 0.2f);
    }

    public Boomerang StartMoving()
    {
        if (sprite is BoomerangSprite bsprite)
        {
            bsprite.Throw();
        }
        return this;
    }

    public override bool IsFinished => sprite is BoomerangSprite b && !b.IsActive;

    public ISprite GetSprite() => sprite;
}
