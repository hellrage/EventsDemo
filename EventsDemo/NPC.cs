using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsDemo
{
    class NPC : CollidableObject//, ICollidable
    {
        //properties
        private static string type = "NPC";

        public NPC(int Id)
            : base(NPC.type, Id)
        {
        }

        public override void Collide(CollidableObject pairedObject) 
        {
            base.Collide(pairedObject);
        }
    }
}
