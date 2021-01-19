using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    class Frog : GameObject
    {
        public Frog() : base("spr_frog")
        {

        }

        public override void Init()
        {
            base.Init();
            position.X = GameEnvironment.Screen.X/2 - this.texture.Width / 2;
            position.Y = GameEnvironment.Screen.Y - this.texture.Height;
        }
    }
}
