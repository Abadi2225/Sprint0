using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Interfaces;

namespace Sprint.Character;

public class Link : ILink
{
    private const int BODY_SIZE = 48;
    private const int HAND_X = 2;
    private const int HAND_Y = 1;
    private int maxHealth = 6;

    internal readonly ISprite IdleUp;
    internal readonly ISprite IdleDown;
    internal readonly ISprite IdleLeft;
    internal readonly ISprite IdleRight;

    internal readonly ISprite WalkUp;
    internal readonly ISprite WalkDown;
    internal readonly ISprite WalkLeft;
    internal readonly ISprite WalkRight;

    internal readonly Dead DeadSprite;

    internal readonly Attacking AttackUp;
    internal readonly Attacking AttackDown;
    internal readonly Attacking AttackLeft;
    internal readonly Attacking AttackRight;

    internal readonly UseItem UseItemUp;
    internal readonly UseItem UseItemDown;
    internal readonly UseItem UseItemLeft;
    internal readonly UseItem UseItemRight;

    internal readonly PickUpItem PickUpWeapon;
    internal readonly PickUpItem PickUpTriforce;

    internal readonly DeathSparkle DeathSparkleSprite;

    private readonly LinkResources resources = new LinkResources();

    private ISprite sprite;
    internal ISprite Sprite { get => sprite; set => sprite = value; }
    internal Directions Direction { get; set; } = Directions.Down;

    private Vector2 position;
    private int health;

    private readonly LinkStateMachine stateMachine;

    public Directions Facing => Direction;
    public int Health => health;
    public int MaxHealth => maxHealth;

    public bool IsDead => stateMachine.IsDead;
    public bool DeathFinished => DeadSprite.Finished;
    public bool DeathSequenceFinished => stateMachine.DeathSequenceFinished;
    public bool DeathBackgroundBlack => stateMachine.DeathBackgroundBlack;

    public bool IsPushing => stateMachine.IsPushing;

    public bool TriforceActive => stateMachine.TriforceActive;
    public double TriforceTimer => stateMachine.TriforceTimer;

    public bool IsGrabbed
    {
        get => stateMachine.IsGrabbed;
        set => stateMachine.IsGrabbed = value;
    }

    public Rectangle Rect { get; private set; }
    public Rectangle BlockRect { get; private set; }

    public Rectangle SwordRect
    {
        get
        {
            if (!stateMachine.IsAttacking || stateMachine.AttackHitLanded) return Rectangle.Empty;

            Attacking currentAttack = GetAttackSprite(Direction);

            return currentAttack.GetWeaponWorldRect(position);
        }
    }

    public void RegisterSwordHit() => stateMachine.AttackHitLanded = true;

    public Vector2 Position
    {
        get => position;
        set
        {
            position = value;
            Rect = new Rectangle((int)value.X, (int)value.Y + BODY_SIZE / 2, BODY_SIZE, BODY_SIZE / 2);
            BlockRect = new Rectangle((int)value.X + BODY_SIZE / 4, (int)value.Y + BODY_SIZE / 2, BODY_SIZE / 2, BODY_SIZE / 2);
        }
    }

    public int Rupees => resources.Rupees;

    public int Keys => resources.Keys;
    public int Bombs => resources.Bombs;
    public void AddKey() => resources.AddKey();
    public bool UseKey() => resources.UseKey();

    public bool UseBomb() => resources.UseBomb();
    public void AddBomb() => resources.AddBombs(4);

    // For debug mode
    public void SetBombs(int amount) => resources.SetBombs(amount);
    public void SetKeys(int amount) => resources.SetKeys(amount);

    public Link(Texture2D texture, Texture2D dustTexture, Vector2 position)
    {
        IdleDown = LinkFactory.IdleDown(texture);
        IdleUp = LinkFactory.IdleUp(texture);
        IdleLeft = LinkFactory.IdleLeft(texture);
        IdleRight = LinkFactory.IdleRight(texture);

        WalkDown = LinkFactory.WalkingDown(texture);
        WalkUp = LinkFactory.WalkingUp(texture);
        WalkLeft = LinkFactory.WalkingLeft(texture);
        WalkRight = LinkFactory.WalkingRight(texture);

        AttackDown = LinkFactory.AttackDown(texture, OnAttackFinished);
        AttackUp = LinkFactory.AttackUp(texture, OnAttackFinished);
        AttackLeft = LinkFactory.AttackLeft(texture, OnAttackFinished);
        AttackRight = LinkFactory.AttackRight(texture, OnAttackFinished);

        UseItemDown = LinkFactory.UseItemDown(texture, OnUseItemFinished);
        UseItemUp = LinkFactory.UseItemUp(texture, OnUseItemFinished);
        UseItemLeft = LinkFactory.UseItemLeft(texture, OnUseItemFinished);
        UseItemRight = LinkFactory.UseItemRight(texture, OnUseItemFinished);

        PickUpWeapon = LinkFactory.PickUpWeapon(texture, OnPickUpFinished);
        PickUpTriforce = LinkFactory.PickUpTriforce(texture, OnPickUpFinished);

        DeadSprite = LinkFactory.Dead(texture);
        DeathSparkleSprite = LinkFactory.DeathSparkle(dustTexture);

        sprite = IdleDown;
        Position = position;
        health = maxHealth;

        stateMachine = new LinkStateMachine(this);
    }

    private void OnAttackFinished() => stateMachine.OnAttackFinished();
    private void OnUseItemFinished() => stateMachine.OnUseItemFinished();
    private void OnPickUpFinished() => stateMachine.OnPickUpFinished();

    public void Update(GameTime gameTime) => stateMachine.Update(gameTime);

    public void Draw(SpriteBatch spriteBatch)
    {
        if (stateMachine.IsSparkleStage)
        {
            Vector2 center = new Vector2(position.X + BODY_SIZE / 2f, position.Y + BODY_SIZE / 2f);
            DeathSparkleSprite.Draw(spriteBatch, center);
            return;
        }

        if (stateMachine.DeathSequenceFinished) return;
        if (!stateMachine.IsVisible) return;

        sprite.Draw(spriteBatch, position);

        if (stateMachine.PickUpItemRect.HasValue)
        {
            Rectangle rect = stateMachine.PickUpItemRect.Value;
            Vector2 itemPos = GetPickedUpItemPosition(rect);

            spriteBatch.Draw(
                GameServices.ItemSheet,
                itemPos,
                rect,
                Color.White,
                0f,
                Vector2.Zero,
                GameServices.ScaleFactor,
                SpriteEffects.None,
                0f
            );
        }
    }

    public void SetMove(Directions dir) => stateMachine.HandleSetMove(dir);
    public void StopMove() => stateMachine.HandleStopMove();
    public void StartAttack() => stateMachine.HandleStartAttack();
    public void StartUseItem() => stateMachine.HandleStartUseItem();
    public void StartPickUpWeapon(Rectangle itemRect) => stateMachine.HandleStartPickUpWeapon(itemRect);
    public void StartPickUpTriforce(Rectangle itemRect) => stateMachine.HandleStartPickUpTriforce(itemRect);
    public bool ShouldEndTriforceSequence() => stateMachine.ShouldEndTriforceSequence();
    public void EndTriforceSequence() => stateMachine.HandleEndTriforceSequence();
    public void TakeDamage(int amount) => stateMachine.HandleTakeDamage(amount);
    public void StartPush() => stateMachine.HandleStartPush();
    public void StartDamaged() => stateMachine.HandleStartDamaged();
    public void StartDeath() => stateMachine.HandleStartDeath();

    internal void SetHealth(int value) => health = value;

    public void GetHealed(int amount)
    {
        health = MathHelper.Clamp(health + amount, 0, maxHealth);
        Console.WriteLine($"Link healed by {amount}. Current health: {health}");
    }

    public void AddHeartContainer()
    {
        maxHealth += 2;
        health = maxHealth;
    }

    public void IncreaseRupees(int amount)
    {
        resources.AddRupees(amount);
        Console.WriteLine($"Link picked up {amount} rupees. Current Rupees: {Rupees}");
    }

    public void DecreaseRupees(int amount)
    {
        resources.RemoveRupees(amount);
    }
    public int ReportRupees()
    {
        return Rupees;
    }

    private Attacking GetAttackSprite(Directions direction)
    {
        if (direction == Directions.Up) return AttackUp;
        if (direction == Directions.Down) return AttackDown;
        if (direction == Directions.Left) return AttackLeft;
        if (direction == Directions.Right) return AttackRight;

        return AttackDown;
    }

    private Vector2 GetPickedUpItemPosition(Rectangle rect)
    {
        if (stateMachine.IsTriforcePickup)
        {
            return new Vector2(
                position.X + rect.Width,
                position.Y - rect.Height * GameServices.ScaleFactor - 4
            );
        }

        Vector2 handPos = new Vector2(
            position.X + HAND_X * GameServices.ScaleFactor,
            position.Y + HAND_Y * GameServices.ScaleFactor
        );

        return new Vector2(
            handPos.X - (rect.Width * GameServices.ScaleFactor) / 2f,
            handPos.Y - rect.Height * GameServices.ScaleFactor
        );
    }
}
