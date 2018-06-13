
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Customer //ex of single responsibilty principle. Customer class 1 job to find if customer is willing to/if they will buy lemonade
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
            priceValue = 100 - (100 * price);
            willingnessToBuy = ((temperature + forecastValue + priceValue) / 3) - 20;
        }
        public bool DecideIfBuying()
        {
            int randomNumber = rnd.Next(1, 101);
            if (randomNumber <= WillingnessToBuy)
            {
                Console.WriteLine("A customer bought a cup of lemonade.");
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