using Microsoft.Xna.Framework;

namespace Sprint.Character;

public enum Directions
{
    Left,
    Right,
    Up,
    Down
}

public class DirectionsUtils
{
    public static Vector2 CreateVector(Directions direction, float magnitude) => direction switch
    {
        Directions.Left  => new Vector2(-magnitude, 0),
        Directions.Right => new Vector2(magnitude, 0),
        Directions.Up    => new Vector2(0, -magnitude),
        Directions.Down  => new Vector2(0, magnitude),
        _                => Vector2.Zero
    };
}
