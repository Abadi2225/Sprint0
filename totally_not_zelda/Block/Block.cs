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
	public Vector2 Position;
	public readonly bool pushAble;
	public readonly bool IsStair;
	public bool HasBeenPushed { get; set; } = false;
	public Rectangle Rect => new Rectangle((int)Position.X, (int)Position.Y, tileWidth, tileWidth);

	public Block(Texture2D texture, Vector2 pos, Rectangle sourceRect, bool walkable, bool pushable,  bool isStair = false)
	{
		if (texture != null)
        	sprite = new StaticSprite(texture, pos, sourceRect);
		this.walkAble = walkable;
		this.Position = pos;
		this.pushAble = pushable;
		this.IsStair = isStair;
	}

	public void Draw(SpriteBatch spriteBatch)
	{
		if (sprite == null) return;
    		sprite.Draw(spriteBatch, Position);
	}

	public void Update(GameTime time)
	{

	}

}