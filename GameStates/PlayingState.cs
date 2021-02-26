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
        Fly fly;
        List<Car> cars = new List<Car>();
        List<Lives> lives = new List<Lives>();
        public PlayingState()
        {
            gameObjectList.Add(new GameObject("spr_background"));
            frog = new Frog();
            fly = new Fly();
            gameObjectList.Add(frog);
            gameObjectList.Add(fly);
            for (int i = 0; i < frog.lives; i++)
            {
                Lives l = new Lives(new Vector2(i * 30 + 10, 10));
                lives.Add(l);
                gameObjectList.Add(l);
            }
            for (int i = 0; i < carAmount / 3; i++)
            {
                Car truck = new Car("spr_truck", new Vector2(i * 150 + 70, 225), new Vector2(-2, 0));
                Car dozer = new Car("spr_dozer", new Vector2(i * 150 + 70, 185), new Vector2(2, 0));
                Car racecar = new Car("spr_racecar", new Vector2(i * 150 + 70, 145), new Vector2(-2, 0));
                cars.Add(truck);
                cars.Add(dozer);
                cars.Add(racecar);
                gameObjectList.Add(truck);
                gameObjectList.Add(dozer);
                gameObjectList.Add(racecar);
            }
        }
        public override void Update(GameTime gameTime)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Overlaps(frog))
                {
                    frog.Init();
                    frog.lives--;
                }
            }
            if (fly.Overlaps(frog))
            {
                GameEnvironment.SwitchTo(2);
                frog.Init();
            }
            base.Update(gameTime);
        }
    }
}
