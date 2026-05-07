using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint.Commands;
using Sprint.Interfaces;
using Sprint.Sound;
using Sprint.UI.Text;

namespace Sprint.GameStates;

internal class GameCompleteState : IGameState
{
    private Texture2D fontSheet;
    private Texture2D pixel;
    private TextWriter titleText;
    private TextWriter enemiesText;
    private TextWriter timeText;
    private TextWriter rupeesText;
    private TextWriter pressRText;

    public void Enter()
    {
        MusicPlayer.Mute();
        GameServices.CurrentDungeon = 1;
    }

    public void Exit() { }

    public void LoadContent()
    {
        fontSheet = GameServices.Content.Load<Texture2D>("images/Fonts");

        pixel = new Texture2D(GameServices.GraphicsDevice, 1, 1);
        pixel.SetData(new[] { Color.White });

        int screenW = GameServices.GameWidth;

        titleText = CenterLine(fontSheet, "YOU WON!", 3f, 170f);

        TimeSpan elapsed = GameStats.GetElapsedTime();
        int minutes = (int)elapsed.TotalMinutes;
        int seconds = elapsed.Seconds;

        enemiesText = CenterLine(fontSheet, $"ENEMIES DEFEATED  {GameStats.EnemiesDefeated}", 2f, 280f);
        timeText    = CenterLine(fontSheet, $"TIME  {minutes}M {seconds}S",                   2f, 340f);
        rupeesText  = CenterLine(fontSheet, $"RUPEES  {GameServices.Link?.Rupees ?? 0}",       2f, 400f);
        pressRText  = CenterLine(fontSheet, "PRESS R TO RESET",                                2f, 480f);
    }

    private static TextWriter CenterLine(Texture2D font, string text, float scale, float y)
    {
        float width = text.Length * 9f * scale;
        float x = (GameServices.GameWidth - width) / 2f;
        return new TextWriter(font, text, new Vector2(x, y), scale, false);
    }

    public void Update(GameTime gameTime)
    {
        if (GameServices.KeyInput.IsKeyPressed(Keys.R))
            new RestartGameCommand().Execute();
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(
            pixel,
            new Rectangle(0, 0, GameServices.GameWidth, GameServices.GameHeight),
            Color.Black
        );
        titleText.Draw(spriteBatch);
        enemiesText.Draw(spriteBatch);
        timeText.Draw(spriteBatch);
        rupeesText.Draw(spriteBatch);
        pressRText.Draw(spriteBatch);
    }
}
