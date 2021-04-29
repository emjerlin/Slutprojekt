using System;
using System.Collections.Generic;

namespace Slutprojekt
{
    public class Resources
    {
        private List<Citizen> citizens = new List<Citizen>();//kunna accessa denna från program
        public List<Citizen> Citizens{
            get{return citizens;}
            set{citizens=value;}
        }
        public List<Law> laws = new List<Law>();
        private int money;
        public int Money{
            get{return money;}
            set{money=value;}
        }
        private int food;
        public int Food{
            get {return food;}
            set{food=value;}
        }
        private int weapons;
        public int Weapons{
            get{return weapons;}
            set{weapons=value;}
        }
        private int buildingMaterial;
        public int BuildingMaterial{
            get{return buildingMaterial;}
            set{buildingMaterial=value;}
        }
        private int totalHappiness;
        private int averageHappiness;
        private string reason;
        public Resources(){
            money = 1000;
            food = 30;
            weapons = 0;
            buildingMaterial = 0;
            for (int i = 0; i < 5; i++)
            {
                citizens.Add(new Citizen());
            }
            totalHappiness=0;
            for (int i = 0; i < citizens.Count; i++)
            {
                totalHappiness= totalHappiness + citizens[i].Happiness;
            }
            averageHappiness = totalHappiness/citizens.Count;
        }
        public void Build(){
            buildingMaterial-=20;
            money-=200;
            for (int i = 0; i < 10; i++)
            {
                citizens.Add(new Citizen());
            }
            
        }
        public void HappinessCheck(){
            totalHappiness=0;
            for (int i = 0; i < citizens.Count; i++)
            if(citizens.Count==0){
                    reason="zerociti";
                    GameOver(reason);
                }
            else{
                totalHappiness= totalHappiness + citizens[i].Happiness;
            }
            averageHappiness = totalHappiness/citizens.Count;
            PrintStats();
            
            if (averageHappiness> 100){
            Console.WriteLine("Your town is so happy, they invited their friends!");
            citizens.Add(new Citizen());
            }
            else if (averageHappiness< 100){
            Console.WriteLine("Your town is sad, some of them up and left...");
            int removeInt = citizens.Count-2;
            for (int i = citizens.Count; i > removeInt; i--)
            {
                if(citizens.Count==0){
                    reason="zerociti";
                    GameOver(reason);
                }
                else{
                citizens.Remove(citizens[i-1]);
                }
            }
            }
            else if (averageHappiness == 100){
                Console.WriteLine("Your town is perfectly... Okay. They're not happy, not sad. Nothing happened");
            }
        }
        public void FeedingTime(){
            food = food-2*citizens.Count;
            if(food<0){
                food=0;
                Console.WriteLine("You couldn't give food to all your citizens. They are starving, and are unhappy...");
                Random generator = new Random();
                    for (int j = 0; j < citizens.Count; j++)
                    {
                     citizens[j].Happiness = citizens[j].Happiness-generator.Next(10);
                    }
                
            }
            else if(food>0){
                Console.WriteLine("You gave your citizens " + 2*citizens.Count + " food");
            }
        }
        public void LawTime(int i){
            int spotFilled = 0;
            while (spotFilled ==0){
            PrintStats();
            NewLaw();
            laws[i].MadLib();//writes out the law

            Console.WriteLine("Do you want to [pass] or [deny] the law?");
            bool verdict = laws[i].PassOrNot();
            if(verdict==true){
                Console.WriteLine("You passed the law");
                if(laws[i].GoodLaw == false){
                    Console.WriteLine("You.. Shouldn't have passed that law");
                    Random generator = new Random();
                    for (int j = 0; j < citizens.Count; j++)
                    {
                     citizens[j].Happiness = citizens[j].Happiness-generator.Next(10);
                    }
                }
                else if(laws[i].GoodLaw == true){
                    Console.WriteLine("Your citizens are really happy you approved that!");
                    Random generator = new Random();
                    for (int j = 0; j < citizens.Count; j++)
                    {
                     citizens[j].Happiness = citizens[j].Happiness+generator.Next(10);
                    }
                }
                spotFilled++;
            }
            if(verdict==false){
                laws.RemoveAt(i);//make work so you can remove one law when you deny it
                Console.WriteLine("You didn't pass the law");
            }
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }   
        }
        public void BuyTime(){
            Console.WriteLine("A caravan has come to town! Would you like anythin'?");
            Console.WriteLine("[Food]  [Weapons]");
            string buyResponse = Console.ReadLine();
        }
        public void NewLaw(){
            laws.Add(new Law());
            Console.WriteLine("Law number " + laws.Count);
        }
        public void PrintStats(){
            Console.WriteLine("Citizens: " + citizens.Count + " Money: " + Money +" Food: " + Food + " Happiness: " + averageHappiness);
            if(citizens.Count==0){
                    reason="zerociti";
                    GameOver(reason);
                }
        }
        public void GameOver(string reason){
            Console.WriteLine("You lost...");
            if(reason=="zerociti"){
                Console.WriteLine("Your incompetent rule has left the town completely empty.. No one wants to live here. I don't blame them, honestly. I'm leaving too");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("- royal councelor has left the game -");
            }
           System.Threading.Thread.Sleep(10000);
           System.Environment.Exit(0);
        }
    }
    
}
