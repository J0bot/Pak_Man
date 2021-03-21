using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pak_Man
{
    public class Pacman : GameObject
    {
        public int Speed { get; set; }
        public Vector2 Direction { get; set; } = new Vector2(1, 0);

        public Pacman() : base ("Pacman", new Sprite("pacman"))
        {
            Speed = 2;
        }

        public void Move()
        {
            Position += Direction * Speed;
        }

    }
}
