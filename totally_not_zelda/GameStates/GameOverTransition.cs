using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Sprint.Character;
using Sprint.UI;

namespace Sprint.GameStates
{
	internal class GameOverTransition
	{

		private readonly Rectangle gameplayBounds;
		private enum Phase
		{
			None,
			WaitingForLinkDeath,
			BlackingOut,
			ShowingGameOver,
			Finished
		}

		private Phase phase = Phase.None;

		private float timer;
		private float blackOutDegree;

		private readonly Texture2D pixel;
		private readonly GameOverText gameOverText;
		private const float transitionSpeed = 1f;
		private const double gameOverDisplayDuration = 3.0;

		public bool Active => phase == Phase.WaitingForLinkDeath || phase == Phase.BlackingOut || phase == Phase.ShowingGameOver;
		public bool Finished => phase == Phase.Finished;

		public GameOverTransition(Rectangle gameplayBounds, GraphicsDevice graphicsDevice, GameOverText text)
		{
			this.gameplayBounds = gameplayBounds;
			this.gameOverText = text;
			this.pixel = new Texture2D(graphicsDevice, 1, 1);
			pixel.SetData(new[] { Color.White });

		}

		public void Start()
		{
			if(phase != Phase.None) return; 
			phase = Phase.WaitingForLinkDeath;
			blackOutDegree = 0;
			timer = 0;
		}

		//public void Reset()
		//{
		//	phase = Phase.None;
		//	blackOutDegree = 0;
		//	timer = 0;
		//}

		public void Update(GameTime gameTime, Link link)
		{
			if (phase == Phase.None || phase == Phase.Finished) return;

			double dt = gameTime.ElapsedGameTime.TotalSeconds;

			switch (phase)
			{

				case Phase.WaitingForLinkDeath:
	
						phase = Phase.BlackingOut;
					
					break;

				case Phase.BlackingOut:
					blackOutDegree += (float)dt * transitionSpeed;
					if (blackOutDegree >= 1f)
					{
						blackOutDegree = 1f;
						phase = Phase.ShowingGameOver;
					}
					break;

				case Phase.ShowingGameOver:
					timer += (float)dt;
					if (timer >= gameOverDisplayDuration) phase = Phase.Finished;
					break;
			}
		}


		public void DrawBlackOut(SpriteBatch spriteBatch){
			if (phase == Phase.None || phase == Phase.Finished) return;

			spriteBatch.Draw(
				pixel,
				gameplayBounds,
				Color.Black * blackOutDegree
			);
		}

		public void DrawGameOverText(SpriteBatch spriteBatch)
		{
			if (phase != Phase.ShowingGameOver && phase != Phase.Finished) return;

			Vector2 position = new Vector2(260f, 300f);
			float scale = 3f;

			gameOverText.Draw(spriteBatch, position, scale);
		}
	}
}
