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
        
        public string PurchaseVariable;
        public string ItemCheck;
        public string NewQuantity;
        public int NewNewQuantity;
       

        // Constructor 
        public Game()
        {
            this.MainMenu = MainMenu;
            this.Name = Name;
            
            this.PurchaseVariable = PurchaseVariable;
            this.NewQuantity = NewQuantity;
            this.NewNewQuantity = NewNewQuantity;
        }


        // Member Methods
        public void DisplayIntroduction()
        {
            Console.WriteLine("Welcome, entrepreneur, to Lemonade Stand -- Pyramid Scheme Edition! ");
            Console.WriteLine("Hello! My name is Lucky Lemons App and I am messaging you on behalf of our owner, Sam" +
                " (codename Slimey Sam), who has enlisted you as his newest business owner in a growing chain of lemonade stands." +
                " Currently on the rise on the West Coast, Sam has asked you to open up your own lemonade stand under the Lucky Lemons name in Milwaukee, Wisconsin." +
                " ");
            Console.WriteLine("If you accept, please enter your name below.");
            string Name = Console.ReadLine();
            Console.WriteLine("Glad to have you on board, " + Name + ", Now let's get down to business." +
                "The rules of the venture as follows: you are given a $100 to open your glamorous new lemonade stand. " +
                "With that $100, you are expected to purchase: lemons, sugar, ice cubes, and last but not least, cups." +
                "Unlike most full-time jobs, you will be expected to work 9-5, 7 days a week. " +
                "If you're money falls below $0, you will lose and be unable to pass go! Wait, wrong game. In this game you just lose....your soul.");
            Console.WriteLine("Press enter when you are ready to begin, " + Name);
            Console.ReadLine();
           
        }

        
        

        

        

        //public void GamePlayLooper()
        //{
        //    DisplayMainMenu();
            

        //    }
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

        
}