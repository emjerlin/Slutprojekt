using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class Resources
    {
        private List<Citizen> citizens = new List<Citizen>();//kunna accessa denna från program
        public List<Citizen> Citizens{
            get{return citizens;}
        }
        public List<Law> laws = new List<Law>();
        private int money;
        public int Money{
            get{return money;}
            set{money=value;}
        }
        private int food;
        public int Food{
            get {return food;}
            set{food=value;}
        }
        private int weapons;
        public int Weapons{
            get{return weapons;}
            set{weapons=value;}
        }
        private int buildingMaterial;
        public int BuildingMaterial{
            get{return buildingMaterial;}
            set{buildingMaterial=value;}
        }
        public Resources(){
            money = 1000;
            food = 30;
            weapons = 0;
            buildingMaterial = 0;
            for (int i = 0; i < 5; i++)
            {
                citizens.Add(new Citizen());
            }
        }
        public void Build(){
            buildingMaterial-=20;
            money-=200;
            for (int i = 0; i < 10; i++)
            {
                citizens.Add(new Citizen());
            }
            
        }
        public void NewLaw(){
            laws.Add(new Law());
            Console.WriteLine("Law number " + laws.Count);
        }
    }
    
}
