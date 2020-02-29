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
        protected Texture2D image { private set; get; }
        public Position Position;

        public GraphicalElement(SpriteBatch spriteBatch, Texture2D image,Position position )
        {
            this.spriteBatch = spriteBatch;
            this.image = image;
            this.Position = position;
        }
    }
}
