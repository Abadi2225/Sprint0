using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegendOfZilda
{
    internal class OriginalSprite : ISprite
{
    private Texture2D texture;
    private Rectangle sourceRect;
    private Rectangle destRect;
    public OriginalSprite(Texture2D texture, Viewport viewport)
        {
            this.texture = texture;
            this.sourceRect = new Rectangle(175, 48, 22, 37);
			destRect = new Rectangle(
			viewport.Width / 2 - sourceRect.Width / 2,
			viewport.Height / 2 - sourceRect.Height / 2,
			sourceRect.Width,
			sourceRect.Height
			);
		}

    public void Draw(SpriteBatch spriteBatch)
    {
			spriteBatch.Draw(texture, destRect, sourceRect, Color.White);
		}

    public void Update(GameTime gameTime)
    {

    }
}
}
