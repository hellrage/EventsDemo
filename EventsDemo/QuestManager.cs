using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsDemo
{
    static class QuestManager
    {
        private static List<Quest> quests = new List<Quest>();

        public static void GenerateRandomQuests(int numberOfQuests)
        {
            for (int i = 0; i < numberOfQuests; i++)
            {
                quests.Add(new Quest("Quest_" + i.ToString(), "NPC_" + i.ToString()));
                Logger.WriteLog(String.Format("{0} reacts to {1}'s collisions\n",quests[i].QuestName,quests[i].LinkedObjectUnlocalisedName),true);
            }
            Logger.WriteLog("\n", true);
        }

        public static void InitializeQuests()
        {
            foreach (Quest quest in quests)
            {
                quest.Initialize();
            }
        }
    }
}
