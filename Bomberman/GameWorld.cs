﻿using Bomberman.GraphicalElements;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    public class GameWorld
    {

        Game1 game1;
        public GameTime gameTime;
        SpriteBatch spriteBatch;
        KeyboardState keyState;

        public static int screenWidth { private set; get; }
        public static int screenHeight { private set; get; }

         
        public static Random random;

        public GameWorld(Game1 game1, SpriteBatch spriteBatch)
        {
            this.game1 = game1;
            this.spriteBatch = spriteBatch;

            screenWidth = game1.GraphicsDevice.Viewport.Width;
            screenHeight = game1.GraphicsDevice.Viewport.Height;

        }

    }
}
