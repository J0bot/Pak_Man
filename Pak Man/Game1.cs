using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pak_Man
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _texPacMan;
        private Texture2D _texBloc;
        private Texture2D _texMap;
        private World world;

        private PacMan pacMoon;

        private int x;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            pacMoon = new PacMan(Vector2.Zero, _texPacMan);
            world = new World(_texMap, _texBloc);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _texPacMan = Content.Load<Texture2D>(@"sprites/pake_men");
            _texBloc = Content.Load<Texture2D>(@"sprites/block");
            _texMap = Content.Load<Texture2D>(@"sprites/map01");
        }

        
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState state = Keyboard.GetState();

            
            if (state.IsKeyDown(Keys.Escape))
            {
                Exit();
            }

            if (state.IsKeyDown(Keys.Down))
            {
                pacMoon.Direction = new Vector2(0, 1);
            }
            else if (state.IsKeyDown(Keys.Up))
            {
                pacMoon.Direction = new Vector2(0, -1);
            }
            else if (state.IsKeyDown(Keys.Left))
            {
                pacMoon.Direction = new Vector2(-1, 0);
            }
            else if (state.IsKeyDown(Keys.Right))
            {
                pacMoon.Direction = new Vector2(1, 0);
            }

            pacMoon.Move();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //MOVE

            

            // TODO: Add your drawing code here
            
            _spriteBatch.Begin();
            world.Draw(_spriteBatch);
            _spriteBatch.Draw(_texPacMan, pacMoon.Position, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
