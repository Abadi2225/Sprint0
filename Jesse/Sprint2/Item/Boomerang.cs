using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Item;

internal class Boomerang : AbstractItem
{
    private static string ResourceName = "items/boomerang";

    public Boomerang(Vector2 pos, ContentManager contentManager) : base("boomerang", contentManager, ResourceName, pos)
    {
        sprite = new MovingAnimatedSprite(
                texture,
                DrawPos,
                [0],
                0,
                18,
                32,
                0f
                );
    }

    public override void Draw(SpriteBatch sb, Vector2 pos)
    {
        sprite.Draw(sb, DrawPos);
    }

    public override int Update(GameTime time)
    {
        return 0;
    }
}
