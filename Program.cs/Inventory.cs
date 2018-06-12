using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Inventory
    {
        private int numLemons;
        private int numSugar;
        private int numIceCubes;
        private int numCups;
        private double playerMoney;
        private double spentToday;
        private double totalSpent;

        public int NumLemons
        {
            get { return numLemons; }
            set { numLemons = value; }
        }
        public int NumSugar
        {
            get { return numSugar; }
            set { numSugar = value; }
        }
        public int NumIceCubes
        {
            get { return numIceCubes; }
            set { numIceCubes = value; }
        }
        public int NumCups
        {
            get { return numCups; }
            set { numCups = value; }
        }
        public double PlayerMoney
        {
            get { return playerMoney; }
            set { playerMoney = value; }
        }
        public double TotalSpent
        {
            get { return totalSpent; }
            set { totalSpent = value; }
        }
        public double SpentToday
        {
            get { return spentToday; }
            set { spentToday = value; }
        }
        public void BuyLemons()
        {
            int x;
            string buyLemonsString;
            do
            {
                Console.WriteLine("How many lemons would you like to buy today? $.05 per lemon.");
                buyLemonsString = Console.ReadLine();
            } while (!(int.TryParse(buyLemonsString, out x)));
            numLemons += Int32.Parse(buyLemonsString);
            playerMoney -= (Int32.Parse(buyLemonsString) * .05);
            totalSpent += (Int32.Parse(buyLemonsString) * .05);
            spentToday += (Int32.Parse(buyLemonsString) * .05);
        }
        public void BuySugar()
        {
            int x;
            string buySugarString;
            do
            {
                Console.WriteLine("How much sugar would you like to buy today? $.08 per cup.");
                buySugarString = Console.ReadLine();
            } while (!(int.TryParse(buySugarString, out x)));
            numSugar += Int32.Parse(buySugarString);
            playerMoney -= (Int32.Parse(buySugarString) * .08);
            totalSpent += (Int32.Parse(buySugarString) * .08);
            spentToday += (Int32.Parse(buySugarString) * .08);
        }
        public void BuyIce()
        {
            int x;
            string buyIceString;
            do
            {
                Console.WriteLine("How much ice would you like to buy today? $.01 per cube.");
                buyIceString = Console.ReadLine();
            } while (!(int.TryParse(buyIceString, out x)));
            numIceCubes += Int32.Parse(buyIceString);
            playerMoney -= (Int32.Parse(buyIceString) * .01);
            totalSpent += (Int32.Parse(buyIceString) * .01);
            spentToday += (Int32.Parse(buyIceString) * .01);
        }
        public void BuyCups()
        {
            int x;
            string buyCupsString;
            do
            {
                Console.WriteLine("How many cups would you like to buy today? $.03 per cups.");
                buyCupsString = Console.ReadLine();
            } while (!(int.TryParse(buyCupsString, out x)));
            numCups += Int32.Parse(buyCupsString);
            playerMoney -= (Int32.Parse(buyCupsString) * .03);
            totalSpent += (Int32.Parse(buyCupsString) * .03);
            spentToday += (Int32.Parse(buyCupsString) * .03);
        }
        public void DisplayInventory()
        {
            Console.WriteLine("Sugar : " + numSugar + ", Ice : " + numIceCubes + ", Lemons : " + numLemons + ", Cups : " + numCups + ".");
            Console.WriteLine("Player money remaining : $" + playerMoney);
            Console.ReadLine();
            Console.Clear();
        }
        public bool MakeSureNotOutOfStock()
        {
            if ((numCups > 0) && (numSugar > 0) && (numLemons > 0) && (numIceCubes > 0))
            {
                return true;
            }
            return false;
        }
        public void OutOfStockPrompt()
        {
            Console.WriteLine("Out of stock, the customer had no lemonade to purchase.");
            Console.ReadLine();
        }
        public void DecrementLemons(int lemonsUsed)
        {
            NumLemons -= lemonsUsed;
        }
        public void DecrementIceCubes(int iceUsed)
        {
            NumIceCubes -= iceUsed;
        }
        public void DecrementSugar(int sugarUsed)
        {
            NumSugar -= sugarUsed;
        }
        public void DecrementCups()
        {
            NumCups--;
        }
        public void IncrementMoney(double money)
        {
            playerMoney += money;
        }
        public void MeltIce()
        {
            Console.WriteLine("Your leftover ice melts overnight.");
            NumIceCubes = 0;
        }
        public void ResetSpentToday()
        {
            spentToday = 0;
        }
    }
}