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
        public Weather weather;
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
                    Console.WriteLine("How many days would you like the game to be? At least 7.");
                    daysString = Console.ReadLine();
                } while (!(int.TryParse(daysString, out x)));
            } while (Int32.Parse(daysString) < 7);
            days = Int32.Parse(daysString);
            Console.Clear();
            return days;
        }
        public int[] GetWeather()
        {
            Weather weather = new Weather();
            int temperature = weather.GetTemperature();
            weather.GetWeatherForecast();

            int forecastValue = weather.GiveForecastValue();

            int[] weatherArray = new int[] { temperature, forecastValue };
            return weatherArray;
        }
        public void DisplayWeather()
        {
            weather.DisplayTemperature();
            weather.DisplayForecast();
        }
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
