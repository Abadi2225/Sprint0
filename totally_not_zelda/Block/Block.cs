using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using Sprint.Sprites;
using System.Collections.Generic;

namespace Sprint.Block;

public class Block
{
	internal int tileWidth = (int)(16 * GameServices.ScaleFactor);
	private readonly StaticSprite sprite;
	public readonly bool walkAble;
	private readonly Vector2 position;
	public Rectangle Rect => new Rectangle((int)position.X, (int)position.Y, tileWidth, tileWidth);
	public Block(Texture2D texture, Vector2 pos, Rectangle sourceRect, bool walkable)
	{
		sprite = new StaticSprite(texture, pos, sourceRect);
		this.walkAble = walkable;
		position = pos;
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		sprite.Draw(spriteBatch, position);
	}

	public void Update(GameTime time)
	{
		if (walkAble)
		{
			// Maybe add collision?
		}
	}
}