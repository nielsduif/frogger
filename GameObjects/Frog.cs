using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
        Boolean moved;

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
            if (GameEnvironment.KeyboardState.IsKeyDown(Keys.Left) && !moved)
            {
                moved = true;
                position.X -= moveAmount;
                if (position.X < 0)
                {
                    position.X = 0;
                }
            }

            else if (GameEnvironment.KeyboardState.IsKeyDown(Keys.Right) && !moved)
            {
                moved = true;
                position.X += moveAmount;
                if (position.X + texture.Width > GameEnvironment.Screen.X)
                {
                    position.X = GameEnvironment.Screen.X - texture.Width;
                }
            }
            else if (GameEnvironment.KeyboardState.IsKeyDown(Keys.Up) && !moved)
            {
                moved = true;
                position.Y -= moveAmount;
                if (position.Y < 0)
                {
                    position.Y = 0;
                }
            }
            else if (GameEnvironment.KeyboardState.IsKeyDown(Keys.Down) && !moved)
            {
                moved = true;
                position.Y += moveAmount;
                if (position.Y + texture.Height > GameEnvironment.Screen.Y)
                {
                    position.Y = GameEnvironment.Screen.Y - texture.Height;
                }
            }
            if (GameEnvironment.KeyboardState.IsKeyUp(Keys.Down) && GameEnvironment.KeyboardState.IsKeyUp(Keys.Up) && GameEnvironment.KeyboardState.IsKeyUp(Keys.Left) && GameEnvironment.KeyboardState.IsKeyUp(Keys.Right))
            {
                moved = false;
            }
            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
