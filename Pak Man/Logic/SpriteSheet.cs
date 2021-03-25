using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pak_Man
{
    public class SpriteSheet
    {
        private readonly Sprite[,] sprites;

        public SpriteSheet(string resourceName, int tileCountX, int tileCountY, int tileSizeX, int tileSizeY)
        {
            sprites = new Sprite[tileCountX, tileCountY];
            Texture2D tex = Resources.GetTexture(resourceName);

            for (int y = 0; y < tileCountY; y++)
            {
                for (int x = 0; x < tileCountX; x++)
                {
                    sprites[x, y] = new Sprite(resourceName, new Rectangle(x * tileSizeX, y * tileSizeY, tileSizeX, tileSizeY));
                }
            }
        }

        public Sprite this[int x, int y]
        {
            get => sprites[x, y];
        }
    }
}