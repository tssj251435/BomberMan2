﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.GraphicalElements
{
    public class Box : GraphicalElement
    {

        public Box(SpriteBatch spriteBatch, Texture2D image,Vector2 position) : base(spriteBatch, image, position){}


        public override void Draw() 
        {
            spriteBatch.Draw(image,
                Position,
                null,
                Color.White,
                0f,
                new Vector2(image.Width / 2, image.Height / 2),
                1f,
                SpriteEffects.None,
                0f);



        }
    }
}
