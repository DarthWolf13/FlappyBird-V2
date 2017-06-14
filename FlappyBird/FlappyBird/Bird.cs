using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class Bird : RotatingSpriteGameObject
    {
        public Bird() : base("spr_bird")
        {
            this.origin = this.Center;
        }
    }
}
