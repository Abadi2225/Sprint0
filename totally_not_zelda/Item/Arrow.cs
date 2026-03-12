using Microsoft.Xna.Framework;

using Sprint.Sprites;

namespace Sprint.Item;

internal class Arrow : AbstractItem
{
    public Arrow(Rectangle texMask, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale) : base("Arrow", GameServices.ItemSheet, pos)
    {
        sprite = new ProjectileSprite(texture, texMask, pos, vel, maxDistance, rotation, origin, scale);
    }

    public Arrow StartMoving()
    {
        if (sprite is ProjectileSprite psprite)
        {
            psprite.StartMoving();
        }
        return this;
    }

    public override bool IsFinished => sprite is ProjectileSprite p && p.ReachedMaxDistance;
}
