using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class LegendaryCitizen : OldCitizen
    {
        private string power;
        private string title;
        private string adjective;
        private List<string> adjectiveList = new List<string>(){"Super","Glorious","Speedy","Farty","Master","Calm","Shook"};
        private string name;
        public LegendaryCitizen(Queue<string> nameQueue){
            Random generator = new Random();
            adjective = adjectiveList[generator.Next(adjectiveList.Count)];
            name= nameQueue.Dequeue();//returnar namnet längst fram i listan och tar sedan bort den. Varje legendary citizen kommer ha ett unikt namn
            title= adjective + " " + name;
            HealthLevel= HealthLevel*4;
        }
    }
}
