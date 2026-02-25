using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal class TimeBomb : AbstractItem
{
    private static string ResourceName = "items/sheet";
    private double millisUntilExplode;

    public TimeBomb(double explodeDelayMillis, string name, ContentManager contentManager, Vector2 drawPos, Rectangle mask, float rotation, float scale) : base(name, contentManager, ResourceName, drawPos)
    {
        this.millisUntilExplode = explodeDelayMillis;
        sprite = new StillItemSprite(
                DrawPos,
                texture,
                mask,
                rotation,
                scale
                );
    }

    public override void Update(GameTime time)
    {
        millisUntilExplode -= time.ElapsedGameTime.TotalMilliseconds;
    }

    public override bool IsFinished => millisUntilExplode <= 0;
}
