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
        private List<string> nameList = new List<string>(){"Steve","Martin","John","Michael","Kevin","Earl","Carl"};
        public LegendaryCitizen(){
            Random generator = new Random();
            adjective = adjectiveList[generator.Next(adjectiveList.Count)];
            name = nameList[generator.Next(nameList.Count)];
            title= adjective + " " + name;
            HealthLevel= HealthLevel*4;
        }
    }
}
