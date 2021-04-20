using System;
using System.Collections.Generic; 
namespace Slutprojekt
{
    public class Law
    {
       private List<string> allowOrForbidList = new List<string>(){"Allow","Forbid"};
       private string allowOrForbid;
       private List<string> nounList = new List<string>(){"potatoes","guns","mice","dogs","trolls","spoons","shoes"};
       private string noun;
        private List<string> verbList = new List<string>(){"slaughtered","used in warfare","sexualized","included","burned","eaten","allowed to marry"};
        private string verb;
        public int i = 0;

        //göra en konstruktor som randomiserar dessa för varje lag så de sen kan printas med madlib

       //Citizen.AgeGroups //young, middle, old. To be used in laws
        public Law(){
        Random generator = new Random();
       
         allowOrForbid = allowOrForbidList[generator.Next(2)]; 
         noun = nounList[generator.Next(nounList.Count)];
         verb = verbList[generator.Next(verbList.Count)];
         nounList.Remove(noun);
         verbList.Remove(verb);
        
       
    }
    public int MadLib(){
        Console.WriteLine(allowOrForbid + " " + noun + " to be " + verb );
        int randomNumber = 0;
        return randomNumber;
        //om jag hade mer tid skulle jag se till att fixa att man inte skulle kunna ha dubletter
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

