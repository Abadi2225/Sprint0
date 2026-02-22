using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint.Factories;
using Sprint.Interfaces;

namespace Sprint.Character
{
	internal class Link
	{
		private Vector2 position;
		private Texture2D texture;

		private ISprite IdleUp;
		private ISprite IdleDown;
		private ISprite IdleLeft;
		private ISprite IdleRight;

		private ISprite WalkUp;
		private ISprite WalkDown;
		private ISprite WalkLeft;
		private ISprite WalkRight;

		private ISprite sprite;
		private float speed = 80f;
		private bool isAttacking = false;
		private KeyboardState prevKeys;

		private enum Directions { Left, Right, Up, Down }
		private Directions direction = Directions.Down;

		public Link(Texture2D texture, Vector2 position)
		{
			this.position = position;
			this.texture = texture;

			IdleDown  = LinkSprites.IdleDown(texture);
			IdleUp    = LinkSprites.IdleUp(texture);
			IdleLeft  = LinkSprites.IdleLeft(texture);
			IdleRight = LinkSprites.IdleRight(texture);

			WalkDown  = LinkSprites.WalkingDown(texture);
			WalkUp    = LinkSprites.WalkingUp(texture);
			WalkLeft  = LinkSprites.WalkingLeft(texture);
			WalkRight = LinkSprites.WalkingRight(texture);

			sprite = IdleDown;
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

		public void Update(GameTime gameTime)
		{
			float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
			KeyboardState keys = Keyboard.GetState();

			// Attack on Z or N (press, not hold)
			if (!isAttacking &&
				(keys.IsKeyDown(Keys.Z) || keys.IsKeyDown(Keys.N)) &&
				(prevKeys.IsKeyUp(Keys.Z) && prevKeys.IsKeyUp(Keys.N)))
			{
				isAttacking = true;
				sprite = direction switch
				{
					Directions.Up    => LinkSprites.AttackUp(texture, FinishAttack),
					Directions.Down  => LinkSprites.AttackDown(texture, FinishAttack),
					Directions.Left  => LinkSprites.AttackLeft(texture, FinishAttack),
					Directions.Right => LinkSprites.AttackRight(texture, FinishAttack),
					_                => LinkSprites.AttackDown(texture, FinishAttack),
				};
			}

			if (!isAttacking)
			{
				Vector2 move = Vector2.Zero;

				if (keys.IsKeyDown(Keys.W) || keys.IsKeyDown(Keys.Up))
				{
					direction = Directions.Up;
					sprite = WalkUp;
					move.Y = -1;
				}
				else if (keys.IsKeyDown(Keys.S) || keys.IsKeyDown(Keys.Down))
				{
					direction = Directions.Down;
					sprite = WalkDown;
					move.Y = 1;
				}
				else if (keys.IsKeyDown(Keys.A) || keys.IsKeyDown(Keys.Left))
				{
					direction = Directions.Left;
					sprite = WalkLeft;
					move.X = -1;
				}
				else if (keys.IsKeyDown(Keys.D) || keys.IsKeyDown(Keys.Right))
				{
					direction = Directions.Right;
					sprite = WalkRight;
					move.X = 1;
				}
				else
				{
					SetIdleSprite();
				}

				position += move * speed * dt;
			}

			prevKeys = keys;
			sprite.Update(gameTime);
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			sprite.Draw(spriteBatch, position);
		}
	}
}
