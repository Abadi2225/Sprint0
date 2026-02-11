using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegendOfZilda
{
	internal class SetCommand : ICommand
	{
		private Game1 game;
		private int id;
		public SetCommand(Game1 game, int id) { this.game = game; this.id = id; }
		public void Execute() { game.SetSprite(id); }
	}
}
