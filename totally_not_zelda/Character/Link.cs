using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;
using static GameplayState;

namespace Sprint.Character;

public class Link : ILink
{
    private const float SPEED = 80f;
    private const float PUSHING_SPEED = 40f;
    private const float PUSHING_DURATION = 0.5f;
	private const int BODY_SIZE = 48;
    private const int HAND_X = 2;
    private const int HAND_Y = 1;

    private const double DAMAGED_DURATION = 3;
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

	private readonly Dead DeadSprite;

	private readonly Attacking AttackUp;
    private readonly Attacking AttackDown;
    private readonly Attacking AttackLeft;
    private readonly Attacking AttackRight;

    private readonly UseItem UseItemUp;
    private readonly UseItem UseItemDown;
    private readonly UseItem UseItemLeft;
    private readonly UseItem UseItemRight;

    private readonly PickUpItem PickUpWeapon;
    private readonly PickUpItem PickUpTriforce;

	private readonly DeathSparkle DeathSparkleSprite;

	private ISprite sprite;
    private Vector2 position;
    private Vector2 move = Vector2.Zero;
    private Directions direction = Directions.Down;
    private double damagedTimer;
	private double pushingTimer = 0;
	private int health;
    private int rubies;
    private int keys;
    private bool isAttacking = false;
    private bool isUsingItem = false;
    private bool isDamaged = false;
    private bool isVisible = false;
    public bool isPushing = false;
	private bool isDead = false;
	private bool attackHitLanded = false;
    private Rectangle? pickUpItemRect = null;

    public Directions Facing => direction;
    public int Health => health;
    public int MaxHealth => MAX_HEALTH;
	public bool IsPushing => isPushing;
	public bool IsDead => isDead;
	public bool DeathFinished => DeadSprite.Finished;
	public bool IsGrabbed { get; set; } = false;

	private enum DeathStage
	{
		None,
		Spinning,
		WhiteFlash,
		Sparkle,
		Finished
	}

	private DeathStage deathStage = DeathStage.None;
	private double deathStageTimer = 0;
	public bool DeathSequenceFinished => deathStage == DeathStage.Finished;
	public bool DeathBackgroundBlack =>
		deathStage == DeathStage.WhiteFlash || deathStage == DeathStage.Sparkle || deathStage == DeathStage.Finished;

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
            Rect = new Rectangle((int)value.X, (int)value.Y + BODY_SIZE / 2, BODY_SIZE, BODY_SIZE / 2);
        }
    }

    public int Rubies
    {
        get => rubies;
        private set => rubies = value;
    }

	public int Keys => keys;
    public void AddKey() => keys++;
    public bool UseKey()
    { 
        if (keys <= 0) return false; 
        keys--; 
        return true; 
    }

    public Link(Texture2D texture, Texture2D dustTexture,Vector2 position)
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

        PickUpWeapon = LinkFactory.PickUpWeapon(texture, FinishPickUpItem);
        PickUpTriforce = LinkFactory.PickUpTriforce(texture, FinishPickUpItem);

		DeadSprite = LinkFactory.Dead(texture);
		DeathSparkleSprite = LinkFactory.DeathSparkle(dustTexture);


		sprite = IdleDown;
        Position = position;
        health = MAX_HEALTH;
    }

    public void Update(GameTime gameTime)
    {
        if (IsGrabbed)
        {
            sprite.Update(gameTime); // Update sprite animation even while grabbed
            return; // WallMaster controls position while grabbed
        }

		if (isDead)
		{
			double deadDT = gameTime.ElapsedGameTime.TotalSeconds;
			deathStageTimer += deadDT;

			switch (deathStage)
			{
				case DeathStage.Spinning:
					sprite.Update(gameTime);

					if (DeadSprite.Finished)
					{
						deathStage = DeathStage.WhiteFlash;
						deathStageTimer = 0;
						direction = Directions.Down;
						sprite = IdleDown;
					}
					break;

				case DeathStage.WhiteFlash:
					if (deathStageTimer >= 0.2)
					{
						deathStage = DeathStage.Sparkle;
						deathStageTimer = 0;
						DeathSparkleSprite.Reset();
					}
					break;

				case DeathStage.Sparkle:
					DeathSparkleSprite.Update(gameTime);

					if (deathStageTimer >= 0.3)
					{
						deathStage = DeathStage.Finished;
						deathStageTimer = 0;
					}
					break;
			}

			return;
		}

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

        if(isPushing) 
        {
            pushingTimer += gameTime.ElapsedGameTime.TotalSeconds;

			if (pushingTimer >= PUSHING_DURATION)
			{
				isPushing = false;
			}

		}

		float currentSpeed = isPushing ? PUSHING_SPEED : SPEED;
		Position += move * currentSpeed * dt;

        sprite.Update(gameTime);
    }

    public void Draw(SpriteBatch spriteBatch)
    {

		if (deathStage == DeathStage.Sparkle)
		{
			Vector2 center = new Vector2(
				position.X + BODY_SIZE / 2f,
				position.Y + BODY_SIZE / 2f
			);

			DeathSparkleSprite.Draw(spriteBatch, center);
			return;
		}

		if (deathStage == DeathStage.Finished)
		{
			return;
		}

		if (isDamaged && !isVisible)
            return;

        sprite.Draw(spriteBatch, position);

        if (pickUpItemRect.HasValue)
        {
            Rectangle rect = pickUpItemRect.Value;

            Vector2 handPos = new Vector2(
                position.X + HAND_X * GameServices.ScaleFactor,
                position.Y + HAND_Y * GameServices.ScaleFactor
            );

            Vector2 itemPos = new Vector2(
                handPos.X - (rect.Width * GameServices.ScaleFactor) / 2f,
                handPos.Y - rect.Height * GameServices.ScaleFactor
            );


            spriteBatch.Draw(
                GameServices.ItemSheet,
                itemPos,
                pickUpItemRect.Value,
                Color.White,
                0f,
                Vector2.Zero,
                GameServices.ScaleFactor,
                SpriteEffects.None,
                0f
            );
        }

	}

    public void StartUseItem()
    {
        if (isUsingItem || isDead) return;

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

    public void StartPickUpWeapon(Rectangle itemRect)
    {
        if (isUsingItem || isAttacking || isDamaged || isDead)
            return;

        direction = Directions.Up;
        isUsingItem = true;
        move = Vector2.Zero;

        pickUpItemRect = itemRect;

        PickUpWeapon.Reset();
        sprite = PickUpWeapon;
    }

    public void StartPickUpTriforce()
    {
        if (isUsingItem || isAttacking || isDamaged || isDead)
            return;

        isUsingItem = true;
        move = Vector2.Zero;

        PickUpTriforce.Reset();
        sprite = PickUpTriforce;
    }

    public void SetMove(Directions dir)
    {
        if (isAttacking || isUsingItem || isDead) return;

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
        if (isAttacking || isDead) return;

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

	public void StartPush()
	{
		if (isAttacking || isUsingItem || isDamaged || isDead) return;

		isPushing = true;
		pushingTimer = 0;
	}


	public void TakeDamage(int amount)
    {
        if (isDamaged) return;

        health = MathHelper.Clamp(health - amount, 0, MAX_HEALTH);

		if (health <= 0)
		{
			StartDeath();
			return;
		}

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

	public void StartDeath()
	{
		if (isDead) return;

		isDead = true;
		move = Vector2.Zero;
		isAttacking = false;
		isUsingItem = false;
		isDamaged = false;
		isPushing = false;

		deathStage = DeathStage.Spinning;
		deathStageTimer = 0;

		DeadSprite.Reset();
		sprite = DeadSprite;
	}
	private void FinishAttack()
    {
        isAttacking = false;
        SetIdleSprite();
    }

    private void FinishPickUpItem()
    {
        isUsingItem = false;
        pickUpItemRect = null;
        SetIdleSprite();

    }

    private void FinishUseItem()
    {
        isUsingItem = false;
        SetIdleSprite();
    }

    public void GetHealed(int amount)
    {
        health = MathHelper.Clamp(health + amount, 0, MAX_HEALTH);
        Console.WriteLine($"Link healed by {amount}. Current health: {health}");
    }

    public void IncreaseRubies(int amount)
    {
        Rubies += amount;
        Console.WriteLine($"Link picked up {amount} rubies. Current rubies: {Rubies}");
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
