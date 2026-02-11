using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class TextSprite : ISprite
{
    private SpriteFont font;
    private string text;
    private Vector2 position;

    public TextSprite(SpriteFont font, string text, Vector2 position)
    {
        this.font = font;
        this.text = text;
        this.position = position;
    }

    public void Update(GameTime gameTime)
    {
        // No update.
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(font, text, position, Color.White);
    }
}
