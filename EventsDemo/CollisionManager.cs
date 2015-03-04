using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsDemo
{
    public static class CollisionManager
    {
        private const int NUMBER_OF_NPCS = 3;
        private const int NUMBER_OF_PROJECTILES = 5;
        private const int NUMBER_OF_TRIGGERS = 5;

        private static List<NPC> npcs = new List<NPC>();
        private static List<Trigger> triggers = new List<Trigger>();
        private static List<Projectile> projectiles = new List<Projectile>();

        private static List<CollidableObject> objectsInCell = new List<CollidableObject>();

        private static Random rnd = new Random();
        private static string report;

        public static string Report
        {
            get { return report; }
            private set { report = value; }
        }
        

        public static void InitializeObjects()
        {
            Logger.WriteLog("Initializing lists of objects...\n",true);

            for (int i = 0; i < NUMBER_OF_NPCS; i++)
            {
                npcs.Add(new NPC(i));
                objectsInCell.Add(npcs[i]);
                Logger.WriteLog("Added npc:\t\t\t" + npcs[i].UnlocalisedName + "\n", false);
            }

            for (int i = 0; i < NUMBER_OF_TRIGGERS; i++)
            {

                triggers.Add(new Trigger(i));
                objectsInCell.Add(triggers[i]);
                Logger.WriteLog("Added trigger:\t\t\t" + triggers[i].UnlocalisedName + "\n", false);
            }

            for (int i = 0; i < NUMBER_OF_PROJECTILES; i++)
            {
                projectiles.Add(new Projectile(i));
                objectsInCell.Add(projectiles[i]);
                Logger.WriteLog("Added projectile:\t\t\t" + projectiles[i].UnlocalisedName + "\n", false);
            }
            Logger.WriteLog("Initialized lists of objects\n\n",true);
        }

        public static void SimulateCollisions(int numberOfCollisions)
        {
            Logger.WriteLog(String.Format("Simulating {0} collisions...\n\n", numberOfCollisions),true);
            for (int i = 0; i < numberOfCollisions; i++)
            {
                CollidableObject obj1;
                CollidableObject obj2;
                do
                {
                    obj1 = objectsInCell[rnd.Next(objectsInCell.Count - 1)];
                    obj2 = objectsInCell[rnd.Next(objectsInCell.Count - 1)];
                } while (obj1 == obj2);

                CollideObjects(obj1, obj2);
            }
        }

        private static void CollideObjects(CollidableObject obj1, CollidableObject obj2)
        {
            obj1.Collide(obj2);
            obj2.Collide(obj1);
            Logger.WriteLog(String.Format("Collided objects \t {0} and {1}\n", obj1.UnlocalisedName, obj2.UnlocalisedName),false);
        }

        public static CollidableObject getLinkToNamedObject(string ObjectUnlocalisedName)
        {
            foreach (CollidableObject obj in objectsInCell)
            {
                if (obj.UnlocalisedName == ObjectUnlocalisedName)
                {
                    return obj;
                }
            }
            throw new NullReferenceException();
        }
    }
}
