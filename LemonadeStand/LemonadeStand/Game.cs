using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        //Member Variables 
        public string MainMenu;
        public string Name;
        public string Introduction;
        public int Money = 20;
        public int Lemons = 0;
        public int Cups = 0;
        public int IceCubes = 0;
        public int Employees = 0;
        public int Sugar = 0;
        public string PurchaseVariable;
        public string ItemCheck;
       

        // Constructor 
        public Game()
        {
            this.MainMenu = MainMenu;
            this.Name = Name;
            this.Money = Money;
            this.Lemons = Lemons;
            this.Cups = Cups;
            this.IceCubes = IceCubes;
            this.Employees = Employees;
            this.Sugar = Sugar;
            this.PurchaseVariable = PurchaseVariable;
        }


        // Member Methods
        public void DisplayIntroduction()
        {
            Console.WriteLine("Welcome, entrepreneur, to Lemonade Stand -- Pyramid Scheme Edition! ");
            Console.WriteLine("Uncle Sam (codename Slimey Sam) has enlisted you as his newest business owner in a growing chain of lemonade stands.");
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine("Glad to have you on board, " + Name + ", Now let's get down to business.");
            Console.WriteLine("The following are some items that you will need to purchase: lemons, sugar, ice cubes, and last but not least, cups.");
            Console.WriteLine("Press enter when you are ready to begin, " + Name);
            Console.ReadLine();
           
        }

        
        public void CheckInventory(int Money, int Lemons, int Cups, int IceCubes, int Sugar)
        {
            // When you get a chance, setup a for loop. 
            Console.WriteLine("You have " + Money + " dollars");
            Console.WriteLine("You have " + Lemons + " lemons");
            Console.WriteLine("You have " + Cups + " cups");
            Console.WriteLine("You have " + Sugar + " grams of sugar");
            Console.WriteLine("You have " + IceCubes + " cubes of ice");
            Console.WriteLine("Press Enter if these values are correct.");
            Console.ReadLine();
            
        }

        public void DisplayMainMenu()
        {
            Console.WriteLine("Below is an automated message from the Lemon Seeds App, declaring your available items.");
            CheckInventory(Money, Lemons, Cups, IceCubes, Sugar);
            
        }

        public void PurchaseSupplies() { 
}

        public void GamePlayLooper()
        {
            DisplayMainMenu();
            Console.WriteLine("Do you wish to purchase more supplies? Please enter yes or no.");
            string InventoryCheck = Console.ReadLine();
            if (InventoryCheck == "yes")
            {
                Console.WriteLine("Which item do you wish to purchase more of? Please enter only one value at a time.");
                string ItemCheck = Console.ReadLine();
                int.Parse(ItemCheck);
                Console.WriteLine(ItemCheck);

            }
            //    switch (ItemCheck)
            //    {
            //        case Lemons:
            //            Console.WriteLine("Lemons are $1 per. How many would you like to purchase? Please enter a numberical value.");
            //            string PurchaseVariable = Console.ReadLine();
            //            int.Parse(PurchaseVariable);
            //            break;

            //        case Cups:



            //    }
            //}


        }

        public void PlayGame()
        {
            
        }
    }
}