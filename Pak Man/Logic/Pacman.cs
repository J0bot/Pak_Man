using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pak_Man
{
    public class Pacman : GameObject
    {

        public int Speed { get; set; }
        public Vector2 Direction { get; set; } = new Vector2(1, 0);

        private readonly SpriteSheet spriteSheet;

        private SpriteAnimated animatedSprite;

        private readonly List<Sprite> sprites;

        public Pacman() : base ("Pacman", new Sprite("pacman", new Rectangle(0, 0, 32, 32)))
        {
            spriteSheet = new SpriteSheet("pacman", 4, 1, 32, 32);

            sprites = new List<Sprite>()
            {
                spriteSheet[0, 0],
                spriteSheet[1, 0],
                spriteSheet[2, 0],
                spriteSheet[3, 0]

            };

            animatedSprite = new SpriteAnimated();

            animatedSprite.Add(spriteSheet[0, 0]);
            animatedSprite.Add(spriteSheet[1, 0]);
            animatedSprite.Add(spriteSheet[2, 0]);
            animatedSprite.Add(spriteSheet[3, 0]);
            

            Speed = 2;
        }

        public void Move()
        {
            Position += Direction * Speed;
        }

        public override void Draw(SpriteBatch sb)
        {
            //animatedSprite.Draw(sb, Position);
            sprites[0].Draw(sb, Position, 90);
        }
        /*
        PAC_MAN_01,     //Iconic stage
        PAC_MAN_02,     //Mouth big open
        PAC_MAN_03,     //Closed
        PAC_MAN_04      //Hmmmmm
         */
    }
}
