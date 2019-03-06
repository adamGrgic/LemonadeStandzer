using System;
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

        public int Customers;
        int[] CustomerArray = new int[100];
        // Constructors
        public Gameplay()
        {
            this.Customers = Customers;
            this.Weather = Weather;
        }

        // Member Methods 
        public int DetermineWeather()
        {
            Console.WriteLine("Gathering the weather data for you");
            Console.WriteLine("Gathering...");
            Console.WriteLine("Gathering...");
            Console.WriteLine("Gathering...");
            Console.WriteLine("Gathering and....gathering and...");
            Random rnd = new Random();
            Weather = rnd.Next(0, Customers);
            Console.WriteLine("It is " + Weather + " degrees outside.");
            return Weather;
            
        }

        //public void PopulateCustomerArray()
        //{
        //    for (int NewCustomer = 0; NewCustomer < Customers; NewCustomer++)
        //    {
        //        CustomerArray[NewCustomer] = 
        //    }
        //}

        public void DeterminePopulation()
        {
            
            if (Weather <= 100  && Weather > 75)
            {
                Customers = 100;
                CustomerArray = Enumerable.Repeat(0, 100).ToArray();

            }
            else if (Weather <= 75 && Weather > 50)
            {
                Customers = 85;
                CustomerArray = Enumerable.Repeat(0, 85).ToArray();

            }
            else if (Weather <= 50 && Weather > 40)
            {
                Customers = 65;
                CustomerArray = Enumerable.Repeat(0, 65).ToArray();

            }
            else if (Weather <= 40 && Weather > 35)
            {
                Customers = 35;
                CustomerArray = Enumerable.Repeat(0, 35).ToArray();

            }
            else if (Weather <= 35 && Weather >= 32)
            {
                Customers = 15;
                CustomerArray = Enumerable.Repeat(0, 15).ToArray();

            }
            Console.WriteLine(CustomerArray);
            Console.WriteLine("There are " + Customers + " possible customers today, sir/madam." +
                " Go forth in the glory of Slimey Sam--I mean Lucky Lemons--and make some sales!");
            Console.ReadLine();
        }

        public void StartingConditions()
        {
            DetermineWeather();
            DeterminePopulation();
        }
        public void LivingTheDream()
        {
            Console.WriteLine("Alright kid, the day is young and the horizon far--let's get to it.");
            Console.WriteLine("Performing accelerated time loop to quickly gather results of today's grind... brace yourself!");


        }
    }
}