using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameStates
{
    class WinState : GameObjectList
    {
        public WinState()
        {
            Add(new SpriteGameObject("spr_mushroom"));
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.AnyKeyPressed == true)
            {
                GameEnvironment.GameStateManager.SwitchTo("TitleScreenState");
            }

        }
    }
}
