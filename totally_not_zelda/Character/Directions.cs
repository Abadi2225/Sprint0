using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;

namespace Sprint.Character
{
    public enum Directions
    {
        Left,
        Right,
        Up,
        Down
    }

    public class DirectionsUtils
    {
        public static Vector2 CreateVector(Directions direction, float magnitude)
        {
            switch (direction)
            {
                case Directions.Left:
                    return new Vector2(-magnitude, 0);
                case Directions.Right:
                    return new Vector2(magnitude, 0);
                case Directions.Up:
                    return new Vector2(0, -magnitude);
                case Directions.Down:
                    return new Vector2(0, magnitude);
                default:
                    return Vector2.Zero;
            }
        }
    }
}
