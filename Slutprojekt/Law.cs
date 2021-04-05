using System;
using System.Collections.Generic; 
namespace Slutprojekt
{
    public class Law
    {

        private bool passed;
        public bool Passed{
            get{return passed;}
        }
       private string[] allowOrForbidList ={"Allow","Forbid"};
       private string allowOrForbid;
       private string[] environmentNounList ={"potatoes","guns","mice"};
       private string environmentNoun;
        private string[] healthcareNounList ={"medicine","surgery","vaccines"};
        private string healthcareNoun;

        //göra en konstruktor som randomiserar dessa för varje lag så de sen kan printas med madlib

       //Citizen.AgeGroups //young, middle, old. To be used in laws
    
    public Law(){
        Random generator = new Random();

         allowOrForbid = allowOrForbidList[generator.Next(2)]; 
         environmentNoun = environmentNounList[generator.Next(3)];
         healthcareNoun = healthcareNounList[generator.Next(3)];
    }
    public int MadLib(){
        int i = 0;
        Console.WriteLine(allowOrForbid + " " + environmentNoun + " to be eaten" );
        return i;
    }
    public bool PassOrNot(){
        int loop=0;
        while(loop==0){
        string verdict = Console.ReadLine();
        if(verdict=="pass"){
            loop++;
            return true;
        }
        else if (verdict=="deny"){
            loop++;
            return false;
        }
        else{
            Console.WriteLine("Only respond with pass or deny");
            return false;
        }
        }
        return false;
    }
    }
       
}

