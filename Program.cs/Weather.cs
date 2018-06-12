using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Weather : Game
    {
        private int temperature;
        private string weatherForecast;
        private int forecastValue;
        private string[] forecastArray = { "Cloudy", "Sunny", "Raining", "Snowing", "Partly Cloudy", "Storming" };
        Random rnd = new Random();
        public Weather()
        {

        }
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public string WeatherForecast
        {
            get { return weatherForecast; }
            set { weatherForecast = value; }
        }
        public int ForecastValue
        {
            get { return forecastValue; }
            set { forecastValue = value; }
        }
        public int GetTemperature()
        { 
            temperature = rnd.Next(20, 100);
            return temperature;
        }
        public void GetWeatherForecast()
        { 
            int randomNumber = rnd.Next(0, 6);
            weatherForecast = forecastArray[randomNumber];
            if ((weatherForecast == "Snowing") && (temperature > 32))
            {
                GetWeatherForecast();
            }
        }
        public void DisplayTemperature()
        {
            Console.WriteLine("It is " + Temperature + " degrees out today!");
        }
        public void DisplayForecast()
        {
            Console.WriteLine("It is " + WeatherForecast + " outside today!");
        }
        public int GiveForecastValue()
        {
            if (WeatherForecast == "Cloudy")
            {
                ForecastValue = 45;
            }
            if (WeatherForecast == "Sunny")
            {
                ForecastValue = 90;
            }
            if (WeatherForecast == "Raining")
            {
                ForecastValue = 20;
            }
            if (WeatherForecast == "Snowing")
            {
                ForecastValue = 10;
            }
            if (WeatherForecast == "Partly Cloudy")
            {
                ForecastValue = 75;
            }
            if (WeatherForecast == "Storming")
            {
                ForecastValue = 5;
            }
            return ForecastValue;
        }
    }
}