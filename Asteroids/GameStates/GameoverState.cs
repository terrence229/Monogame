using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameStates
{
    class GameOverState : GameObjectList
    {
        public GameOverState()
        {
            Add(new SpriteGameObject("spr_gameover"));
        }

    }
}
