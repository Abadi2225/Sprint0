using Microsoft.Xna.Framework;

using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Item;

internal class Boomerang : AbstractItem
{
    private const int HITBOX_SIZE = 14;

    public Boomerang(Vector2 pos, Vector2 vel, float maxDistance) : base("Boomerang", GameServices.BoomerangSheet, pos)
    {
        sprite = new BoomerangSprite(texture, Position, vel, maxDistance, 0.2f);
        Rect = new Rectangle((int)pos.X, (int)pos.Y, HITBOX_SIZE, HITBOX_SIZE);
    }

    public Boomerang StartMoving()
    {
        if (sprite is BoomerangSprite bsprite)
        {
            bsprite.Throw();
        }
        return this;
    }

    public override void Update(GameTime time)
    {
        base.Update(time);
        if (sprite is BoomerangSprite b)
            Position = b.Position;
    }

    public override bool IsFinished => sprite is BoomerangSprite b && !b.IsActive;

    public ISprite GetSprite() => sprite;
}
