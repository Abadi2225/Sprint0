using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Item;

internal class Boomerang : AbstractItem
{
    private static string ResourceName = "items/boomerang";

    public Boomerang(Vector2 pos, Vector2 vel, float maxDistance, ContentManager contentManager) : base("boomerang", contentManager, ResourceName, pos)
    {
        sprite = new BoomerangSprite(
                texture,
                DrawPos,
                vel,
                maxDistance,
                0.2f
                );

        UseAction = (entity) =>
        {
            if (sprite is BoomerangSprite bsprite)
            {
                bsprite.Throw();
            }
        };
    }

    public override void Draw(SpriteBatch sb, Vector2 pos)
    {
        sprite.Draw(sb, DrawPos);
    }

    public override int Update(GameTime time)
    {
        sprite.Update(time);
        return 0;
    }
}
