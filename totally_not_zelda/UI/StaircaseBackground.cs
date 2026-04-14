using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.UI;

public class StaircaseBackground : IUIElement
{
    private readonly Texture2D texture;
    private readonly float scale;
    private readonly float hudHeight;

    public StaircaseBackground(Texture2D texture)
    {
        this.texture = texture;
        scale = GameServices.ScaleFactor;
        hudHeight = 48 * scale;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        int imageHeight = (int)(161 * scale);
        int totalSpace  = GameServices.GameHeight - (int)hudHeight;
        int blackHeight = totalSpace - imageHeight;

        // Fill gap above image with black
        if (blackHeight > 0)
        {
            spriteBatch.Draw(
                GameServices.TileSheet,
                new Rectangle(0, (int)hudHeight, GameServices.GameWidth, blackHeight),
                new Rectangle(0, 0, 1, 1),
                Color.Black);
        }

        // Draw background image below the black gap
        spriteBatch.Draw(texture, new Vector2(0, hudHeight + blackHeight), null,
            Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
    }

    public Rectangle InnerBounds => new Rectangle(
        0,
        (int)(hudHeight + (GameServices.GameHeight - (int)hudHeight - 161 * scale)),
        (int)(256 * scale),
        (int)(161 * scale)
    );

    public void Update(GameTime gameTime) { }
}