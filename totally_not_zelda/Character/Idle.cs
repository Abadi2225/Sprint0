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

        public Vector2 Position { get; set; }  // unused; added to resolve merge conflict

        public Idle(Texture2D texture, Rectangle sourceRect, SpriteEffects effect)
        {
            this.texture = texture;
            this.sourceRect = sourceRect;
            this.effect = effect;
        }

        public int Update(GameTime gameTime)
        {
            return 0;
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