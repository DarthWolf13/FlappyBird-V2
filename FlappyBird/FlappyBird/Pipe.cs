using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class Pipe : SpriteGameObject
    {
        Vector2 StartPosition;

        public Pipe() : base("spr_pipe")
        {           
            this.velocity = new Vector2(-300, 0);
            this.origin = this.Center;
            StartPosition = new Vector2(700, FlappyBird.Random.Next(201, 400));
            this.Position = StartPosition;
        }
    }
}
