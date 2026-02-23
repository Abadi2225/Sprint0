using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Sprint.Character;
using Sprint.Interfaces;
using Sprint.Sprites;

namespace Sprint.Item;

internal class Boomerang : AbstractItem
{
    private static string ResourceName = "items/boomerang";

	public Boomerang(Vector2 pos, Vector2 vel, ContentManager contentManager) : base("boomerang", contentManager, ResourceName, pos)
    {
		sprite = new BoomerangSprite(
                texture,
                DrawPos,
                vel,
                0.2f
                );

		UseAction = (entity) =>
		{
			if (entity is not ILink link) return;

			Vector2 dir = link.Facing switch
			{
				Directions.Up => new Vector2(0, -1),
				Directions.Down => new Vector2(0, 1),
				Directions.Left => new Vector2(-1, 0),
				Directions.Right => new Vector2(1, 0),
				_ => new Vector2(0, 1),
			};

			Vector2 start = link.Position + dir * 20f;

			float projectileSpeed = 300f; 
			Vector2 projVel = dir * projectileSpeed;

			var proj = new BoomerangSprite(texture, start, projVel, 0.2f);
			proj.Throw();
			ItemManager.Current?.SpawnProjectile(proj);
		};

		//UseAction = (entity) =>
		//{
		//    if (sprite is BoomerangSprite bsprite)
		//    {
		//        bsprite.Throw();
		//    }
		//};
	}

    public override void Draw(SpriteBatch sb, Vector2 pos)
    {
        sprite.Draw(sb, DrawPos);
    }

    public override int Update(GameTime time)
    {
        sprite.Update(time);
        return 0;
    }
    public ISprite GetSprite() => sprite;
}
