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
       

        // Constructor 
        public Game()
        {
            this.MainMenu = MainMenu;

        }


        // Member Methods
        public string DisplayMainMenu()
        {
            Console.WriteLine("Welcome, entrepreneur, to Lemonade Stand -- Pyramid Scheme Edition! ");
            Console.WriteLine("Uncle Sam (codename Slimey Sam) has enlisted you as his newest business owner in a growing chain of lemonade stands.");
            Console.WriteLine("What is your name?");
            Console.ReadLine();
            Console.WriteLine("Glad to have you on board, ! Now let's get down to business.");
            Console.WriteLine("The following are some items that you will need to purchase: lemons, sugar, ice cubes, and last but not least, cups.");
            return MainMenu;
        }
    }
}