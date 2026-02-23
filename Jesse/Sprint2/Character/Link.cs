using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint.Block;
using Sprint.Factories;
using Sprint.Interfaces;

namespace Sprint.Character
{
    public class Link : ILink
    {
        private const double DamagedDuration = 0.5;
        private const double BlinkInterval = 0.10;

        private Texture2D texture;

        private ISprite IdleUp;
        private ISprite IdleDown;
        private ISprite IdleLeft;
        private ISprite IdleRight;

        private ISprite sprite;

        private ISprite WalkUp;
        private ISprite WalkDown;
        private ISprite WalkLeft;
        private ISprite WalkRight;

        private ISprite AttackUp;
        private ISprite AttackDown;
        private ISprite AttackLeft;
        private ISprite AttackRight;

        private int elapsedTime;
        private int frameTime;
        private double damagedTimer;
        private float speed = 80f;

        private Rectangle bounds;
        private bool isAttacking = false;
        private bool isDamaged = false;
        private bool isVisible = false;
        private bool blinkVisible = true;
        private KeyboardState prevKeys;
        private Vector2 move = Vector2.Zero;
        private Vector2 position;


        private Directions direction = Directions.Down;
        public Directions Facing => direction;

        public Link(Texture2D texture, Vector2 position)
        {
            this.position = position;
            this.texture = texture;

            IdleDown = LinkSprites.IdleDown(texture);
            IdleUp = LinkSprites.IdleUp(texture);
            IdleLeft = LinkSprites.IdleLeft(texture);
            IdleRight = LinkSprites.IdleRight(texture);

            WalkDown = LinkSprites.WalkingDown(texture);
            WalkUp = LinkSprites.WalkingUp(texture);
            WalkLeft = LinkSprites.WalkingLeft(texture);
            WalkRight = LinkSprites.WalkingRight(texture);

            AttackDown = LinkSprites.AttackDown(texture, FinishAttack);
            AttackUp = LinkSprites.AttackUp(texture, FinishAttack);
            AttackLeft = LinkSprites.AttackLeft(texture, FinishAttack);
            AttackRight = LinkSprites.AttackRight(texture, FinishAttack);

            sprite = IdleDown;
        }

        public int Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            if (!isAttacking && !isDamaged && move == Vector2.Zero)
            {
                SetIdleSprite();
            }

            /*
			I implemented the damaged state inside the Link class because it only modifies the existing
			behavior without introducing new rectangles.It can be refactored into a separate class if 
			needed in the future.
			*/
            if (isDamaged)
            {
                damagedTimer += gameTime.ElapsedGameTime.TotalSeconds;

                if ((int)(damagedTimer / BlinkInterval) % 2 == 0)
                {
                    isVisible = true;
                }
                else
                {
                    isVisible = false;
                }

                if (damagedTimer >= DamagedDuration)
                {
                    isDamaged = false;
                    isVisible = true;
                }
            }
            position += move * speed * dt;

            sprite.Update(gameTime);

            return 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (isDamaged && !isVisible)
            {
                return;
            }
            sprite.Draw(spriteBatch, position);
        }

        public void SetMove(Directions dir)
        {
            if (isAttacking) return;
            move = Vector2.Zero;
            direction = dir;

            switch (dir)
            {
                case Directions.Up:
                    sprite = WalkUp;
                    move.Y = -1;
                    break;

                case Directions.Down:
                    sprite = WalkDown;
                    move.Y = 1;
                    break;

                case Directions.Left:
                    sprite = WalkLeft;
                    move.X = -1;
                    break;

                case Directions.Right:
                    sprite = WalkRight;
                    move.X = 1;
                    break;

            }
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
                Directions.Up => IdleUp,
                Directions.Down => IdleDown,
                Directions.Left => IdleLeft,
                Directions.Right => IdleRight,
                _ => IdleDown,
            };
        }

        public void StopMove()
        {
            move = Vector2.Zero;
        }

        public void StartAttack()
        {
            if (isAttacking)
            {
                return;
            }

            isAttacking = true;

            move = Vector2.Zero;

            switch (direction)
            {
                case Directions.Up:
                    ((Attacking)AttackUp).Reset();
                    sprite = AttackUp;
                    break;

                case Directions.Down:
                    ((Attacking)AttackDown).Reset();
                    sprite = AttackDown;
                    break;

                case Directions.Left:
                    ((Attacking)AttackLeft).Reset();
                    sprite = AttackLeft;
                    break;

                case Directions.Right:
                    ((Attacking)AttackRight).Reset();
                    sprite = AttackRight;
                    break;

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

        public Vector2 Position
        {
            get => position;
            set => position = value;
        }

        void ISprite.Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            Draw(spriteBatch);
        }

    }
}
