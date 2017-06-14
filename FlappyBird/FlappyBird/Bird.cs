using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class Bird : RotatingSpriteGameObject
    {
        Vector2 StartPosition;

        public Bird() : base("spr_bird")
        {
            this.origin = this.Center;
            StartPosition = new Vector2(FlappyBird.Screen.X / 2, FlappyBird.Screen.Y / 2);

            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();

            this.Position = StartPosition;
        }
    }
}
