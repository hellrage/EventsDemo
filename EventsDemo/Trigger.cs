using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsDemo
{
    class Trigger : CollidableObject//, ICollidable
    {
        //properties
        private static string type = "TRIGGER";

        public Trigger(int Id)
            : base(Trigger.type, Id)
        {
        }

        public override void Collide(CollidableObject pairedObject)
        {
            base.Collide(pairedObject);
        }
    }
}
