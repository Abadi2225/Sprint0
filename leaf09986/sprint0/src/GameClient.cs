using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace sprint0;

public class GameClient
{
    private Game game_;
    private KeyboardListener keyboardListener_;
    private MouseListener mouseListener_;
    private int tickCounter_ = 0;

    private int mode_;
    private Dictionary<Type, ISprite> playerSprites_ = new Dictionary<Type, ISprite>();
    private Type activePlayerSprite_;
    private Vector2 playerLoc = new Vector2(100, 100);


    public GameClient(Game game)
    {
        game_ = game;
        setMode(1);
        keyboardListener_ = new KeyboardListener();
        mouseListener_ = new MouseListener();
        // load all types of player sprites
        playerSprites_.Add(typeof(MarioStill), new MarioStill());
        playerSprites_.Add(typeof(MarioRunForward), new MarioRunForward());

    }

    public void onUpdate()
    {
        tickCounter_++;
        if (tickCounter_ > 127)
        {
            tickCounter_ = 0;
        }

        keyboardListener_.onUpdate(game_, this);
        mouseListener_.onUpdate(game_, this);

        if (mode_ == 3 || mode_ == 4)
        {
            playerLoc.X++;
        }
        if (playerLoc.X > game_.Window.ClientBounds.X)
        {
            playerLoc.X = 0;
        }

        if ((tickCounter_ & 0b111) == 0b111)  // every 8 ticks
        {
            playerSprites_[activePlayerSprite_].advanceFrame();
        }
    }

    public void render(SpriteBatch spriteBatch)
    {
        // render credits
        SpriteFont font = game_.Content.Load<SpriteFont>("fonts/Font");
        spriteBatch.DrawString(
                font,
                "Created by: Lucas Ahn, Sprites Copyright Nintendo Co. Ltd.",
                new Vector2(0, 0),
                Color.Black
                );
        // render player sprite
        playerSprites_[activePlayerSprite_].render(playerLoc, spriteBatch, game_.Content);
    }

    public void setMode(int mode)
    {
        mode_ = mode;
        switch (mode)
        {
            case 1:
                activePlayerSprite_ = typeof(MarioStill);
                break;
            case 2:
                activePlayerSprite_ = typeof(MarioRunForward);
                break;
            case 3:
                activePlayerSprite_ = typeof(MarioStill);
                break;
            case 4:
                activePlayerSprite_ = typeof(MarioRunForward);
                break;
        }
    }

    public KeyboardListener getKeyboardListener()
    {
        return keyboardListener_;
    }
    public MouseListener GetMouseListener()
    {
        return mouseListener_;
    }
}
