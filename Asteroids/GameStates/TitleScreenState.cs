﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameStates
{
    class TitleScreenState : GameObjectList
    {
        public TitleScreenState()
        {
            Add(new SpriteGameObject("spr_titlescreen"));
            
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            //moves the player to the game
            if (inputHelper.AnyKeyPressed == true)
            {
                GameEnvironment.GameStateManager.SwitchTo("PlayingState");
            }

        }

    }
}
