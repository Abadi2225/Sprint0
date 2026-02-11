using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace sprint0;

public class MarioRunForward : ISprite
{
    public const string ResourceName = "textures/mario";

    private List<Rectangle> frameMasks_ = new List<Rectangle>(3);
    private int currentFrame_ = 0;
    private const int lastFrame = 2;

    public MarioRunForward()
    {
        frameMasks_.Add(new Rectangle(239, 53, 16, 32));
        frameMasks_.Add(new Rectangle(270, 53, 16, 32));
        frameMasks_.Add(new Rectangle(299, 53, 16, 32));
    }

    public void render(Vector2 pos, SpriteBatch spriteBatch, ContentManager contentManager)
    {
        Texture2D texture = contentManager.Load<Texture2D>(ResourceName);
        spriteBatch.Draw(texture, pos, frameMasks_[currentFrame_], Color.White);
    }

    public void advanceFrame()
    {
        currentFrame_++;
        if (currentFrame_ > lastFrame)
        {
            currentFrame_ = 0;
        }
    }
}
