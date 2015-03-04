using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsDemo
{
    class Projectile : CollidableObject//, ICollidable
    {
        //properties
        private static string type = "PROJECTILE";

        public Projectile(int Id)
            : base(Projectile.type,Id)
        {
        }

        public override void Collide(CollidableObject pairedObject)
        {
            /*
             * this.Die();
             *  
             */
            base.Collide(pairedObject);
        }
    }
}
