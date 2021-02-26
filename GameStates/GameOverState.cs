using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics;

namespace Frogger
{
    class GameOverState : GameState
    {
        public GameOverState()
        {
            gameObjectList.Add(new GameObject("spr_gameover_screen"));
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
