using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint.Sound
{
	internal class MusicPlayer
	{

		private static Dictionary<MusicType, string> musicLookup = new Dictionary<MusicType, string>()
		{
			{ MusicType.TITLE_THEME, "sounds/Title_theme"},
			{  MusicType.DUNGEON, "sounds/Dungeon"  }

		};

		private static MusicType currentMusic;
		public static void Play(MusicType type, bool repeat = true)
		{

			Song song = Game1.Instance.Content.Load<Song>(musicLookup[type]);
			MediaPlayer.IsRepeating = repeat;
			MediaPlayer.Play(song);
			currentMusic = type;
		}
		public static void Mute()
		{
			MediaPlayer.Volume = 0f;
		}

		public static void ToggleMute()
		{
			MediaPlayer.IsMuted = !MediaPlayer.IsMuted;
		}

	}
}
