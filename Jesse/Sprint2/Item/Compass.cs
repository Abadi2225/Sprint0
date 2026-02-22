using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Item;

internal class Compass : AbstractItem
{
    private static string ResourceName = "items/compass";

    public Compass(Vector2 pos, ContentManager contentManager) : base("compass", contentManager, ResourceName, pos)
    {
        sprite = new AnimatedSprite(
                texture,
                DrawPos,
                [0],
                0,
                64,
                64,
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
