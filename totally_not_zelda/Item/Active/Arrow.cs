using Microsoft.Xna.Framework;

using Sprint.Sprites;

namespace Sprint.Item;

internal class Arrow : AbstractItem
{
    private const int HITBOX_SIZE = 10;

    private bool hitEnemy = false;

    public Arrow(Rectangle sourceRect, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale) : base("Arrow", GameServices.ItemSheet, pos)
    {
        sprite = new ProjectileSprite(texture, sourceRect, pos, vel, maxDistance, rotation, origin, scale);
        Rect = new Rectangle((int)pos.X, (int)pos.Y, HITBOX_SIZE, HITBOX_SIZE);
    }

    public Arrow StartMoving()
    {
        if (sprite is ProjectileSprite psprite)
        {
            psprite.StartMoving();
        }
        return this;
    }

    public void MarkHit() => hitEnemy = true;

    public override void Update(GameTime time)
    {
        base.Update(time);
        if (sprite is ProjectileSprite p)
            Position = p.Position;
    }

    public override bool IsFinished => hitEnemy || (sprite is ProjectileSprite p && p.ReachedMaxDistance);
}
