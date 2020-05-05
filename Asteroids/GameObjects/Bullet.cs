using Asteroids.GameManagement;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameObjects
{
    class Bullet : RotatingSpriteGameObject
    {
        public Player thePlayer;
        int bulletStartSpeed = 500;
        public Bullet(Player player) : base("spr_Bullet")
        {
            thePlayer = player;
            Origin = Center;
            // takes over player poision and gives velocity
            position = thePlayer.Position;
            velocity = thePlayer.AngularDirection * bulletStartSpeed;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            // if bullet is out of bounds the player loses
            if (Position.X < 0 || Position.X > GameEnvironment.Screen.X || Position.Y < 0 || Position.Y > GameEnvironment.Screen.Y)
            {
                GameEnvironment.GameStateManager.SwitchTo("GameOverState");
            }
        }
    }
}
