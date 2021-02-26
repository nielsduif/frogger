using System;
using System.Collections.Generic;
using System.Text;

namespace Frogger
{
    class Fly : GameObject
    {
        public Fly() : base("spr_fly")
        {
            position.X = 242;
            position.Y = 30;
        }
    }
}
