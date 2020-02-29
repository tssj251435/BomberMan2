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

        public Box(SpriteBatch spriteBatch, Texture2D image) : base(spriteBatch, image){}


        public override void Draw() 
        {
            spriteBatch.Draw(image,)
        }
    }
}
