﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Gameplay : Inventory
    {
        // Member Variables
        public int Days;
        public int Weather;
        public int Weeks;
        public int Customers;
        int[] CustomerArray = new int[100];
        List<string> WeeklyWeather = new List<string>();

        // Constructors
        public Gameplay()
        {
            this.Customers = Customers;
            this.Weather = Weather;
            this.Days = Days;
            this.Weeks = Weeks;
            //WeeklyWeather.Add("Monday");
            //WeeklyWeather.Add("Tuesday");
            //WeeklyWeather.Add("Wednesday");
            //WeeklyWeather.Add("Thursday");
            //WeeklyWeather.Add("Friday");
            //WeeklyWeather.Add("Saturday");
            //WeeklyWeather.Add("Sunday");
        }

        // Member Methods 
        public int DetermineWeather()
        {
            Console.WriteLine("Gathering the weather data for you");
            Console.WriteLine("Gathering...");
            Console.WriteLine("Gathering...");
            Console.WriteLine("Gathering...");
            Console.WriteLine("Gathering and...  gathering and...");
            Random rnd = new Random();
            Weather = rnd.Next(0, 100);
            Console.WriteLine("It is " + Weather + " degrees outside.");
            return Weather;
            
        }

        public void DetermineWeeklyWeather()
        {
            foreach (string Day in WeeklyWeather)
            {

            }
        }

        public void PopulateCustomerArray()
        {
            for (int i = 0; i < Customers; i++)
            {
                CustomerArray[i] = i;
            }
        }

        public void DeterminePopulation()
        {
            
            if (Weather <= 100  && Weather > 75)
            {
                Customers = 100;

            }
            else if (Weather <= 75 && Weather > 50)
            {
                Customers = 85;
      
            }
            else if (Weather <= 50 && Weather > 40)
            {
                Customers = 65;
          
            }
            else if (Weather <= 40 && Weather > 35)
            {
                Customers = 35;
           
            }
            else if (Weather <= 35 && Weather >= 32)
            {
                Customers = 15;
                
            }
            else
            {
                Console.WriteLine("Its too cold for Lemonade! Damn you Midwest Weather!");
            }
            PopulateCustomerArray();
            Console.WriteLine("There are " + Customers + " possible customers today, sir/madam." +
                " Go forth in the glory of Slimey Sam--I mean Lucky Lemons--and make some sales!");
            Console.ReadLine();
        }
        public void DetermineDays()
        {
            Console.WriteLine("How many weeks are you planning to run your operation before buying more supplies? Please enter a numerical value.");
            string UserInpoot = Console.ReadLine();
            Weeks = int.Parse(UserInpoot);
            Days = Weeks * 7;
            Console.WriteLine("You have chosen to run your operation for " + Days + " days.");
            Console.ReadLine();

        }
        public void StartingConditions()
        {
            DetermineWeather();
            DeterminePopulation();
            DetermineDays();
        }
        public void LivingTheDream()
        {
            Console.WriteLine("Alright kid, the day is young and the horizon far--let's get to it.");
            Console.WriteLine("Performing accelerated time loop to quickly gather results of today's grind... Brace yourself!");

            // 


        }
    }
}