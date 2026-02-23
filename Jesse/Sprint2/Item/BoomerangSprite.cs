using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Sprint.Interfaces;

namespace Sprint.Item;

internal class BoomerangSprite : ISprite
{
    public Vector2 Pos;
    private Texture2D texture;
    private Vector2 velocity;
    private float scale;
    private int animationFrame = 1;
    private int lastAnimationFrame = 16;
    private float distanceTraveled = 0f;
    private float maxDistance = 200f;
    private bool returning = false;
    private bool thrown = false;

    public Vector2 Position { get; set; }

    public BoomerangSprite(Texture2D texture, Vector2 initialPos, Vector2 velocity, float maxDistance, float scale)
    {
        this.texture = texture;
        Pos = initialPos;
        this.velocity = velocity;
        this.maxDistance = maxDistance;
        this.scale = scale;
    }

    public void Throw()
    {
        thrown = true;
    }

    public void Draw(SpriteBatch sb, Vector2 location)
    {
        sb.Draw(
                texture,
                Pos,
                null,
                Color.White,
                rotation: animationFrame * 22.5f * (float)Math.PI / 180f,
                origin: new Vector2(36, 64),
                scale: new Vector2(0.2f, 0.2f),
                SpriteEffects.None,
                0f
               );
    }

    public int Update(GameTime time)
    {
        if (!thrown)
        {
            return 0;
        }

        if (animationFrame < lastAnimationFrame)
        {
            animationFrame++;
        }
        else
        {
            animationFrame = 1;
        }
        Pos += velocity;
        distanceTraveled += Vector2.Distance(new Vector2(0f, 0f), velocity);
        if (distanceTraveled > maxDistance)
        {
            if (returning)
            {
                thrown = false;
            }
            velocity.X = -velocity.X;
            velocity.Y = -velocity.Y;
            returning = !returning;
            distanceTraveled = 0;
        }
        return 0;
    }
}
