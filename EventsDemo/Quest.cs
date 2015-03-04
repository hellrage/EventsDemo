using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsDemo
{
    public class Quest
    {
        private string questName;
        public string QuestName
        {
            get { return questName; }
            private set { questName = value; }
        }

        private string linkedObjectUnlocalisedName;

        public string LinkedObjectUnlocalisedName
        {
            get { return linkedObjectUnlocalisedName; }
            private set { linkedObjectUnlocalisedName = value; }
        }
        
        private CollidableObject linkedObject;

        public Quest(string questName, string linkedObjectUnlocalisedName)
        {
            this.questName = questName;
            this.linkedObjectUnlocalisedName = linkedObjectUnlocalisedName;
        }

        public void Initialize()
        {
            this.linkedObject = CollisionManager.getLinkToNamedObject(linkedObjectUnlocalisedName);
            this.linkedObject.Collision += DoActions;
            Logger.WriteLog(String.Format("Quest {0} initialized and subscribed to {1}\n", questName, linkedObjectUnlocalisedName),false);
        }

        internal virtual void DoActions(object sender, CollisionEventArgs e)
        {
            Logger.WriteLog(String.Format("Quest {0} has reacted to collision event of {1} and {2}\n", questName, linkedObjectUnlocalisedName, e.pairedObject.UnlocalisedName),true);
        }
    }
}
