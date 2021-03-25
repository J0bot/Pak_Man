using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Pak_Man
{
    public class Sprite
    {
        public  Texture2D Texture { get; }
        private Rectangle? _clip;
        private Vector2 _origin;


        public Sprite(string textureName, Rectangle? clip = null)
        {
            Texture = Resources.GetTexture(textureName);
            _clip = clip;
            _origin = new Vector2(Texture.Width / 2f, Texture.Height / 2f);
        }

        public void Draw(SpriteBatch sb, Vector2 position)
        {
            sb.Draw(Texture, position, _clip, Color.White);
        }

        public void Draw(SpriteBatch sb, Vector2 position, float rotation)
        {

            sb.Draw(Texture, position, _clip, Color.White, rotation, _origin ,1f, SpriteEffects.None, 0f);
        }
    }
}
