using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal class ProjectileSprite : IPositionedSprite
{
    public Vector2 Position { get; set; }
    private Texture2D texture;
    private Rectangle texMask;
    private Vector2 velocity;
    private float maxDistance;
    private float rotation = 0;
    private Vector2 origin;
    private float scale;

    private float distanceTraveled = 0;
    private bool isMoving = false;

    public bool ReachedMaxDistance = false;

    public ProjectileSprite(Texture2D texture, Rectangle texMask, Vector2 pos, Vector2 vel, float maxDistance, float rotation, Vector2 origin, float scale)
    {
        this.texture = texture;
        this.texMask = texMask;
        Position = pos;
        this.velocity = vel;
        this.maxDistance = maxDistance;
        this.rotation = rotation;
        this.origin = origin;
        this.scale = scale;
    }

    public void StartMoving()
    {
        isMoving = true;
    }

    public void Update(GameTime time)
    {
        if (!isMoving) return;

        Position += velocity;
        distanceTraveled += Vector2.Distance(new Vector2(0f, 0f), velocity);
        if (distanceTraveled > maxDistance)
        {
            ReachedMaxDistance = true;
            isMoving = false;
        }
    }

    public void Draw(SpriteBatch sb, Vector2 unused)
    {
        if (!isMoving) return;

        sb.Draw(
                texture,
                Position,
                texMask,
                Color.White,
                rotation,
                origin,
                scale,
                SpriteEffects.None,
                0f
               );
    }
}
