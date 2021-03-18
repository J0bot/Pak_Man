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
        private readonly Texture2D _texWall;
        private readonly Texture2D _texMap;
        private readonly Texture2D _texFood;
        private readonly List<Texture2D> _texWalls;

        public World(Texture2D texMap, Texture2D _texBloc, Texture2D texFood, List<Texture2D> walls)
        {
            Height = 31;
            Width = 28;

            map = new TileType[Width, Height];
            _texWall = _texBloc;
            this._texMap = texMap;
            _texFood = texFood;
            _texWalls = walls;
        }

        public void Draw(SpriteBatch sb)
        {
            Color[] pixels = new Color[Width * Height];
            _texMap.GetData(pixels);
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (pixels[y * Width + x].R == 255 && pixels[y * Width + x].G ==0 && pixels[y * Width + x].B ==0) //wallDown
                    {
                        sb.Draw(_texWalls[0], new Vector2(x, y) * _texWall.Width, Color.White);
                    }
                    else if (pixels[y * Width + x].R == 0 && pixels[y * Width + x].G == 255 && pixels[y * Width + x].B == 0) //wallUp
                    {
                        sb.Draw(_texWalls[1], new Vector2(x, y) * _texWall.Width, Color.White);
                    }
                    else if (pixels[y * Width + x].R == 0 && pixels[y * Width + x].G ==255 && pixels[y * Width + x].B ==255) //wallRight
                    {
                        sb.Draw(_texWalls[2], new Vector2(x, y) * _texWall.Width, Color.White);
                    }
                    else if (pixels[y * Width + x].R == 0 && pixels[y * Width + x].G ==0 && pixels[y * Width + x].B ==255) //wallLeft
                    {
                        sb.Draw(_texWalls[3], new Vector2(x, y) * _texWall.Width, Color.White);
                    }
                    else if (pixels[y * Width + x].R == 100 && pixels[y * Width + x].G ==0 && pixels[y * Width + x].B ==0) //wallCornerDownLeft
                    {
                        sb.Draw(_texWalls[4], new Vector2(x, y) * _texWall.Width, Color.White);
                    }
                    else if (pixels[y * Width + x].R == 0 && pixels[y * Width + x].G == 100 && pixels[y * Width + x].B == 0) //wallCornerDownRight
                    {
                        sb.Draw(_texWalls[5], new Vector2(x, y) * _texWall.Width, Color.White);
                    }
                    else if (pixels[y * Width + x].R == 255 && pixels[y * Width + x].G == 255 && pixels[y * Width + x].B == 0) //wallCornerTopLeft
                    {
                        sb.Draw(_texWalls[6], new Vector2(x, y) * _texWall.Width, Color.White);
                    }
                    else if (pixels[y * Width + x].R == 255 && pixels[y * Width + x].G == 0 && pixels[y * Width + x].B == 255) //wallCornerTopRight
                    {
                        sb.Draw(_texWalls[7], new Vector2(x, y) * _texWall.Width, Color.White);
                    }
                    else if (pixels[y * Width + x].R == 0 && pixels[y * Width + x].G == 0 && pixels[y * Width + x].B == 0) 
                        {
                        sb.Draw(_texFood, new Vector2(x, y) * _texFood.Width, Color.White);
                    }
                }
            }
        }
    }
}
