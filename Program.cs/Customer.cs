
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Customer
    {
        private double willingnessToBuy;
        Random rnd = new Random();

        public double WillingnessToBuy
        {
            get { return willingnessToBuy; }
            set { willingnessToBuy = value; }
        }

        public void DetermineWillingness(int temperature, int forecastValue, double price)
        {
            double priceValue;
            if((price - .25) < 0)
            {
                priceValue = 100;
            }
            else
            {
                priceValue = 100 - (price - .25);
            }
            willingnessToBuy = (temperature + forecastValue + priceValue) / 3;
        }
        public bool DecideIfBuying()
        {
            int randomNumber = rnd.Next(1, 101);
            if (randomNumber <= WillingnessToBuy)
            {
                Console.WriteLine("A customer bought a cup of lemonade");
                Console.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}