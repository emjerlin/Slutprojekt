using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Förbättra: Arv i flera led, 2 steg. Fler generiska klasser. 
            Resources newGame = new Resources();//creates a resource class, which creates a new game
            //Console.WriteLine(newGame.Citizens[1].AgeGroup);    

            //flytta konversationer till klasser, metoder i klasser
            Console.WriteLine("Welcome oh great leader! We are looking to grow our kingdom, and we hope you can guide us to fame and glory");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("The kingdom currently has " + newGame.Citizens.Count + " citizens. That won't do...");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();//add a 3 option response system with arrow keys
            Console.Clear();

            Console.WriteLine("Let's get you familiar with how to rule a kingdom! There are a lot of decisions a ruler must make. Building houses, managing food in the country, and passing laws");
            Console.WriteLine("");
            Console.WriteLine("In order to keep a country (happy), you must keep an eye on the wishes of the citizens.");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Oh, there's also a couple (resources) you should pay attention to. (Money) helps you hire workers, and trade to get resources. (Food)... Keeps your citizens fed, which can be good. (Weapons) help you incase of the *unlikely* occurence of revolting citizens, but that should be easily avoided if you keep an eye on the overall (happiness)");
            
            Console.WriteLine("Let's try it out! (This law won't affect the rest of your game, and is only meant to make you familiar with the mechanics)");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.Clear();

                newGame.NewLaw();
                string tutorial ="";
                newGame.laws[0].MadLib();//writes out the law
                Console.WriteLine("Do you want to [pass] or [deny] the law?");
                bool verdict = newGame.laws[0].PassOrNot();
                if(verdict==true){
                    newGame.laws.RemoveAt(0);
                    tutorial = "passed";
                    Console.WriteLine("You passed the law");
                }
                if(verdict==false){
                    newGame.laws.RemoveAt(0);//make work so you can remove one law when you deny it
                    tutorial ="denied";
                    Console.WriteLine("You didn't pass the law");
                }
                Console.WriteLine("Good job! You successfully " + tutorial + " a law!");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Hmm.. I could teach you how to do everything else, but most other kings learn better by doing! Good luck!");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();



            //skapa en for loop som innehåller allt som ska hända under en runda. Laws sparas under denna tid och kan printas ut under tiden
            for (int round = 0; round < 15; round++)//Varje loop är 1. People moving in depending on happiness average not below 100 (used as 0). 2. Food being subtracted or starvation, happiness down and people down 3. Law phase. Passing a law that affects happiness 4. Buy phase. Buy houses or food
            {
                Console.Clear();
                //People move in
                newGame.HappinessCheck();
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();
                //om ingen av dessa stämmer dvs det är 100 exakt händer inget
                //Food subtraction part
                newGame.PrintStats();
                newGame.FeedingTime();
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();

                //Law part
                newGame.LawTime(round);
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                Console.Clear();

                newGame.BuyTime();
            }
                /*Console.WriteLine("Done!These are the laws you passed:");
                for (int j= 0; j < 5; j++)
                {
                newGame.laws[j].MadLib();
                }
                Console.ReadLine();*/
            
            
           //nästa steg är att göra att lagarna har konsekvenser

           //ha en del av spelet där man väljer mellan att bygga eller göra annat. action choice screen
        }
    }
}
