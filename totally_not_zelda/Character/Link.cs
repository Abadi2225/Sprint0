using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Factories;
using Sprint.Interfaces;

namespace Sprint.Character;

public class Link : ILink
{
    private const float SPEED = 80f;
    private const int BODY_SIZE = 32;
    private const double DAMAGED_DURATION = 0.5;
    private const double BLINK_INTERVAL = 0.10;

    private readonly ISprite IdleUp;
    private readonly ISprite IdleDown;
    private readonly ISprite IdleLeft;
    private readonly ISprite IdleRight;

    private readonly ISprite WalkUp;
    private readonly ISprite WalkDown;
    private readonly ISprite WalkLeft;
    private readonly ISprite WalkRight;

    private readonly Attacking AttackUp;
    private readonly Attacking AttackDown;
    private readonly Attacking AttackLeft;
    private readonly Attacking AttackRight;

    private ISprite sprite;
    private Vector2 position;
    private Vector2 move = Vector2.Zero;
    private Directions direction = Directions.Down;
    private double damagedTimer;
    private bool isAttacking = false;
    private bool isDamaged = false;
    private bool isVisible = false;

    public Directions Facing => direction;

    public Rectangle Rect { get; private set; }

    public Vector2 Position
    {
        get => position;
        set
        {
            position = value;
            Rect = new Rectangle((int)value.X, (int)value.Y, BODY_SIZE, BODY_SIZE);
        }
    }

    public Link(Texture2D texture, Vector2 position)
    {
        IdleDown  = LinkSprites.IdleDown(texture);
        IdleUp    = LinkSprites.IdleUp(texture);
        IdleLeft  = LinkSprites.IdleLeft(texture);
        IdleRight = LinkSprites.IdleRight(texture);

        WalkDown  = LinkSprites.WalkingDown(texture);
        WalkUp    = LinkSprites.WalkingUp(texture);
        WalkLeft  = LinkSprites.WalkingLeft(texture);
        WalkRight = LinkSprites.WalkingRight(texture);

        AttackDown  = LinkSprites.AttackDown(texture, FinishAttack);
        AttackUp    = LinkSprites.AttackUp(texture, FinishAttack);
        AttackLeft  = LinkSprites.AttackLeft(texture, FinishAttack);
        AttackRight = LinkSprites.AttackRight(texture, FinishAttack);

        sprite = IdleDown;
        Position = position;
    }

    public void Update(GameTime gameTime)
    {
        float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (!isAttacking && !isDamaged && move == Vector2.Zero)
        {
            SetIdleSprite();
        }

        /*
        I implemented the damaged state inside the Link class because it only modifies the existing
        behavior without introducing new rectangles. It can be refactored into a separate class if
        needed in the future.
        */
        if (isDamaged)
        {
            damagedTimer += gameTime.ElapsedGameTime.TotalSeconds;

            isVisible = (int)(damagedTimer / BLINK_INTERVAL) % 2 == 0;

            if (damagedTimer >= DAMAGED_DURATION)
            {
                isDamaged = false;
                isVisible = true;
            }
        }

        Position += move * SPEED * dt;

        sprite.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        if (isDamaged && !isVisible)
            return;

        sprite.Draw(spriteBatch, position);
    }

    public void SetMove(Directions dir)
    {
        if (isAttacking) return;

        move = Vector2.Zero;
        direction = dir;

        switch (dir)
        {
            case Directions.Up:    sprite = WalkUp;    move.Y = -1 * GameServices.ScaleFactor; break;
            case Directions.Down:  sprite = WalkDown;  move.Y =  1 * GameServices.ScaleFactor; break;
            case Directions.Left:  sprite = WalkLeft;  move.X = -1 * GameServices.ScaleFactor; break;
            case Directions.Right: sprite = WalkRight; move.X =  1 * GameServices.ScaleFactor; break;
        }
    }

    public void StopMove()
    {
        move = Vector2.Zero;
    }

    public void StartAttack()
    {
        if (isAttacking) return;

        isAttacking = true;
        move = Vector2.Zero;

        switch (direction)
        {
            case Directions.Up:    AttackUp.Reset();    sprite = AttackUp;    break;
            case Directions.Down:  AttackDown.Reset();  sprite = AttackDown;  break;
            case Directions.Left:  AttackLeft.Reset();  sprite = AttackLeft;  break;
            case Directions.Right: AttackRight.Reset(); sprite = AttackRight; break;
        }
    }

    public void StartDamaged()
    {
        isDamaged = true;
        damagedTimer = 0;
        isVisible = true;
        move = Vector2.Zero;
        isAttacking = false;
        SetIdleSprite();
    }

    private void FinishAttack()
    {
        isAttacking = false;
        SetIdleSprite();
    }

    private void SetIdleSprite()
    {
        sprite = direction switch
        {
            Directions.Up    => IdleUp,
            Directions.Down  => IdleDown,
            Directions.Left  => IdleLeft,
            Directions.Right => IdleRight,
            _                => IdleDown,
        };
    }
}
