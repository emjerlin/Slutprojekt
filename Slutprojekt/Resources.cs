using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class Resources
    {
        private List<Citizen> citizens = new List<Citizen>();//kunna accessa denna från program
        public List<Citizen> Citizens
        {
            get { return citizens; }
            set { citizens = value; }
        }
        public List<Law> laws = new List<Law>();
        private int money;
        private int food;
        private int weapons;
        
        /*private int buildingMaterial;
        public int BuildingMaterial{
            get{return buildingMaterial;}
            set{buildingMaterial=value;}
        }*/
        private int totalHappiness;
        private int averageHappiness;
        private string reason;
        public Resources()
        {
            money = 200;
            food = 50;
            weapons = 0;
            //buildingMaterial = 0;
            for (int i = 0; i < 5; i++)
            {
                citizens.Add(new Citizen());
            }
            totalHappiness = 0;
            for (int i = 0; i < citizens.Count; i++)
            {
                totalHappiness = totalHappiness + citizens[i].Happiness;
            }
            averageHappiness = totalHappiness / citizens.Count;
        }
        public void Build()
        {
            //buildingMaterial-=20;
            money -= 200;
            for (int i = 0; i < 10; i++)
            {
                citizens.Add(new Citizen());
            }

        }
        public void HappinessCheck()
        {
            totalHappiness = 0;
            for (int i = 0; i < citizens.Count; i++)
                if (citizens.Count == 0)
                {
                    Console.Clear();
                    reason = "zerociti";
                    GameOver(reason);
                }
                else
                {
                    totalHappiness = totalHappiness + citizens[i].Happiness;
                }
            averageHappiness = totalHappiness / citizens.Count;
            PrintStats();

            if (averageHappiness > 0)
            {
                Console.WriteLine("Your town is so happy, they invited their friends!");
                citizens.Add(new Citizen());
            }
            else if (averageHappiness < 0)
            {
                if (averageHappiness < -20)
                {
                    if (averageHappiness < -50)
                    {
                        Console.WriteLine("Don't tell me I didn't warn you");
                        Revolt();
                    }
                    else
                    {
                        Console.WriteLine("Your town is... Ehem.. VERY unhappy.. I don't know about you, but I'd suggest in investing in some protection, I think I see pitchforks");
                    }
                }
                else
                {
                    Console.WriteLine("Your town is sad, some of them up and left...");
                    int removeInt = citizens.Count - 2;
                    for (int i = citizens.Count; i > removeInt; i--)
                    {
                        if (citizens.Count == 0)
                        {
                            Console.Clear();
                            reason = "zerociti";
                            GameOver(reason);
                        }
                        else
                        {
                            citizens.Remove(citizens[i - 1]);
                        }
                    }
                }
            }
            else if (averageHappiness == 0)
            {
                Console.WriteLine("Your town is perfectly... Okay. They're not happy, not sad. Nothing happened");
            }

        }
        public void HappinessCheckSmall()
        {
            totalHappiness = 0;
            for (int i = 0; i < citizens.Count; i++)
                if (citizens.Count == 0)
                {
                    Console.Clear();
                    reason = "zerociti";
                    GameOver(reason);
                }
                else
                {
                    totalHappiness = totalHappiness + citizens[i].Happiness;
                }
            averageHappiness = totalHappiness / citizens.Count;
            PrintStats();
        }
        public void FeedingTime()
        {
            food = food - 2 * citizens.Count;
            if (food < 0)
            {
                food = 0;
                Console.WriteLine("You couldn't give food to all your citizens. They are starving, and are unhappy...");
                Random generator = new Random();
                for (int j = 0; j < citizens.Count; j++)
                {
                    citizens[j].Happiness = citizens[j].Happiness - generator.Next(10);
                }

            }
            else if (food > 0)
            {
                Console.WriteLine("You gave your citizens " + 2 * citizens.Count + " food");
            }
        }
        public void LawTime(int round)
        {
            int spotFilled = 0;
            while (spotFilled == 0)
            {
                Console.Clear();
                HappinessCheckSmall();
                NewLaw();
                laws[round].MadLib();//writes out the law

                Console.WriteLine("Do you want to [pass] or [deny] the law?");
                bool verdict = laws[round].PassOrNot();
                if (verdict == true)
                {
                    Console.WriteLine("You passed the law");
                    if (laws[round].GoodLaw == false)
                    {
                        Console.WriteLine("You.. Shouldn't have passed that law");
                        Random generator = new Random();
                        for (int j = 0; j < citizens.Count; j++)
                        {
                            citizens[j].Happiness = citizens[j].Happiness - generator.Next(10);
                        }
                    }
                    else if (laws[round].GoodLaw == true)
                    {
                        Console.WriteLine("Your citizens are really happy you approved that!");
                        Random generator = new Random();
                        for (int j = 0; j < citizens.Count; j++)
                        {
                            citizens[j].Happiness = citizens[j].Happiness + generator.Next(10);
                        }
                    }
                    spotFilled++;
                }
                else if (verdict == false)
                {
                    Console.WriteLine("You didn't pass the law");
                    if (laws[round].GoodLaw == false)
                    {
                        Console.WriteLine("Good think you denied that...");
                        Random generator = new Random();
                        for (int j = 0; j < citizens.Count; j++)
                        {
                            citizens[j].Happiness = citizens[j].Happiness + generator.Next(5);
                        }
                    }
                    else if (laws[round].GoodLaw == true)
                    {
                        Console.WriteLine("Your citizens are sad you did that");
                        Random generator = new Random();
                        for (int j = 0; j < citizens.Count; j++)
                        {
                            citizens[j].Happiness = citizens[j].Happiness - generator.Next(5);
                        }
                    }
                    laws.RemoveAt(round);//make work so you can remove one law when you deny it
                }
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
        }
        public void BuyTime()
        {
            Console.Clear();
            PrintStats();
            int repeat = 0;
            while (repeat == 0)
            {
                Console.Clear();
                Console.WriteLine("A caravan has come to town! Would you like anythin'?");
                Console.WriteLine("[Food]  [Weapons] or [Nothing]");
                string buyResponse = Console.ReadLine();
                if (buyResponse == "food")
                {
                    int buyFoodLoop = 0;
                    while (buyFoodLoop == 0)
                    {
                        Console.Clear();
                        PrintStats();
                        Console.WriteLine("How much would you like? We take 3 gold for every piece of food");
                        string amountFoodString = Console.ReadLine();
                        int amountFood;
                        bool lyckad = int.TryParse(amountFoodString, out amountFood);
                        int cost = amountFood * 3;
                        if (cost > money)
                        {
                            lyckad = false;
                        }

                        if (lyckad)
                        {
                            money = money - cost;
                            food = food + amountFood;
                            buyFoodLoop++;
                        }
                        else
                        {
                            Console.WriteLine("You can't pay for that. Or, you're not saying a coherent number");
                        }
                    }

                    repeat++;
                }
                else if (buyResponse == "weapons")
                {
                    int buyWeaponsLoop = 0;
                    while (buyWeaponsLoop == 0)
                    {
                        Console.Clear();
                        PrintStats();
                        Console.WriteLine("How much would you like? We take 40 gold for every weapon");
                        string amountWeaponsString = Console.ReadLine();
                        int amountWeapons;
                        bool lyckad = int.TryParse(amountWeaponsString, out amountWeapons);
                        int cost = amountWeapons * 40;
                        if (cost > money)
                        {
                            lyckad = false;
                        }

                        if (lyckad)
                        {
                            money = money - cost;
                            weapons = weapons + amountWeapons;
                            buyWeaponsLoop++;
                        }
                        else
                        {
                            Console.WriteLine("You can't pay for that. Or, you're not saying a coherent number");
                        }
                    }
                    repeat++;
                }
                else if (buyResponse == "nothing")
                {
                    repeat++;
                }
                else
                {
                    Console.WriteLine("They are... Waiting for your response, my lord. You need to work on your pronounciation");

                }
            }
        }
        public void NewLaw()
        {
            laws.Add(new Law());
            Console.WriteLine("Law number " + laws.Count);
        }
        public void PrintStats()
        {
            Console.WriteLine("Citizens: " + citizens.Count + " Money: " + money + " Food: " + food + " Happiness: " + averageHappiness);
            if (citizens.Count == 0)
            {
                reason = "zerociti";
                GameOver(reason);
            }
        }
        public void Revolt()
        {


            reason = "revolt";
            GameOver(reason);
        }
        public void GameOver(string reason)
        {
            Console.WriteLine("You lost...");
            if (reason == "zerociti")
            {
                Console.WriteLine("Your incompetent rule has left the town completely empty.. No one wants to live here. I don't blame them, honestly. I'm leaving too");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("- royal councelor has left the game -");
            }
            else if (reason == "revolt")
            {
                Console.WriteLine("You failed to keep your citizens out of the castle, and they have committed a coup. You are exiled, lucky having escaped with your life");
                Console.WriteLine("I thought you'd be different... Well, time to find a new king, and calm some citizens.. Leave");
            }
            System.Threading.Thread.Sleep(10000);
            System.Environment.Exit(0);
        }
    }

}
