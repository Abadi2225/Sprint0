using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal class Arrow : AbstractItem
{
    private static string ResourceName = "items/sheet";

    public Arrow(Rectangle texMask, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale, ContentManager cm) : base("Arrow", cm, ResourceName, pos)
    {
        sprite = new ProjectileSprite(
                texture,
                texMask,
                pos,
                vel,
                maxDistance,
                rotation,
                origin,
                scale
                );
    }
    public Arrow StartMoving()
    {
        if (sprite is ProjectileSprite psprite)
        {
            psprite.StartMoving();
        }
        return this;
    }
}
