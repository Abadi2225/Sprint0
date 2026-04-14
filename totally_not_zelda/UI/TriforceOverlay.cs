using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.UI;

public class TriforceOverlay : IUIElement
{
    private readonly ILink link;
    private readonly Texture2D pixel;

    public TriforceOverlay(ILink link, Texture2D pixel)
    {
        this.link = link;
        this.pixel = pixel;
    }

    public void Update(GameTime gameTime)
    {
        // no logic needed — Link already tracks time
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        if (!link.TriforceActive) return;

        double t = link.TriforceTimer;

        int screenWidth = GameServices.GameWidth;
        int screenHeight = GameServices.GameHeight;

        // FLASH (2–6 sec)
        if (t >= 2 && t < 6)
        {
            bool flashOn = ((int)((t - 2) / 0.3) % 2 == 0);

            if (flashOn)
            {
                spriteBatch.Draw(pixel,
                    new Rectangle(0, 0, screenWidth, screenHeight),
                    Color.White * 0.8f);
            }
        }

        // BLACK BAR (6–10 sec)
        if (t >= 6 && t < 10)
        {
            float progress = (float)System.Math.Min((t - 6) / 3.0, 1.0);
            int width = (int)(screenWidth * progress);

            spriteBatch.Draw(pixel,
                new Rectangle(0, 0, width, screenHeight),
                Color.Black);
        }
    }
}