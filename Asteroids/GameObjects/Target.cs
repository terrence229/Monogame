using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameObjects
{
    class Target : SpriteGameObject
    {
        public Target() : base("spr_mushroom")
        {
            Reset();
        }
        public override void Reset()
        {
            base.Reset();
            position = new Vector2(GameEnvironment.Random.Next(GameEnvironment.Screen.X), GameEnvironment.Random.Next(GameEnvironment.Screen.Y));
        }
    }
}
