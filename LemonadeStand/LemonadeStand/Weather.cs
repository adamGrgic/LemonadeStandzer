using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather 
    {

        // Member Variables
        public int WeatherVariable;
        List<string> WeeklyWeather = new List<string>();
        string[] WeatherForecastOptions = new string[5];
        string[] DaysOfTheWeek = new string[7];
        public string forecastOption;

        // Constructor 
        public Weather()
        {
            this.WeatherVariable = WeatherVariable;
            this.forecastOption = forecastOption;
        }
        // Member Methods 
        public string[] CreateDaysOfTheWeek()
        {
            DaysOfTheWeek[0] = "Sunday";
            DaysOfTheWeek[1] = "Monday";
            DaysOfTheWeek[2] = "Tuesday";
            DaysOfTheWeek[3] = "Wednesday";
            DaysOfTheWeek[4] = "Thursday";
            DaysOfTheWeek[5] = "Friday";
            DaysOfTheWeek[6] = "Saturday";
            return DaysOfTheWeek;
        }

        public string[] CreateWeatherForecastOptions()
        {
            WeatherForecastOptions[0] = "Sunny";
            WeatherForecastOptions[1] = "Cloudy";
            WeatherForecastOptions[2] = "Partly Cloudy";
            WeatherForecastOptions[3] = "Raining";
            WeatherForecastOptions[4] = "Thunder and Lightning";
            return WeatherForecastOptions;
        }

        public string DetermineWeatherDay()
        {
            Random rnd = new Random();
            WeatherVariable = rnd.Next(5);
            forecastOption = WeatherForecastOptions[WeatherVariable];
            return forecastOption;
        }

        public int DetermineTemperatureDay()
        { 
            Random rnd = new Random();
            WeatherVariable = rnd.Next(101);
            return WeatherVariable;
        }

      
        public List<string> DetermineWeatherWeek()
        {
            Console.WriteLine("Gathering the weather data for you...");
            Console.WriteLine("Gathering...");
            Console.WriteLine("Gathering...");
            Console.WriteLine("Gathering...");
            Console.WriteLine("Gathering and...  gathering and...");
            CreateDaysOfTheWeek();
            for (int i = 0; i < 7; i++)
            {
                WeeklyWeather.Add($"Day: {DaysOfTheWeek[i]} Forecast: {DetermineWeatherDay()} Temperature: {DetermineTemperatureDay()}");
            }
            Console.ReadLine();
            return WeeklyWeather;
        }
    }
}