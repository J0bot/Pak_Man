using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Pak_Man
{
    public class MainScene : Scene
    {
        private readonly Pacman pacman;
        private readonly Level level;

        public MainScene() : base ("MainScene")
        {
            pacman = new Pacman();
            level = new Level();

            GameObjects.Add(level);
            GameObjects.Add(pacman);
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Down))
            {
                pacman.Direction = new Vector2(0, 1);
            }
            else if (state.IsKeyDown(Keys.Up))
            {
                pacman.Direction = new Vector2(0, -1);
            }
            else if (state.IsKeyDown(Keys.Left))
            {
                pacman.Direction = new Vector2(-1, 0);
            }
            else if (state.IsKeyDown(Keys.Right))
            {
                pacman.Direction = new Vector2(1, 0);
            }

            pacman.Move();
        }
    }
}