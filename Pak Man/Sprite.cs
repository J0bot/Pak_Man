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

        /// <summary>
        /// Constructeur de la classe Sprite
        /// </summary>
        /// <param name="textureName">nom de la texture en string</param>
        /// <param name="clip">taille du sprite, par défaut en null</param>
        public Sprite(string textureName, Rectangle? clip = null)
        {
            Texture = Resources.GetTexture(textureName);
            _clip = clip;
            _origin = new Vector2(16, 16);
        }

        /// <summary>
        /// Basic draw with a position
        /// </summary>
        /// <param name="sb">SpriteBatch</param>
        /// <param name="position">Position of the Drawing</param>
        public void Draw(SpriteBatch sb, Vector2 position)
        {
            sb.Draw(Texture, position, _clip, Color.White);
        }

        /// <summary>
        /// Draw with a rotation and a SpriteEffect
        /// </summary>
        /// <param name="sb">spritebatch</param>
        /// <param name="position">position of the drawing</param>
        /// <param name="rotation">rotaion of the drawing</param>
        /// <param name="effects">SpriteEffects of the sprite</param>
        public void Draw(SpriteBatch sb, Vector2 position, float rotation, SpriteEffects effects = SpriteEffects.None)
        {

            sb.Draw(Texture, position, _clip, Color.White, rotation, _origin ,1f, effects, 0f);
        }
    }
}
