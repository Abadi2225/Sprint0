using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Character;
using Sprint.Interfaces;

namespace Sprint.Character;

internal static class LinkFactory
{
	public static ISprite IdleDown(Texture2D texture) => new Idle(texture, new Rectangle(1, 11, 16, 16), SpriteEffects.None);
	public static ISprite IdleUp(Texture2D texture) => new Idle(texture, new Rectangle(69, 11, 16, 16), SpriteEffects.None);
	public static ISprite IdleLeft(Texture2D texture) => new Idle(texture, new Rectangle(35, 11, 16, 16), SpriteEffects.FlipHorizontally);
	public static ISprite IdleRight(Texture2D texture) => new Idle(texture, new Rectangle(35, 11, 16, 16), SpriteEffects.None);

	public static ISprite WalkingDown(Texture2D texture)
	{
		Rectangle[] frames = [new Rectangle(1, 11, 16, 16), new Rectangle(18, 11, 16, 16)];
		return new Walking(texture, SpriteEffects.None, frames, 0.15);
	}

	public static ISprite WalkingUp(Texture2D texture)
	{
		Rectangle[] frames = [new Rectangle(69, 11, 16, 16), new Rectangle(86, 11, 16, 16)];
		return new Walking(texture, SpriteEffects.None, frames, 0.15);
	}

	public static ISprite WalkingLeft(Texture2D texture)
	{
		Rectangle[] frames = [new Rectangle(35, 11, 16, 16), new Rectangle(52, 11, 16, 16)];
		return new Walking(texture, SpriteEffects.FlipHorizontally, frames, 0.15);
	}

	public static ISprite WalkingRight(Texture2D texture)
	{
		Rectangle[] frames = [new Rectangle(35, 11, 16, 16), new Rectangle(52, 11, 16, 16)];
		return new Walking(texture, SpriteEffects.None, frames, 0.15);
	}

	public static UseItem UseItemDown(Texture2D texture, System.Action onFinished)
	{
		UseItem.Frame[] frames = [new UseItem.Frame(new Rectangle(107, 11, 16, 16))];
		return new UseItem(texture, SpriteEffects.None, frames, 0.4, 0.4, onFinished);
	}

	public static UseItem UseItemUp(Texture2D texture, System.Action onFinished)
	{
		UseItem.Frame[] frames = [new UseItem.Frame(new Rectangle(141, 11, 16, 16))];
		return new UseItem(texture, SpriteEffects.None, frames, 0.4, 0.4, onFinished);
	}

	public static UseItem UseItemLeft(Texture2D texture, System.Action onFinished)
	{
		UseItem.Frame[] frames = [new UseItem.Frame(new Rectangle(124, 11, 16, 16))];
		return new UseItem(texture, SpriteEffects.FlipHorizontally, frames, 0.4, 0.4, onFinished);
	}

	public static UseItem UseItemRight(Texture2D texture, System.Action onFinished)
	{
		UseItem.Frame[] frames = [new UseItem.Frame(new Rectangle(124, 11, 16, 16))];
		return new UseItem(texture, SpriteEffects.None, frames, 0.4, 0.4, onFinished);
	}

	public static PickUpItem PickUpWeapon(Texture2D texture, System.Action onFinished)
	{
		PickUpItem.Frame[] frames = [new PickUpItem.Frame(new Rectangle(213, 11, 16, 16))];
		return new PickUpItem(texture, SpriteEffects.None, frames, 3.0, 3.0, onFinished);
	}
	public static PickUpItem PickUpTriforce(Texture2D texture, System.Action onFinished)
	{
		PickUpItem.Frame[] frames = [new PickUpItem.Frame(new Rectangle(230, 11, 16, 16))];
		return new PickUpItem(texture, SpriteEffects.None, frames, 10.0, 10.0, onFinished);
	}

	public static Attacking AttackDown(Texture2D texture, System.Action onFinished)
	{
		Attacking.Frame[] frames =
		[
			new Attacking.Frame(new Rectangle(1, 47, 16, 16)),
			new Attacking.Frame(new Rectangle(18, 47, 16, 16), new Rectangle(23, 63, 8, 11), new Vector2( 5, 16)),
			new Attacking.Frame(new Rectangle(35, 47, 16, 16), new Rectangle(40, 63, 8, 7), new Vector2( 5, 16)),
			new Attacking.Frame(new Rectangle(52, 47, 16, 16), new Rectangle(57, 63, 8, 3), new Vector2( 5, 16)),
		];
		return new Attacking(texture, SpriteEffects.None, frames, 0.15, 0.6, onFinished);
	}

	public static Attacking AttackUp(Texture2D texture, System.Action onFinished)
	{
		Attacking.Frame[] frames =
		[
			new Attacking.Frame(new Rectangle(1, 109, 16, 16)),
			new Attacking.Frame(new Rectangle(18, 109, 16, 16), new Rectangle(21, 97, 8, 12), new Vector2(3, -12)),
			new Attacking.Frame(new Rectangle(35, 109, 16, 16), new Rectangle(38, 98, 8, 11), new Vector2(3, -11)),
			new Attacking.Frame(new Rectangle(52, 109, 16, 16), new Rectangle(55, 106, 8, 3), new Vector2(3, -3)),
		];
		return new Attacking(texture, SpriteEffects.None, frames, 0.15, 0.6, onFinished);
	}

	public static Attacking AttackLeft(Texture2D texture, System.Action onFinished)
	{
		Attacking.Frame[] frames =
		[
			new Attacking.Frame(new Rectangle(1, 77, 16, 16)),
			new Attacking.Frame(new Rectangle(18, 77, 16, 16), new Rectangle(34, 78, 11, 16), new Vector2(-11, 1)),
			new Attacking.Frame(new Rectangle(46, 77, 16, 16), new Rectangle(62, 78, 7, 16), new Vector2(-7, 1)),
			new Attacking.Frame(new Rectangle(70, 77, 16, 16), new Rectangle(86, 78, 3, 16), new Vector2(-3, 1)),
		];
		return new Attacking(texture, SpriteEffects.FlipHorizontally, frames, 0.15, 0.6, onFinished);
	}

	public static Attacking AttackRight(Texture2D texture, System.Action onFinished)
	{
		Attacking.Frame[] frames =
		[
			new Attacking.Frame(new Rectangle(1,  77, 16, 16)),
			new Attacking.Frame(new Rectangle(18, 77, 16, 16), new Rectangle(34, 78, 11, 16), new Vector2(16, 1)),
			new Attacking.Frame(new Rectangle(46, 77, 16, 16), new Rectangle(62, 78, 7, 16), new Vector2(16, 1)),
			new Attacking.Frame(new Rectangle(70, 77, 16, 16), new Rectangle(86, 78, 3, 16), new Vector2(16, 1)),
		];
		return new Attacking(texture, SpriteEffects.None, frames, 0.15, 0.6, onFinished);
	}
}
