using System;

namespace Slutprojekt
{
    public class Citizen
    {
        public int happiness;
        public int Happiness{
            get{return happiness;}
            set{happiness=value;}
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

            happiness=0;
            

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
        public virtual void MakeHappy(){
            happiness=happiness+10;
        }
        public virtual void MakeUnhappy(){
             happiness=happiness-10;
        }
    }
}
