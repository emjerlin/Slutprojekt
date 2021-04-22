using System;

namespace Slutprojekt
{
    public class Citizen
    {
        private string ageGroup;
        public string AgeGroup{
            get{return ageGroup;}
        }
        private string[] ageGroups ={"Young","MiddleAge","Old"};
        public string[] AgeGroups{
            get{return ageGroups;}
        }
        private int healthLevel;
        public int HealthLevel{
            get{return healthLevel;}
        }
        private int happiness;
        public int Happiness{
            get{return happiness;}
        }

        /*These bools describe if the citizen feels about these topics. True means they want more than medium, and false means they want less
        I chose to remove them because it would make my game too hard to make/take too much time

        private bool healthcare;
        public bool HealthCare{
            get{return healthcare;}
        }
        private bool housing;
        public bool Housing{
            get{return housing;}
        }
        private bool environment;
        public bool Environment{
            get{return environment;}
        }        
        private bool control;
        public bool Control{
            get{return control;}
        }*/

        public Citizen(){
            //konstruktor som assignar vad citizens har för attribut, eller vill ha
            //assignar age group
            Random generator = new Random();
            int ageRandom = generator.Next(3);
            ageGroup = ageGroups[ageRandom];

            //randomiserar health level + lägger till age modifier
           
            float healthLevelBase = generator.Next(3); //0=bad health 1=normal 2=rly good health. Kommer påverka hur mycket sjukvård de behöver (skattepengar som går åt)
            float aMod;
            if (ageGroup=="Young"){aMod = 0.7f; }else if(ageGroup=="MiddleAge"){aMod=1f;}else{aMod=1.3f;}
            float healthLevelFloat = healthLevelBase * aMod;
            healthLevel = (int)Math.Round(healthLevelFloat);

            happiness=100;

            /*mer eller mindre av saken. True = mer. False = mindre
            
            int healthBool = generator.Next(2); //skapar en int som är 0 eller 1
            if (healthBool ==0){healthcare = false;}else{healthcare=true;}

             int housingBool = generator.Next(2); //skapar en int som är 0 eller 1
            if (healthBool ==0){healthcare = false;}else{healthcare=true;}

             int environBool = generator.Next(2); //skapar en int som är 0 eller 1
            if (healthBool ==0){healthcare = false;}else{healthcare=true;}

             int controlBool = generator.Next(2); //skapar en int som är 0 eller 1
            if (healthBool ==0){healthcare = false;}else{healthcare=true;}
            */
            
        }
        public void MakeHappy(){
            happiness=+10;
        }
        public void MakeUnhappy(){
             happiness=-10;
        }
    }
}
