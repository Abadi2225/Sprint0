using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint.Character;

namespace Sprint.Interfaces
{
	public interface ILink : IPositionedSprite
	{
		Directions Facing{
			get;
		}

		void StartAttack();
	}
}
