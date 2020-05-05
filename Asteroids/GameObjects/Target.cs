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
        public Target() : base("spr_mushroom.png")
        {
            position = new Vector2(GameEnvironment.Random.Next(GameEnvironment.Screen.X), GameEnvironment.Random.Next(-1000, -20));
        }
    }
}
