using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class MovingSprite : ISprite
{
    private Texture2D texture;
    private Vector2 position;
    private Rectangle sourceRect;
    private bool movingRight = true;

    public MovingSprite(Texture2D texture, Vector2 position, Rectangle sourceRect)
    {
        this.texture = texture;
        this.position = position;
        this.sourceRect = sourceRect;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(
            texture,                // texture
            position,               // position
            sourceRect,             // sourceRectangle
            Color.White,            // color
            0.0f,                   // rotation
            Vector2.Zero,           // origin
            4.0f,                 // scale
            SpriteEffects.None,     // effects
            0.0f                    // layerDepth
        );
        Console.WriteLine($"{texture.Width} x {texture.Height}");

    }

    public void Update(GameTime gameTime)
    {
        if (movingRight)
        {
            position.X += 3; // Move right
            if (position.X >= 600)
            {
                movingRight = false;
            }
        }
        else
        {
            position.X -= 3; // Move left
            if (position.X <= 500)
            {
                movingRight = true;
            }
        }
    }
}