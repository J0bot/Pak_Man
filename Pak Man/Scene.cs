using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Pak_Man
{
    public abstract class Scene
    {
        internal readonly List<IDrawable> GameObjects;

        public string ID { get; }

        public Scene(string id)
        {
            ID = id;
            GameObjects = new List<IDrawable>();
        }

        public void Draw(SpriteBatch sb)
        {
            foreach (IDrawable gobj in GameObjects)
            {
                gobj.Draw(sb);
            }
        }

        public abstract void Update(GameTime gameTime);
    }
}
