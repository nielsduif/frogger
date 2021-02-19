using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frogger
{
    class Frog : GameObject
    {
        int moveAmount = 40;

        public Frog() : base("spr_frog")
        {

        }

        public override void Init()
        {
            base.Init();
            position.X = GameEnvironment.Screen.X / 2 - this.texture.Width / 2;
            position.Y = GameEnvironment.Screen.Y - this.texture.Height;
        }

        public override void Update()
        {
            if (GameEnvironment.KeyboardState.IsKeyDown(Keys.Left))
            {
                position.X -= moveAmount;
                if (position.X < 0)
                {
                    position.X = 0;
                }
            }

            if (GameEnvironment.KeyboardState.IsKeyDown(Keys.Right))
            {
                position.X += moveAmount;
                if (position.X + texture.Width > GameEnvironment.Screen.X)
                {
                    position.X = GameEnvironment.Screen.X - texture.Width;
                }
            }
            if (GameEnvironment.KeyboardState.IsKeyDown(Keys.Up))
            {
                position.Y -= moveAmount;
                if (position.Y < 0)
                {
                    position.Y = 0;
                }
            }
            if (GameEnvironment.KeyboardState.IsKeyDown(Keys.Down))
            {
                position.Y += moveAmount;
                if (position.Y + texture.Height > GameEnvironment.Screen.Y)
                {
                    position.Y = GameEnvironment.Screen.Y - texture.Height;
                }
            }
            base.Update();
        }
    }
}
