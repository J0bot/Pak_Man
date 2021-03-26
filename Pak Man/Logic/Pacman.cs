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

        private SpriteEffects spriteEffects;

        private float rotation;

        private Random random;

        private int animationTest;
        private int animationCounter;

        private readonly List<Sprite> sprites;

        public Pacman() : base ("Pacman", new Sprite("pacman", new Rectangle(0, 0, 32, 32)))
        {
            random = new Random();
            spriteSheet = new SpriteSheet("pacman", 4, 1, 32, 32);

            animationTest = 0;

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

            rotation = 0;

            Speed = 2;
        }

        /// <summary>
        /// Fonction move qui permet d'ajuster l'etat du personnage suivant la direction
        /// </summary>
        public void Move()
        {
            Position += Direction * Speed;

            if (Direction == new Vector2(1,0))
            {
                spriteEffects = SpriteEffects.None;
                rotation = 0;
            }
            else if (Direction == new Vector2(-1,0))
            {
                spriteEffects = SpriteEffects.FlipHorizontally;
                rotation = 0;
            }
            else if (Direction == new Vector2(0, 1))
            {
                spriteEffects = SpriteEffects.None;
                rotation = 90;
            }
            else if (Direction == new Vector2(0, -1))
            {
                spriteEffects = SpriteEffects.None;
                rotation = -90;
            }

            if (animationCounter<10)
            {
                animationTest = 0;
            }
            else if (animationCounter <20)
            {
                animationTest = 1;
            }
            else if (animationCounter < 30)
            {
                animationTest = 2;
            }
            else if (animationCounter==30)
            {
                animationCounter = 0;
            }


            animationCounter++;

        }

        public override void Draw(SpriteBatch sb)
        {
            //animatedSprite.Draw(sb, Position);
            sprites[animationTest].Draw(sb, Position, rotation, spriteEffects);
        }
        /*
        PAC_MAN_01,     //Iconic stage
        PAC_MAN_02,     //Mouth big open
        PAC_MAN_03,     //Closed
        PAC_MAN_04      //Hmmmmm
         */
    }
}
