using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.Character
{
	internal class LinkResources
	{
		private const int StartingBombs = 6;

		public int Rupees { get; private set; }
		public int Keys { get; private set; }
		public int Bombs { get; private set; } = StartingBombs;

		public void AddKey() => Keys++;

		public bool UseKey()
		{
			if (Keys <= 0) return false;
			Keys--;
			return true;
		}

		public void AddBombs(int amount) => Bombs += amount;

		public bool UseBomb()
		{
			if (Bombs <= 0) return false;
			Bombs--;
			return true;
		}

		public void AddRupees(int amount) => Rupees += amount;

		public void RemoveRupees(int amount)
		{
			Rupees = Math.Max(0, Rupees - amount);
		}

		public void SetBombs(int amount) => Bombs = amount;
		public void SetKeys(int amount) => Keys = amount;
	}
}
