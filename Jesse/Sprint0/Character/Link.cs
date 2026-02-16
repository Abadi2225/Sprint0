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
		private ISprite sprite;

		public Link(Texture2D texture, Vector2 position)
		{
			this.position = position;
			this.texture = texture;

			sprite = LinkSprites.IdleDown(texture);
		}

		public void Update(GameTime gameTime)
		{
			KeyboardState command = Keyboard.GetState();

			if(command.IsKeyDown(Keys.W))
			{
				sprite = LinkSprites.IdleUp(texture);
			}
			else if(command.IsKeyDown(Keys.S))
			{
				sprite = LinkSprites.IdleDown(texture);
			}
			else if (command.IsKeyDown(Keys.A))
			{
				sprite = LinkSprites.IdleLeft(texture);
			}
			else if (command.IsKeyDown(Keys.D))
			{
				sprite = LinkSprites.IdleRight(texture);
			}

			sprite.Update(gameTime);
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			sprite.Draw(spriteBatch, position);
		}
	}
}
