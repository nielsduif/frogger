using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frogger
{
    class WinState : GameState
    {
        public WinState()
        {
            gameObjectList.Add(new GameObject("spr_win_screen"));
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
