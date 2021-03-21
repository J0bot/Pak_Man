using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pak_Man
{
    public class Sprite
    {
        public  Texture2D Texture { get; }
        private Vector2 _rectPos;
        private Rectangle? _clip;

        public Sprite(string textureName, Vector2 rectPos, Rectangle clip)
        {
            Texture = Resources.GetTexture(textureName);
            _rectPos = rectPos;
            _clip = clip;
        }

        public Sprite(string textureName)
        {
            Texture = Resources.GetTexture(textureName);
            _rectPos = Vector2.Zero;
            _clip = null;
        }

        public void Draw(SpriteBatch sp)
        {
            sp.Draw(Texture, _rectPos, _clip, Color.White);
        }

    }
}
