using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Gameplay : Game
    {
        // Member Variables (has A);
        public int Days;

        public int Weeks;

        int[] CustomerArray = new int[100];
        List<string> WeeklyWeather = new List<string>();
        public Player player = new Player();
    }
}
        // Constructors
        //public Gameplay()
        //{
           
            
        //    this.Days = Days;
        //    this.Weeks = Weeks;
        //    //WeeklyWeather.Add("Monday");
        //    //WeeklyWeather.Add("Tuesday");
        //    //WeeklyWeather.Add("Wednesday");
        //    //WeeklyWeather.Add("Thursday");
        //    //WeeklyWeather.Add("Friday");
        //    //WeeklyWeather.Add("Saturday");
        //    //WeeklyWeather.Add("Sunday");
        //}

        // Member Methods 
        

 

        //public void PopulateCustomerArray()
        //{
        //    for (int i = 0; i < Customers; i++)
        //    {

        //        CustomerArray[i] = i;
        //    }
        //}

        //public void DeterminePopulation()
        //{
        //    // player.inventory.IceCubes
            
        //    if (Weather <= 100  && Weather > 75)
        //    {
        //        Customers = 100;

        //    }
        //    else if (Weather <= 75 && Weather > 50)
        //    {
        //        Customers = 85;
      
        //    }
        //    else if (Weather <= 50 && Weather > 40)
        //    {
        //        Customers = 65;
          
        //    }
        //    else if (Weather <= 40 && Weather > 35)
        //    {
        //        Customers = 35;
           
        //    }
        //    else if (Weather <= 35 && Weather >= 32)
        //    {
        //        Customers = 15;
                
        //    }
        //    else
        //    {
        //        Console.WriteLine("Its too cold for Lemonade! Damn you Midwest Weather!");
        //    }
        //    PopulateCustomerArray();
        //    Console.WriteLine("There are " + Customers + " possible customers today, sir/madam." +
        //        " Go forth in the glory of Slimey Sam--I mean Lucky Lemons--and make some sales!");
        //    Console.ReadLine();
        //}
        //public void DetermineDays()
        //{
        //    Console.WriteLine("How many weeks are you planning to run your operation before buying more supplies? Please enter a numerical value.");
        //    string UserInpoot = Console.ReadLine();
        //    Weeks = int.Parse(UserInpoot);
        //    Days = Weeks * 7;
        //    Console.WriteLine("You have chosen to run your operation for " + Days + " days.");
        //    Console.ReadLine();

        //}
        //public void StartingConditions()
        //{
        //    DetermineWeather();
        //    DeterminePopulation();
        //    DetermineDays();
        //}
        //public void LivingTheDream()
        //{
        //    Console.WriteLine("Alright kid, the day is young and the horizon far--let's get to it.");
        //    Console.WriteLine("Performing accelerated time loop to quickly gather results of today's grind... Brace yourself!");

            // 


//        }
//    }
//}