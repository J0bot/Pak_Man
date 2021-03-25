using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Pak_Man
{
    public class Sprite
    {
        public  Texture2D Texture { get; }
        private Rectangle? _clip;

        public Sprite(string textureName, Rectangle? clip = null)
        {
            Texture = Resources.GetTexture(textureName);
            _clip = clip;
        }

        public void Draw(SpriteBatch sb, Vector2 position)
        {
            sb.Draw(Texture, position, _clip, Color.White);
        }
    }
}
