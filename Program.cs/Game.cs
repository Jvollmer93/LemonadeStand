using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Game
    {
        private int days;
        Customer customer = new Customer();
        List<int> weatherList = new List<int>();
        public int Days
        {
            get { return days; }
            set { days = value; }
        }
        public int DetermineDays()
        {
            string daysString;
            int x;
            do
            {
                do
                {
                    Console.WriteLine("How many days would you like the game to be? At least 7 days, maximum 21 days.");
                    daysString = Console.ReadLine();
                } while (!(int.TryParse(daysString, out x)));
            } while ((Int32.Parse(daysString) < 7)||(Int32.Parse(daysString) > 21));
            days = Int32.Parse(daysString);
            Console.Clear();
            return days;
        }
        public void GetProjectedWeather(int day)//call from program, arguments game.day, within loop days
        {
            Weather weather = new Weather();
            weatherList.Insert(day, weather.GetTemperature());
            //list for forecast for entire game time
        }
        public void DisplayWeatherList()
        {
            string combindedString = string.Join("\n", weatherList);
            Console.WriteLine(combindedString);
            Console.ReadLine();
        }
        public int[] GetWeather()
        {
            Weather weather = new Weather();
            int temperature = weather.GetTemperature();
            weather.DisplayTemperature();//should be in display weather
            weather.GetWeatherForecast();
            weather.DisplayForecast();//should be in display weather
            int forecastValue = weather.GiveForecastValue();
            int[] weatherArray = new int[] { temperature, forecastValue };
            return weatherArray;
        }
        //public void DisplayWeather()
        //{
        // Weather weather = new Weather();
        //weather.DisplayTemperature();
        //weather.DisplayForecast();
        //}
        public void NextCustomer()
        {
            Customer customer = new Customer();
        }
        public void GetCustomerWillingness(int temperature, int forecast)
        {
            customer.DetermineWillingness(temperature, forecast);
        }
        public bool CustomerDecideIfBuying()
        {
            return customer.DecideIfBuying();
        }
    }
}