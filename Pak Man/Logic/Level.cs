using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pak_Man
{
    public class Level : IDrawable
    {
        public int Height { get; }
        public int Width { get; }

        private readonly Tile[,] tiles;
        private readonly SpriteSheet _spritesheet;
        private readonly Texture2D _texColorMap;
        private readonly Color[] pixels;

        private Dictionary<Tile, Sprite> sprites;

        public Level()
        {
            Height = 31;
            Width = 28;

            tiles = new Tile[Width, Height];
            pixels = new Color[Width * Height];

            _spritesheet = new SpriteSheet("walls_spritesheet", 5, 3, 32, 32);
            _texColorMap = Resources.GetTexture("map");
            _texColorMap.GetData(pixels);

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Color px = pixels[y * Width + x];
                    if      (px.R == 0 && px.G == 0 && px.B == 0)
                        tiles[x, y] = Tile.FOOD;
                    else if (px.R == 255 && px.G == 0 && px.B == 0)
                        tiles[x, y] = Tile.WALL_BOTTOM;
                    else if (px.R == 0 && px.G == 255 && px.B == 0)
                        tiles[x, y] = Tile.WALL_TOP;
                    else if (px.R == 0 && px.G == 0 && px.B == 255)
                        tiles[x, y] = Tile.WALL_LEFT;
                    else if (px.R == 0 && px.G == 255 && px.B == 255)
                        tiles[x, y] = Tile.WALL_RIGHT;
                    else if (px.R == 100 && px.G == 0 && px.B == 0)
                        tiles[x, y] = Tile.CORNER_BOTTOM_LEFT;
                    else if (px.R == 0 && px.G == 100 && px.B == 0)
                        tiles[x, y] = Tile.CORNER_BOTTOM_RIGHT;
                    else if (px.R == 255 && px.G == 255 && px.B == 0)
                        tiles[x, y] = Tile.CORNER_TOP_LEFT;
                    else if (px.R == 255 && px.G == 0 && px.B == 255)
                        tiles[x, y] = Tile.CORNER_TOP_RIGHT;
                }
            }

            sprites = new Dictionary<Tile, Sprite>()
            {
                { Tile.FOOD, _spritesheet[1, 1] },
                { Tile.WALL_BOTTOM, _spritesheet[1, 2] },
                { Tile.WALL_TOP, _spritesheet[1, 0] },
                { Tile.WALL_LEFT, _spritesheet[0, 1] },
                { Tile.WALL_RIGHT, _spritesheet[2, 1] },
                { Tile.CORNER_BOTTOM_LEFT, _spritesheet[0, 2] },
                { Tile.CORNER_BOTTOM_RIGHT, _spritesheet[2, 2] },
                { Tile.CORNER_TOP_LEFT, _spritesheet[0, 0] },
                { Tile.CORNER_TOP_RIGHT, _spritesheet[2, 0] }
            };
        }

        public void Draw(SpriteBatch sb)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Tile tile = tiles[x, y];
                    if (tile != Tile.EMPTY)
                    {
                        sprites[tile].Draw(sb, new Vector2(x, y) * 32);
                    }
                }
            }
        }
    }
}
