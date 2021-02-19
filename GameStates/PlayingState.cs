using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Frogger
{
    class PlayingState : GameState
    {
        int carAmount = 9;
        Frog frog;
        public PlayingState()
        {
            gameObjectList.Add(new GameObject("spr_background"));
            frog = new Frog();
            gameObjectList.Add(frog);
            for (int i = 0; i < carAmount / 3; i++)
            {
                gameObjectList.Add(new Car("spr_truck", new Vector2(i * 150 + 70, 225), new Vector2(-2, 0)));
                gameObjectList.Add(new Car("spr_dozer", new Vector2(i * 150 + 70, 185), new Vector2(2, 0)));
                gameObjectList.Add(new Car("spr_racecar", new Vector2(i * 150 + 70, 145), new Vector2(-2, 0)));
            }            
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            foreach (GameObject GO in gameObjectList)
            {
                if (GO is Car && GO.Overlaps(frog))
                {
                    frog.Init();
                }
            }
        }
    }
}
