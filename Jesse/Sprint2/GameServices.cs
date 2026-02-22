using System.ComponentModel.DataAnnotations;
using Microsoft.Xna.Framework.Content;
using Sprint.Block;
using Sprint.Controllers;
using Sprint.Interfaces;

/// <summary>
/// A class to hold services that are commonly used across the game, such as the ContentManager. 
/// This allows us to avoid passing these services as parameters to every class that needs them.
/// </summary>
public class GameServices
{
    public ContentManager Content { get; init; }
    public KeyboardController KeyInput { get; init; }

    public IGameActions GameActions { get; init; }

    public int ScaleFactor { get; init; }
    public int GameWidth { get { return 256 * ScaleFactor; } }
    public int GameHeight { get { return 224 * ScaleFactor; } }
}