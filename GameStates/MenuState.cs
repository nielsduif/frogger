using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frogger
{
    class MenuState : GameState
    {
        public MenuState()
        {
            gameObjectList.Add(new GameObject("spr_start_screen"));
        }

        public override void Update(GameTime gameTime)
        {
            if (GameEnvironment.KeyboardState.GetPressedKeyCount() > 0)
            {
                GameEnvironment.SwitchTo(1);
            }
            base.Update(gameTime);
        }
    }
}
