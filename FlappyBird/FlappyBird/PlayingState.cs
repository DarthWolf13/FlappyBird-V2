using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace FlappyBird
{
    class PlayingState : GameObjectList
    {
        Bird bird;
        GameObjectList pipes;
        int frameCounter = 0;
        Score score;

        public PlayingState()
        {
            bird = new Bird();
            pipes = new GameObjectList();
            score = new Score();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(bird);
            this.Add(pipes);
            this.Add(score);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            frameCounter++;

            if(frameCounter > 100)
            {
                this.pipes.Add(new Pipe());
                frameCounter = 0;
            }

            Boolean isGameOver = false;

            foreach(Pipe pipe in pipes.Objects)
            {
                if (bird.Position.Y > FlappyBird.Screen.Y || bird.Position.Y < 0 || bird.CollidesWith(pipe))
                {
                    isGameOver = true;
                }
            }
            
            if(isGameOver == true)
            {
                SetGameOver();
            }          
        }

        public void SetGameOver()
        {
            bird.Reset();
            pipes.Objects.Clear();
            frameCounter = 0;
        }
    }
}
