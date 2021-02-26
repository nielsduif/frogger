using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frogger
{
    class Lives : GameObject
    {
        public Lives(Vector2 _pos) : base("spr_frog")
        {
            position = _pos;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
