﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sprint.Interfaces;

namespace Sprint.Character
{
    internal class Idle : ISprite
    {
        private Texture2D texture;
        private Rectangle sourceRect;
        private SpriteEffects effect;

        public Idle(Texture2D texture, Rectangle sourceRect, SpriteEffects effect)
        {
            this.texture = texture;
            this.sourceRect = sourceRect;
            this.effect = effect;
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            spriteBatch.Draw(
                texture,
                location,
                sourceRect,
                Color.White,
                0f,
                Vector2.Zero,
                2f,
                effect,
                0f
                );
        }
    }
}