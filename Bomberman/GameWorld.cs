using Bomberman.GraphicalElements;
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
        List<Box> boxes;
        public static int screenWidth { private set; get; }
        public static int screenHeight { private set; get; }

        public static Random random;

        public GameWorld(Game1 game1, SpriteBatch spriteBatch)
        {
            this.game1 = game1;
            this.spriteBatch = spriteBatch;
            boxes = new List<Box>();
            screenWidth = game1.GraphicsDevice.Viewport.Width;
            screenHeight = game1.GraphicsDevice.Viewport.Height;
            InstansiateBoxes();
        }

        public void InstansiateBoxes()
        {
            int numBoxesHorizontal = screenWidth / GameContent.Box.Width;
            int numBoxesVertical = screenHeight / GameContent.Box.Height;

            for (int i = 0; i < numBoxesVertical; i++)
            {
           
                float posX;
                float posY = 100;
                if (i == 0)
                    posX = GameContent.Box.Width * 1.5f;
                //posY = GameContent.Box.Height * 1.5f;
                else
                    posX = i * GameContent.Box.Width;
                if (i != 0)
                    boxes.Add(new Box(spriteBatch, GameContent.Box, new Vector2(posX, posY)));
            }

        }
        public void DrawAll()
        {
            foreach (Box box in boxes)
            {
                box.Draw();
            }
        }

    }
}
