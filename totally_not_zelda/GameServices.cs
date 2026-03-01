using Microsoft.Xna.Framework.Content;
using Sprint.Interfaces;
using Sprint.Levels;
using Sprint.Controllers;

/// <summary>
/// A class to hold services that are commonly used across the game, such as the ContentManager.
/// This allows us to avoid passing these services as parameters to every class that needs them.
/// </summary>
public static class GameServices
{
    public static ContentManager Content { get; set; }
    public static IController KeyInput { get; } = new KeyboardController();

    public static IGameActions GameActions { get; set; }

    public static float ScaleFactor { get; } = 3f;
    public static int GameWidth { get { return (int)(256 * ScaleFactor); } }
    public static int GameHeight { get { return (int)(224 * ScaleFactor); } }
}