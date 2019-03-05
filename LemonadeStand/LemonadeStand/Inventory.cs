using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory : Game
    {
        // Member Variables
       
        public int Money = 100;
        public int Lemons = 0;
        public int Cups = 0;
        public int IceCubes = 0;
        public int Employees = 0;
        public int Sugar = 0;

        // Constructors
        public Inventory()
        {
            this.Money = Money;
            this.Lemons = Lemons;
            this.Cups = Cups;
            this.IceCubes = IceCubes;
            this.Employees = Employees;
            this.Sugar = Sugar;
        }
        // Member Methods 
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


        public void PurchaseSupplies()
        {
            Console.WriteLine("Do you wish to purchase more supplies? Please enter yes or no.");
            string InventoryCheck = Console.ReadLine();
            if (InventoryCheck == "yes")
            {
                Console.WriteLine("Which item do you wish to purchase more of? Please enter either lemons, cups, ice cubes, or sugar. No capitals.");
                string ItemCheck = Console.ReadLine();
                if (ItemCheck == "lemons")
                {
                    Console.WriteLine("Lemons are $3 a piece. How many would you like to purchase?");
                    NewQuantity = Console.ReadLine();
                    NewNewQuantity = int.Parse(NewQuantity);
                    Lemons += NewNewQuantity;
                    Money -= (NewNewQuantity * 3);
                    Console.WriteLine("You have purchased " + NewNewQuantity + " lemons. You now have " + Lemons + " Lemons.");
                    Console.WriteLine("You now have " + Money + " dollars.");
                    PurchaseSupplies();
                }
                else if (ItemCheck == "ice cubes")
                {
                    Console.WriteLine("ice cubes are $5 per 100 cubes. How many would you like to purchase? (NOTE: 1 quantity is equivelant to 100 ice cubes).");
                    NewQuantity = Console.ReadLine();
                    NewNewQuantity = int.Parse(NewQuantity);
                    IceCubes += NewNewQuantity * 100;
                    Money -= NewNewQuantity * 5;
                    Console.WriteLine("You have purchased " + NewNewQuantity + " ice cubes. You now have " + IceCubes + " ice cubes.");
                    Console.WriteLine("You now have " + Money + " dollars.");
                    PurchaseSupplies();
                }
                else if (ItemCheck == "sugar")
                {
                    Console.WriteLine("sugar is $1 a piece. How many would you like to purchase?");
                    NewQuantity = Console.ReadLine();
                    NewNewQuantity = int.Parse(NewQuantity);
                    Sugar += NewNewQuantity;
                    Money -= (NewNewQuantity * 1);
                    Console.WriteLine("You have purchased " + NewNewQuantity + " sugars. You now have " + Sugar + " sugars.");
                    Console.WriteLine("You now have " + Money + " dollars.");
                    PurchaseSupplies();
                }
                else if (ItemCheck == "cups")
                {
                    Console.WriteLine("cups are $1 a piece. How many would you like to purchase?");
                    NewQuantity = Console.ReadLine();
                    NewNewQuantity = int.Parse(NewQuantity);
                    Cups += NewNewQuantity;
                    Money -= (NewNewQuantity * 1);
                    Console.WriteLine("You have purchased " + NewNewQuantity + " cups. You now have " + Lemons + " Lemons.");
                    Console.WriteLine("You now have " + Money + " dollars.");
                    PurchaseSupplies();
                }
                else
                {
                    Console.WriteLine("The answer you have given is invalid. Please type in either lemons, ice cubes, sugar, or cups.");
                    PurchaseSupplies();
                }

            }
            else if (InventoryCheck == "no")
            {
                Console.WriteLine("Great! Let's prepare for the next round of sales!");
                DisplayMainMenu();
            }
            else
            {
                Console.WriteLine("You did not answer yes or no as requested. Are you a fucking idiot? Oh by the way, the answer is case sensitive.");
            }
           
        }
    }
}