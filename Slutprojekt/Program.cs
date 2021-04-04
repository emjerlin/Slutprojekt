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
            Console.WriteLine("In order to keep a country [happy], you must keep an eye on the wishes of the citizens. Different citizens want more or less focus on [housing], [environment], [healthcare] and [control].");
            Console.WriteLine("");
            Console.WriteLine("Oh, there's also a couple [resources] you should pay attention to. [Money] helps you hire workers, and trade to get resources. [Food]... Keeps your citizens fed, which can be good. [Weapons] help you incase of the *unlikely* occurence of revolting citizens, but that should be easily avoided if you keep and eye on the overall [happiness]");
            Console.WriteLine("");


            

            Console.ReadLine();
        }
    }
}
