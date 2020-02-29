using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Bomberman
{
    public static class GameContent
    {
        public static ContentManager contentManager;

        public static Texture2D Box { get { return contentManager.Load<Texture2D>("./Images/Box");}}
    }
}
