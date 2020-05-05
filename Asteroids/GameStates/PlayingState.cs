using Asteroids.GameObjects;
using Microsoft.Xna.Framework;
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
        Target target;
        GameObjectList bullets;

        private const int SHOOT_COOLDOWN = 20;
        private int shootTimer = 30;
        int bulletStartSpeed = 500;

        public PlayingState()
        {

            Add(new SpriteGameObject("spr_background"));
            Add(bullets = new GameObjectList());
            target = new Target();
            thePlayer = new Player();
            Add(thePlayer);
            score = new Score();
            Add(score);

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            foreach (Bullet bullets in bullets.Children)
            {
                if (bullets.CollidesWith(target))
                {
                    shootTimer = 30;
                    Add(score);
                    //target.position = new Vector2(GameEnvironment.Random.Next(GameEnvironment.Screen.X), GameEnvironment.Random.Next(-1000, -20));
                }
            }
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.MouseLeftButtonPressed() && shootTimer > SHOOT_COOLDOWN)
            {
                //crosshair.Expand(SHOOT_COOLDOWN);
                bullets.Add(new Bullet(new Vector2(thePlayer.Position.X, thePlayer.Position.Y), thePlayer.AngularDirection * bulletStartSpeed));
                shootTimer = 15;
            }else if (inputHelper.MouseLeftButtonPressed() && shootTimer < SHOOT_COOLDOWN)
            {
                bullets.Velocity = thePlayer.AngularDirection * -bulletStartSpeed ;
            }

            
        }

    }
}


//new Vector2(bulletStartSpeed * thePlayer.AngularDirection)  