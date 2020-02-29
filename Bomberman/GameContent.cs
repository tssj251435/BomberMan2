using Microsoft.Xna.Framework.Content;

namespace Bomberman
{
    public class GameContent
    {
        public ContentManager content { private set; get; }

        public GameContent(ContentManager content)
        {
            this.content = content;
        }
    }
}
