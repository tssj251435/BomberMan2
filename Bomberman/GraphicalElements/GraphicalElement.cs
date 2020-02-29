using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.GraphicalElements
{
    public abstract class GraphicalElement
    {
        public abstract void Draw();

        protected SpriteBatch spriteBatch { private set; get; }
        protected Texture2D image { private set; get }

        public GraphicalElement(SpriteBatch spriteBatch, Texture2D image)
        {
            this.spriteBatch = spriteBatch;
            this.image = image;
        }
    }
}
