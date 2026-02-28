using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Character;
using Sprint.Interfaces;

namespace Sprint.Factories;

internal static class LinkSprites
{
    public static ISprite IdleDown(Texture2D texture)  => new Idle(texture, new Rectangle(1,  11, 16, 16), SpriteEffects.None);
    public static ISprite IdleUp(Texture2D texture)    => new Idle(texture, new Rectangle(69, 11, 16, 16), SpriteEffects.None);
    public static ISprite IdleLeft(Texture2D texture)  => new Idle(texture, new Rectangle(35, 11, 16, 16), SpriteEffects.FlipHorizontally);
    public static ISprite IdleRight(Texture2D texture) => new Idle(texture, new Rectangle(35, 11, 16, 16), SpriteEffects.None);

    public static ISprite WalkingDown(Texture2D texture)
    {
        Rectangle[] frames = [new Rectangle(1, 11, 15, 15), new Rectangle(18, 11, 15, 15)];
        return new Walking(texture, SpriteEffects.None, frames, 0.15);
    }

    public static ISprite WalkingUp(Texture2D texture)
    {
        Rectangle[] frames = [new Rectangle(69, 11, 15, 15), new Rectangle(86, 11, 15, 15)];
        return new Walking(texture, SpriteEffects.None, frames, 0.15);
    }

    public static ISprite WalkingLeft(Texture2D texture)
    {
        Rectangle[] frames = [new Rectangle(35, 11, 15, 15), new Rectangle(52, 11, 15, 15)];
        return new Walking(texture, SpriteEffects.FlipHorizontally, frames, 0.15);
    }

    public static ISprite WalkingRight(Texture2D texture)
    {
        Rectangle[] frames = [new Rectangle(35, 11, 15, 15), new Rectangle(52, 11, 15, 15)];
        return new Walking(texture, SpriteEffects.None, frames, 0.15);
    }

    public static Attacking AttackDown(Texture2D texture, System.Action onFinished)
    {
        Rectangle[] frames =
        [
            new Rectangle(1,  47, 15, 15),
            new Rectangle(18, 47, 15, 26),
            new Rectangle(35, 47, 15, 26),
            new Rectangle(52, 47, 15, 26)
        ];
        return new Attacking(texture, SpriteEffects.None, frames, 0.15, 0.6, onFinished);
    }

    public static Attacking AttackUp(Texture2D texture, System.Action onFinished)
    {
        Rectangle[] frames =
        [
            new Rectangle(1,  97, 15, 27),
            new Rectangle(18, 97, 15, 27),
            new Rectangle(35, 97, 15, 27),
            new Rectangle(52, 97, 15, 27)
        ];
        return new Attacking(texture, SpriteEffects.None, frames, 0.15, 0.6, onFinished, anchorBottom: true, baseSize: 15);
    }

    public static Attacking AttackLeft(Texture2D texture, System.Action onFinished)
    {
        Rectangle[] frames =
        [
            new Rectangle(1,  77, 15, 15),
            new Rectangle(18, 77, 26, 16),
            new Rectangle(46, 77, 22, 16),
            new Rectangle(70, 77, 18, 16)
        ];
        return new Attacking(texture, SpriteEffects.FlipHorizontally, frames, 0.15, 0.6, onFinished);
    }

    public static Attacking AttackRight(Texture2D texture, System.Action onFinished)
    {
        Rectangle[] frames =
        [
            new Rectangle(1,  77, 15, 15),
            new Rectangle(18, 77, 26, 16),
            new Rectangle(46, 77, 22, 16),
            new Rectangle(70, 77, 18, 16)
        ];
        return new Attacking(texture, SpriteEffects.None, frames, 0.15, 0.6, onFinished);
    }
}
