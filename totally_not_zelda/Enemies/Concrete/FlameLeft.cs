using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Enemies.Base;
using Sprint.Sprites;

namespace Sprint.Enemies.Concrete
{
	public class FlameLeft : Enemy
	{
		private const int HEALTH = 1;
		private const int DAMAGE = 0;

		public FlameLeft(Texture2D texture, Vector2 position) : base(texture, position, HEALTH, DAMAGE, isInvincible: true)
		{
			int spriteWidth = 16;
			int spriteHeight = 16;

			sprite = new StaticSprite(texture, position, new Rectangle(52, 11, spriteWidth, spriteHeight));
			Rect = new Rectangle((int)position.X, (int)position.Y, spriteWidth * (int)GameServices.ScaleFactor, spriteHeight * (int)GameServices.ScaleFactor);
		}

		public override void TakeDamage(int damageAmount) { }
		public override void Die() { }
	}
}
