using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pak_Man
{
    public class SpriteAnimated
    {
        private List<Sprite> sprites;

        public int Delay { get; set; }
        

        public SpriteAnimated(int delay = 10)
        {
            this.Delay = delay;
            sprites = new List<Sprite>();
        }

        public void Add(Sprite sprite)
        {
            sprites.Add(sprite);
        }

        public void Draw(SpriteBatch sb, Vector2 pos)
        {
            foreach (Sprite sprite in sprites)
            {
                sprite.Draw(sb, pos);               
            }

        }

    }
}
