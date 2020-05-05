using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids.GameObjects
{
    class Bullet : SpriteGameObject
    {
        public Player thePlayer;
        new Vector2 accelaration;
        public Bullet(Vector2 position, Vector2 velocity) : base("spr_Bullet")
        {
            thePlayer = new Player();
            

            this.position = position;
            Origin = Center;
            this.velocity = velocity;
            //accelaration = new Vector2(0, 15);

            
        }
        
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            velocity += accelaration;
            velocity *= new Vector2(0.99f, 1);

        }
       
    }
}
