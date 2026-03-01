using System.Reflection.Metadata.Ecma335;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint.Interfaces;

public interface ISprite
    {

        public void Draw(SpriteBatch spriteBatch, Vector2 location);

        public void Update(GameTime gameTime);
    }

public interface IPositionedSprite : ISprite
    {
        Vector2 Position { get; set; }
    }