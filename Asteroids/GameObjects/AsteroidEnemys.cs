using Asteroids.GameManagement;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameObjects
{
    class AsteroidEnemys : RotatingSpriteGameObject
    {

        public int rocknumber = 0;
        public AsteroidEnemys(String rocktype, int rocknumber) : base(rocktype)
        {
            this.rocknumber = rocknumber;
            this.origin = Center;
            Reset();
        }

        public override void Reset()
        {
            base.Reset();
            position.X = GameEnvironment.Random.Next(-49,-20);
            position.Y = GameEnvironment.Random.Next(1, 600);
            this.velocity = new Vector2(GameEnvironment.Random.Next(200, 300), GameEnvironment.Random.Next(-100,100));
        }

        public override void Update(GameTime gameTime)
        {
            /*
            if (rocknumber < 0)
                visible = false;
            if (rocknumber == 0)
                sprite = new SpriteSheet("spr_rock1");
            if (rocknumber == 1)
                sprite = new SpriteSheet("spr_rock2");
            if (rocknumber == 2)
                sprite = new SpriteSheet("spr_rock3");
        */
            base.Update(gameTime);
            WrapScreen();
        }

        public void WrapScreen()
        {
            if (position.X > GameEnvironment.Screen.X + 50)
                Reset();
            if (position.Y < -50)
                Reset();
            if (position.Y > GameEnvironment.Screen.Y + 50)
                Reset();
        }

    }
}
