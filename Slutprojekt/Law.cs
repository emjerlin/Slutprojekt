using System;
using System.Collections.Generic; 
namespace Slutprojekt
{
    public class Law
    {
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
    }
       
}
