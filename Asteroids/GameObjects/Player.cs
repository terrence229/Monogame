using Asteroids.GameManagement;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameObjects
{
    class Player : RotatingSpriteGameObject
    {
        public Player() : base("spr_spaceship")
        {
            origin = Center;
            position.X = GameEnvironment.Screen.X / 2;
            position.Y = GameEnvironment.Screen.Y / 2;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            float Movementspeed = 200;
            if (inputHelper.IsKeyDown(Keys.D))
            {
                velocity.X = Movementspeed;
            }
            if (inputHelper.IsKeyDown(Keys.A))
            {
                velocity.X = -1 * Movementspeed;
            }
            if (inputHelper.IsKeyDown(Keys.W))
            {
                velocity.Y = -1 * Movementspeed;
            }
            if (inputHelper.IsKeyDown(Keys.S))
            {
                velocity.Y = Movementspeed;
            }
            else
            {
                velocity.Y = velocity.Y * 0.9f;
                velocity.X = velocity.X * 0.9f;
            }
            AngularDirection = inputHelper.MousePosition - new Vector2(400, 300);

        }
    }
}
