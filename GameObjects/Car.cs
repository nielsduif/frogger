using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frogger
{
    class Car : GameObject
    {
        public Car(string _assetName, Vector2 _position, Vector2 _velocity) : base(_assetName)
        {
            position = _position;
            velocity = _velocity;
        }

        public override void Update()
        {
            base.Update();
            position.X += velocity.X;
            if (position.X + texture.Width < 0)
            {
                position.X = GameEnvironment.Screen.X;
            }
            else if (position.X > GameEnvironment.Screen.X)
            {
                position.X = -texture.Width;
            }
        }
    }
}
