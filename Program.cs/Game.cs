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
        List<Weather> weatherList = new List<Weather>();
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
            //weatherList.Add(day, weather.GetTemperature());
            weatherList.Add(new Weather(weather.Temperature, weather.WeatherForecast));
            //list for forecast for entire game time
        }
        public void DisplayWeatherList()
        {
            foreach (var i in weatherList)
            {
                Console.WriteLine(i);
            }
           // string combindedString = string.Join("\n", weatherList);
            //Console.WriteLine(combindedString);
           Console.ReadLine();
        }
        public int[] GetWeather()
        {
            Weather weather = new Weather();
            int temperature = weather.GetTemperature();
            weather.DisplayTemperature();
            weather.GetWeatherForecast();
            weather.DisplayForecast();
            int forecastValue = weather.GiveForecastValue();
            int[] weatherArray = new int[] { temperature, forecastValue };
            return weatherArray;
        }
        public void NextCustomer()
        {
            Customer customer = new Customer();
        }
        public void GetCustomerWillingness(int temperature, int forecast, double price)
        {
            customer.DetermineWillingness(temperature, forecast, price);
        }
        public bool CustomerDecideIfBuying()
        {
            return customer.DecideIfBuying();
        }
    }
}