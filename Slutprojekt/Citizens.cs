using System;

namespace Slutprojekt
{
    public class Citizens
    {
        private string ageGroup;
        private string[] ageGroups ={"Young","MiddleAge","Old"};
        private int healthLevel;

        //These bools describe if the citizen feels about these topics. True means they want more than medium, and false means they want less
        private bool healthcare;
        private bool housing;
        private bool environment;
        private bool control;

        public Citizens(){
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

            //mer eller mindre av saken. True = mer. False = mindre
            
            int healthBool = generator.Next(2); //skapar en int som är 0 eller 1
            if (healthBool ==0){healthcare = false;}else{healthcare=true;}

             int housingBool = generator.Next(2); //skapar en int som är 0 eller 1
            if (healthBool ==0){healthcare = false;}else{healthcare=true;}

             int environBool = generator.Next(2); //skapar en int som är 0 eller 1
            if (healthBool ==0){healthcare = false;}else{healthcare=true;}

             int controlBool = generator.Next(2); //skapar en int som är 0 eller 1
            if (healthBool ==0){healthcare = false;}else{healthcare=true;}
            

        }
    }
}
