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
        Bullet bullet;
        AsteroidEnemys asteroid;
        //GameObjectList asteroid = new GameObjectList();

        public PlayingState()
        {
            Add(new SpriteGameObject("spr_background"));
            asteroid = new AsteroidEnemys();
            thePlayer = new Player();
            target = new Target();
            score = new Score();

            Add(asteroid);
            Add(thePlayer);
            Add(target);
            Add(score);
        }       

        public override void Update(GameTime gameTime)
        {



            base.Update(gameTime);
            //bullet collision with target
            if (bullet != null && bullet.CollidesWith(target))
            {
                target.Reset();
                score.AddScore();
                RemoveBullet();
            }
            //player collision asteroids
            if (thePlayer.CollidesWith(asteroid))
            {
                GameEnvironment.GameStateManager.SwitchTo("GameOverState");
            }
            if (score.GameScore == 100)
            {
                GameEnvironment.GameStateManager.SwitchTo("WinState");
            }
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            // checks if a bullet can be shot or removed and adds/removes the bullet
            if (inputHelper.MouseLeftButtonPressed())
            {
                if (bullet == null)
                {
                    // adds bullet
                    bullet = new Bullet(thePlayer);
                    Add(bullet);
                }
                else
                    RemoveBullet();
            }
        }
        // gives a more overseeable removebullet statement
        private void RemoveBullet()
        {
            Remove(bullet);
            bullet = null;
        }

    }
}


