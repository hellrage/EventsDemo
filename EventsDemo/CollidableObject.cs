using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsDemo
{
    public class CollidableObject// : ICollidable
    {
        //properties

        private string unlocalisedName;

        public string UnlocalisedName
        {
            get { return unlocalisedName; }
            private set { unlocalisedName = value; }
        }

        public CollidableObject(string type, int Id)
        {
            this.unlocalisedName = type + "_" + Id.ToString();
        }

        public virtual void Collide(CollidableObject pairedObject)
        {
            CollisionEventArgs ceArgs = new CollisionEventArgs();
            ceArgs.pairedObject = pairedObject;
            OnCollision(ceArgs);

        }

        protected virtual void OnCollision(CollisionEventArgs e)
        {
            EventHandler<CollisionEventArgs> collisionHandler = Collision;
            if(collisionHandler != null)
            {
                collisionHandler(this, e);
            }
        }
        public event EventHandler<CollisionEventArgs> Collision;
    }
    
}
