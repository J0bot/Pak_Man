using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pak_Man
{
    public class PacMan
    {
        public static readonly int SPEED = 2;

        public Vector2 Direction { get; set; } = new Vector2(1, 0);

        public Vector2 Position { get; set; }

        public Texture2D Texture { get; set; }

        public PacMan(Vector2 position, Texture2D texture)
        {
            Position = position;
            Texture = texture;
        }

        public void Move()
        {
            Position += Direction*SPEED;

            if (Direction == new Vector2(1,0))
            {
                
            }
        }

    }
}
