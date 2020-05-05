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

            // if player goes out of bound he loses
            if (position.X < 0 || position.X > GameEnvironment.Screen.X || position.Y < 0 || position.Y > GameEnvironment.Screen.Y)
                GameEnvironment.GameStateManager.SwitchTo("GameOverState");
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            float slowdownspeed = 0.9f;

            // player movement controlls
            AngularDirection = inputHelper.MousePosition - new Vector2(400, 300);
            if (inputHelper.IsKeyDown(Keys.W))
                velocity += AngularDirection * 5;
            else if (inputHelper.IsKeyDown(Keys.S))
                velocity -= AngularDirection * 5;
            else if (inputHelper.IsKeyDown(Keys.A))
                Degrees -= 4;
            else if (inputHelper.IsKeyDown(Keys.D)) 
                Degrees += 4;
            else
                velocity *= slowdownspeed;
        }
    }
}
