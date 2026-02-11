using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class AnimatedSprite : ISprite
{
    private Texture2D texture;
    private Vector2 position;

    private Rectangle[] frames;
    private int currentFrame;

    private double timePerFrame = 0.15; // seconds
    private double elapsedTime;

    public AnimatedSprite(Texture2D texture, Vector2 position, Rectangle[] frames)
    {
        this.texture = texture;
        this.position = position;
        this.frames = frames;
        this.currentFrame = 0;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        // Drawing logic here
        spriteBatch.Draw(
            texture,                // texture
            position,               // position
            frames[currentFrame],   // sourceRectangle
            Color.White,            // color
            0.0f,                   // rotation
            Vector2.Zero,           // origin
            4.0f,                 // scale
            SpriteEffects.None,     // effects
            0.0f                    // layerDepth
        );
    }

    public void Update(GameTime gameTime)
    {
        elapsedTime += gameTime.ElapsedGameTime.TotalSeconds;
        if (elapsedTime >= timePerFrame)
        {
            currentFrame = (currentFrame + 1) % frames.Length;
            elapsedTime = 0;
        }
    }
}