using System;
using System.Collections.Generic; 
namespace Slutprojekt
{
    public class Law
    {
       private string[] allowOrForbid ={"Allow","Forbid"};
       private string[] environmentNoun ={"potatoes","guns","mice","","",""};
        private string[] healthcareNoun ={"potatoes","guns","mice","","",""};

        //göra en konstruktor som randomiserar dessa för varje lag så de sen kan printas med madlib

       //Citizen.AgeGroups //young, middle, old. To be used in laws

    public void MadLib(){
        Console.WriteLine(allowOrForbid + " " + environmentNoun + " to be eaten" );
    }
    }
       
}

