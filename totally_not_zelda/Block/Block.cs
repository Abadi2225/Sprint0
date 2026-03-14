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
	private Vector2 position;
	public readonly bool pushAble;
	public Rectangle Rect { get; private set; }
	public Vector2 Position
	{
		get => position;
		set
		{
			position = value;
			Rect = new Rectangle((int)value.X, (int)value.Y, tileWidth, tileWidth);
		}
	}
	public Block(Texture2D texture, Vector2 pos, Rectangle sourceRect, bool walkable, bool pushable)
	{
		sprite = new StaticSprite(texture, pos, sourceRect);
		this.walkAble = walkable;
		Position = pos;
		this.pushAble = pushable;
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		sprite.Draw(spriteBatch, position);
	}

	public void Update(GameTime time)
	{

	}

}