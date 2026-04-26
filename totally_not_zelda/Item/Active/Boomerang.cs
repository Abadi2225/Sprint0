using Microsoft.Xna.Framework;
using Sprint.Sprites;

namespace Sprint.Item;

public class Boomerang : AbstractItem
{
    private const int HITBOX_SIZE = 14;

    private readonly bool damagesEnemies;
    private readonly bool damagesPlayer;

    public Boomerang(Vector2 pos, Vector2 vel, float maxDistance,
        bool damagesEnemies = true, bool damagesPlayer = false)
        : base("Boomerang", GameServices.BoomerangSheet, pos)
    {
        sprite = new BoomerangSprite(texture, Position, vel, maxDistance, 0.2f);
        SourceRect = new Rectangle(129, 3, 4, 7);
        Rect = new Rectangle((int)pos.X, (int)pos.Y, HITBOX_SIZE, HITBOX_SIZE);
        this.damagesEnemies = damagesEnemies;
        this.damagesPlayer = damagesPlayer;
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

    public override bool IsFinished => base.IsFinished || (sprite is BoomerangSprite b && b.WasThrown && !b.IsActive);

    public override bool DamagesEnemies => damagesEnemies;
    public override bool DamagesPlayer => damagesPlayer;
}
