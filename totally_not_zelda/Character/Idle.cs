using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Character;

internal class Idle : ISprite
{
    private readonly Texture2D texture;
    private readonly Rectangle sourceRect;
    private readonly SpriteEffects effect;

    public Idle(Texture2D texture, Rectangle sourceRect, SpriteEffects effect)
    {
        this.texture = texture;
        this.sourceRect = sourceRect;
        this.effect = effect;
    }

    public void Update(GameTime gameTime) { }

    public void Draw(SpriteBatch spriteBatch, Vector2 location)
    {
        spriteBatch.Draw(texture, location, sourceRect, Color.White, 0f, Vector2.Zero, 2f, effect, 0f);
    }
}
