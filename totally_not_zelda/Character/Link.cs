using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Character;

public class Link : ILink
{
    private const float SPEED = 80f;
    private const int BODY_SIZE = 48;
    private const double DAMAGED_DURATION = 0.5;
    private const double BLINK_INTERVAL = 0.10;
    private const int MAX_HEALTH = 6;

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

    private readonly UseItem UseItemUp;
    private readonly UseItem UseItemDown;
    private readonly UseItem UseItemLeft;
    private readonly UseItem UseItemRight;

    private ISprite sprite;
    private Vector2 position;
    private Vector2 move = Vector2.Zero;
    private Directions direction = Directions.Down;
    private double damagedTimer;
    private int health;
    private bool isAttacking = false;
    private bool isUsingItem = false;
    private bool isDamaged = false;
    private bool isVisible = false;
    private bool attackHitLanded = false;

    public Directions Facing => direction;
    public int Health => health;
    public int MaxHealth => MAX_HEALTH;

    public Rectangle Rect { get; private set; }

    public Rectangle SwordRect
    {
        get
        {
            if (!isAttacking || attackHitLanded) return Rectangle.Empty;

            Attacking currentAttack = direction switch
            {
                Directions.Up    => AttackUp,
                Directions.Down  => AttackDown,
                Directions.Left  => AttackLeft,
                Directions.Right => AttackRight,
                _                => AttackDown,
            };

            return currentAttack.GetWeaponWorldRect(position);
        }
    }

    public void RegisterSwordHit() => attackHitLanded = true;

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
        IdleDown  = LinkFactory.IdleDown(texture);
        IdleUp    = LinkFactory.IdleUp(texture);
        IdleLeft  = LinkFactory.IdleLeft(texture);
        IdleRight = LinkFactory.IdleRight(texture);

        WalkDown  = LinkFactory.WalkingDown(texture);
        WalkUp    = LinkFactory.WalkingUp(texture);
        WalkLeft  = LinkFactory.WalkingLeft(texture);
        WalkRight = LinkFactory.WalkingRight(texture);

        AttackDown  = LinkFactory.AttackDown(texture, FinishAttack);
        AttackUp    = LinkFactory.AttackUp(texture, FinishAttack);
        AttackLeft  = LinkFactory.AttackLeft(texture, FinishAttack);
        AttackRight = LinkFactory.AttackRight(texture, FinishAttack);

        UseItemDown  = LinkFactory.UseItemDown(texture, FinishUseItem);
        UseItemUp    = LinkFactory.UseItemUp(texture, FinishUseItem);
        UseItemLeft  = LinkFactory.UseItemLeft(texture, FinishUseItem);
        UseItemRight = LinkFactory.UseItemRight(texture, FinishUseItem);

        sprite = IdleDown;
        Position = position;
        health = MAX_HEALTH;
    }

    public void Update(GameTime gameTime)
    {
        float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

        if (!isAttacking && !isUsingItem && !isDamaged && move == Vector2.Zero)
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

    public void StartUseItem()
    {
        if (isUsingItem) return;

        isUsingItem = true;
        move = Vector2.Zero;

        switch (direction)
        {
            case Directions.Up:    UseItemUp.Reset();    sprite = UseItemUp;    break;
            case Directions.Down:  UseItemDown.Reset();  sprite = UseItemDown;  break;
            case Directions.Left:  UseItemLeft.Reset();  sprite = UseItemLeft;  break;
            case Directions.Right: UseItemRight.Reset(); sprite = UseItemRight; break;
        }
    }

    public void SetMove(Directions dir)
    {
        if (isAttacking || isUsingItem) return;

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
        attackHitLanded = false;
        move = Vector2.Zero;

        switch (direction)
        {
            case Directions.Up:    AttackUp.Reset();    sprite = AttackUp;    break;
            case Directions.Down:  AttackDown.Reset();  sprite = AttackDown;  break;
            case Directions.Left:  AttackLeft.Reset();  sprite = AttackLeft;  break;
            case Directions.Right: AttackRight.Reset(); sprite = AttackRight; break;
        }
    }

    public void TakeDamage(int amount)
    {
        if (isDamaged) return;

        health = MathHelper.Clamp(health - amount, 0, MAX_HEALTH);
        StartDamaged();
    }

    public void StartDamaged()
    {
        isDamaged = true;
        damagedTimer = 0;
        isVisible = true;
        move = Vector2.Zero;
        isAttacking = false;
        isUsingItem = false;
        SetIdleSprite();
    }

    private void FinishAttack()
    {
        isAttacking = false;
        SetIdleSprite();
    }

    private void FinishUseItem()
    {
        isUsingItem = false;
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
