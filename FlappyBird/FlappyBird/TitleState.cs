using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlappyBird
{
    class TitleState : SpriteGameObject
    {
        public TitleState() : base("spr_titlescreen")
        {

        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
            {
                FlappyBird.GameStateManager.SwitchTo("PlayingState");
            }
        }
    }
}
