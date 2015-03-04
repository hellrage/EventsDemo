using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsDemo
{
    public class CollisionEventArgs : EventArgs
    {
        public CollidableObject pairedObject;
    }
}
