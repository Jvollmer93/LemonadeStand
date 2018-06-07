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
        private int customerSatisfaction = 100;//initial overall satisfaction 100%
        Random rnd = new Random();

        public double WillingnessToBuy
        {
            get { return willingnessToBuy; }
            set { willingnessToBuy = value; }
        }
        public int CustomerSatisfaction
        {
            get { return customerSatisfaction; }
            set { customerSatisfaction = value; }
        }
        public void DetermineWillingness(int temperature, int forecastValue)
        {
            //(satisfaction + temp + value for forecast)/3
            //include price
            willingnessToBuy = (temperature + forecastValue)/2;
        }
       /* public void ChangeSatisfaction()
        {
            int randomNumber = rnd.Next(0, 2);
            if(randomNumber == 1)
            {
                Console.WriteLine("The customer enjoyed their lemonade, +1 satisfaction.");
                customerSatisfaction++;
            }
            else if (randomNumber == 0)
            {
                Console.WriteLine("The customer did not enjoy the lemonade, -1 satisfaction");
                customerSatisfaction--;
            }
            if (customerSatisfaction>=100)
            {
                customerSatisfaction = 100;
            }
            if (customerSatisfaction<=0)
            {
                customerSatisfaction = 0;
            }
        }*/
        public bool DecideIfBuying()
        {
            int randomNumber = rnd.Next(1,101);
            if(randomNumber <= WillingnessToBuy)
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
