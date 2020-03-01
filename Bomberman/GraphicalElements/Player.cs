using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman.GraphicalElements
{
    public enum Direction { Right, Left, Up, Down}

    class Player : GraphicalElement
    {

        public Player(SpriteBatch spriteBatch, Texture2D image, Vector2 position) : base(spriteBatch, image, position) { }

        List<Texture2D> RightAnimations;
        List<Texture2D> LeftAnimations;



        public override void Draw()
        {
            spriteBatch.Draw(image,
                Position,
                null,
                Color.White,
                1f,
                new Vector2(image.Width / 2, image.Height / 2),
                1f,
                SpriteEffects.None,
                0f);
        }

        public bool IsMoving;
        public Direction Direction;
        private Direction previousDirection;
        private int animationSelecter;
        public void Move()
        { 
            if (previousDirection != Direction)
                animationSelecter = 0;

            switch (Direction)
            {
                case Direction.Right:
                    break;
                case Direction.Left:
                    break;
                case Direction.Up:
                    break;
                case Direction.Down:
                    break;
            }

            previousDirection = Direction;
        }

    }
}
