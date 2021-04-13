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
        private string[] verbList ={"slaughtered","used in warfare","sexualized","included"};
        private string verb;
        private string[] healthcareVerbList={"covered by insurance",""};
        private string healthcareVerb;
        public int i = 0;

        //göra en konstruktor som randomiserar dessa för varje lag så de sen kan printas med madlib

       //Citizen.AgeGroups //young, middle, old. To be used in laws
    
    public Law(){
        Random generator = new Random();
        i = generator.Next(3);
       
         allowOrForbid = allowOrForbidList[generator.Next(2)]; 
         environmentNoun = environmentNounList[generator.Next(3)];
         healthcareNoun = healthcareNounList[generator.Next(3)];
         verb = verbList[generator.Next(4)];
        
       
    }
    public int MadLib(){
        if (i==0){ //environment
        Console.WriteLine(allowOrForbid + " " + environmentNoun + " to be " + verb );
         }
        else if (i==1){ //healthcare
        Console.WriteLine(allowOrForbid + " " + healthcareNoun + " to be " + heathcareVerb );
        }
        else if (i==2){ //control
        Console.WriteLine(allowOrForbid + " " + environmentNoun + " to be " + verb );
        }
        int randomNumber = 0;
        
        return randomNumber;
    }
    public bool PassOrNot(){
        int loop=0;
        while(loop==0){
        string a = Console.ReadLine();
        if(a=="pass"){
            loop++;
            return true;
        }
        else if (a=="deny"){
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

