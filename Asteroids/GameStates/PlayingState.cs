using Asteroids.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameStates
{
    class PlayingState : GameObjectList
    {
        public Player thePlayer;
        Score score;

        public PlayingState()
        {

            Add(new SpriteGameObject("spr_background"));

            thePlayer = new Player();
            Add(thePlayer);
            score = new Score();
            Add(score);

        }



    }
}
