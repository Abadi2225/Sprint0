using Microsoft.Xna.Framework;
using Sprint.Interfaces;

namespace Sprint.Collisions
{
    public class LinkBoundaryCollisionHandler : ICollisionHandler
    {
        private readonly ILink link;
        private readonly Rectangle bounds;

        public LinkBoundaryCollisionHandler(ILink link, Rectangle bounds)
        {
            this.link   = link;
            this.bounds = bounds;
        }

        public void Handle()
        {
            int s = link.Rect.Width;

            if (link.Position.X < bounds.Left)
                link.Position = new Vector2(bounds.Left, link.Position.Y);
            if (link.Position.X > bounds.Right - s)
                link.Position = new Vector2(bounds.Right - s, link.Position.Y);
            if (link.Position.Y < bounds.Top)
                link.Position = new Vector2(link.Position.X, bounds.Top);
            if (link.Position.Y > bounds.Bottom - s)
                link.Position = new Vector2(link.Position.X, bounds.Bottom - s);
        }
    }
}