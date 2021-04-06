using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Resources newGame = new Resources();//creates a resource class, which creates a new game

            Console.WriteLine(newGame.Citizens[1].AgeGroup);    

            //flytta konversationer till klasser, metoder i klasser
            Console.WriteLine("Welcome oh great leader! We are looking to grow our kingdom, and we hope you can guide us to fame and glory");
            Console.WriteLine("The kingdom currently has " + newGame.Citizens.Count + " citizens. That won't do...");
            
            Console.ReadLine();//add a 3 option response system with arrow keys
            Console.Clear();

            Console.WriteLine("Let's get you familiar with how to rule a kingdom! There are a lot of decisions a ruler must make. Building houses, managing food in the country, and passing laws");
            Console.WriteLine("");
            Console.WriteLine("In order to keep a country (happy), you must keep an eye on the wishes of the citizens. Different citizens want more or less focus on (housing), (environment), (healthcare) and (control).");
            Console.WriteLine("");
            Console.WriteLine("Oh, there's also a couple (resources) you should pay attention to. (Money) helps you hire workers, and trade to get resources. (Food)... Keeps your citizens fed, which can be good. (Weapons) help you incase of the *unlikely* occurence of revolting citizens, but that should be easily avoided if you keep an eye on the overall (happiness)");
            
            Console.WriteLine("Let's try it out! (This law won't affect the rest of your game, and is only meant to make you familiar with the mechanics)");
            Console.ReadLine();

                newGame.NewLaw();
                string tutorial ="";
                Console.WriteLine(newGame.laws[0].MadLib());//writes out the law
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

            //skapa en for loop som innehåller allt som ska hända under en runda. Laws sparas under denna tid och kan printas ut under tiden
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                int spotFilled = 0;
                while (spotFilled ==0){
                newGame.NewLaw();
                Console.WriteLine(newGame.laws[i].MadLib());//writes out the law

                Console.WriteLine("Do you want to [pass] or [deny] the law?");
                verdict = newGame.laws[i].PassOrNot();
                if(verdict==true){
                    Console.WriteLine("You passed the law");
                    spotFilled++;
                }
                if(verdict==false){
                    newGame.laws.RemoveAt(i);//make work so you can remove one law when you deny it
                    Console.WriteLine("You didn't pass the law");
                }
                 System.Threading.Thread.Sleep(2000);
                }
            }
            Console.Clear();
            Console.WriteLine("Done!These are the laws you passed:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(newGame.laws[i].MadLib());
            }
            Console.ReadLine();
           //nästa steg är att göra att lagarna har konsekvenser

           //ha en del av spelet där man väljer mellan att bygga eller göra annat. action choice screen
        }
    }
}
