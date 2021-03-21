using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pak_Man
{
    public abstract class GameObject : IDrawable
    {
        public string ID { get; }
        public Vector2 Position { get; set; } = Vector2.Zero;

        private readonly Sprite _sprite;

        public GameObject(string id, Sprite sprite)
        {
            _sprite = sprite;
            ID = id;
        }

        public virtual void Draw(SpriteBatch sb)
        {
            sb.Draw(_sprite.Texture, Position, Color.White);
        }
    }
}
