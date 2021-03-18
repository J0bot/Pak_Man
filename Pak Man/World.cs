using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pak_Man
{
    public class World
    {
        public int Height { get; set; }
        public int Width { get; set; }

        private readonly TileType[,] map;
        private readonly Texture2D texWall;
        private readonly Texture2D texMap;

        public World(Texture2D texMap, Texture2D _texBloc)
        {
            Height = 31;
            Width = 28;

            map = new TileType[Width, Height];
            texWall = _texBloc;
            this.texMap = texMap;
        }

        public void Draw(SpriteBatch sb)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    sb.Draw(texWall, new Vector2(x, y) * texWall.Width, Color.White);
                }
            }
        }
    }
}
