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
        GameObjectList asteroid = new GameObjectList();
        String[] asteroidscale = new string[3];

        int randomasteroid;

        public PlayingState()
        {
            Add(new SpriteGameObject("spr_background"));
            thePlayer = new Player();
            target = new Target();
            score = new Score();

            Add(thePlayer);
            Add(target);
            Add(score);
            asteroidscale[0] = "spr_rock1";
            asteroidscale[1] = "spr_rock2";
            asteroidscale[2] = "spr_rock3";

            //loading in 3 random asteroids
            for (int r = 0; r < 3; r++)
            {
                randomasteroid = GameEnvironment.Random.Next(3);
                asteroid.Add(new AsteroidEnemys(asteroidscale[randomasteroid], randomasteroid));
            }

            Add(asteroid);
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
            foreach (AsteroidEnemys asteroid in asteroid.Children)
            {
                if (thePlayer.CollidesWith(asteroid))
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


