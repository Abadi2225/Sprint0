using Microsoft.Xna.Framework;
using Sprint.Enemies.Concrete;
using Sprint.Interfaces;
using System.Collections.Generic;

namespace Sprint.Collisions
{
    public class MoldormCollisionHandler : ICollisionHandler
    {
        private readonly ILink link;
        private readonly List<Moldorm> moldorms;
        private const int SWORD_DAMAGE = 1;

        public MoldormCollisionHandler(ILink link, List<Moldorm> moldorms)
        {
            this.link = link;
            this.moldorms = moldorms;
        }

        public void Handle()
        {
            foreach (var moldorm in moldorms)
            {
                if (!moldorm.IsAlive) continue;

                Rectangle sword = link.SwordRect;

                // Head
                if (sword != Rectangle.Empty && sword.Intersects(moldorm.GetHeadRect()))
                {
                    moldorm.DamageHead(SWORD_DAMAGE);
                    link.RegisterSwordHit();
                }

                // Tail
                if (sword != Rectangle.Empty && sword.Intersects(moldorm.GetTailRect()))
                {
                    moldorm.DamageTail(SWORD_DAMAGE);
                    link.RegisterSwordHit();
                }

                // Middle segment push
                foreach (var middleRect in moldorm.GetMiddleRects())
                {
                    if (sword != Rectangle.Empty && sword.Intersects(middleRect))
                    {
                        Vector2 pushDir = middleRect.Center.ToVector2() - link.Position;
                        if (pushDir != Vector2.Zero) pushDir.Normalize();
                        moldorm.PushMiddleSegments(pushDir);
                        link.RegisterSwordHit();
                    }
                }

                // Link contact damage
                if (moldorm.GetHeadRect().Intersects(link.Rect) ||
                    moldorm.GetTailRect().Intersects(link.Rect))
                    link.TakeDamage(moldorm.Damage);
            }
        }
    }
}