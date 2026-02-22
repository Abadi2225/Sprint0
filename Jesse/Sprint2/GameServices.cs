using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

/// <summary>
/// A class to hold services that are commonly used across the game, such as the ContentManager and GraphicsDevice. 
/// This allows us to avoid passing these services as parameters to every class that needs them.
/// </summary>
class GameServices
{
    public ContentManager Content { get; init; }
    public GraphicsDevice GraphicsDevice { get; init; }

    public int ScaleFactor { get; init; }
    public int GameWidth { get { return 256 * ScaleFactor; } }
    public int GameHeight { get { return 224 * ScaleFactor; } }
}