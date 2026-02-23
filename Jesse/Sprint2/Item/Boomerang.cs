using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Item;

internal class Boomerang : AbstractItem
{
    private static string ResourceName = "items/boomerang";

    public Boomerang(Vector2 pos, Vector2 vel, float maxDistance, ContentManager contentManager) : base("Boomerang", contentManager, ResourceName, pos)
    {
        sprite = new BoomerangSprite(
                texture,
                DrawPos,
                vel,
                maxDistance,
                0.2f
                );
    }

    public Boomerang StartMoving()
    {
        if (sprite is BoomerangSprite bsprite)
        {
            bsprite.Throw();
        }
        return this;
    }
    public ISprite GetSprite() => sprite;
}
