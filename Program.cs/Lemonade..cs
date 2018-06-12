using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Lemonade : Player
    {
        private int lemonsUsed;
        private int iceCubesUsed;
        private int sugarUsed;
        private int cupsInPitcher = 10;
        private int cupCount = 0;
        private int pitcherCount = 0;
        private double pricePerCup;

        public int CupCount
        {
            get { return cupCount; }
            set { cupCount = value; }
        }
        public int LemonsUsed
        {
            get { return lemonsUsed; }
            set { lemonsUsed = value; }
        }
        public int SugarUsed
        {
            get { return sugarUsed; }
            set { sugarUsed = value; }
        }
        public int IceCubesUsed
        {
            get { return iceCubesUsed; }
            set { iceCubesUsed = value; }
        }
        public int CupsInPitcher
        {
            get { return cupsInPitcher; }
            set { cupsInPitcher = value; }
        }
        public double PricePerCup
        {
            get { return pricePerCup; }
            set { pricePerCup = value; }
        }
        public void HowManyLemons()
        {
            int x;
            string lemonsUsedString;
            do
            {
                do
                {
                    Console.WriteLine("How many lemons would you like to use per pitcher today? At least 1.");
                    lemonsUsedString = Console.ReadLine();
                } while (!(int.TryParse(lemonsUsedString, out x)));
            } while (Int32.Parse(lemonsUsedString) < 1);
            lemonsUsed = Int32.Parse(lemonsUsedString);
        }
        public void HowMuchSugar()
        {
            int x;
            string sugarUsedString;
            do
            {
                do
                {
                    Console.WriteLine("How many cups of sugar would you like to use per pitcher today? At least 1.");
                    sugarUsedString = Console.ReadLine();
                } while (!(int.TryParse(sugarUsedString, out x)));
            } while (Int32.Parse(sugarUsedString) < 1);
            sugarUsed = Int32.Parse(sugarUsedString);
        }
        public void HowMuchIce()
        {
            int x;
            string iceUsedString;
            do
            {
                do
                {
                    Console.WriteLine("How many ice cubes would you like to use per cup today? At least 1.");
                    iceUsedString = Console.ReadLine();
                } while (!(int.TryParse(iceUsedString, out x)));
            } while (Int32.Parse(iceUsedString) < 1);
            iceCubesUsed = Int32.Parse(iceUsedString);
        }
        public double ChoosePricePerCup()
        {
            double x;
            string userPrice;
            do
            {
                do
                {
                    Console.WriteLine("How much would you like to charge per cup of lemonade today? $0.01 - $1.00");
                    userPrice = Console.ReadLine();
                } while (!double.TryParse(userPrice, out x));
            }while((Convert.ToDouble(userPrice) > 1)||(Convert.ToDouble(userPrice) <= 0));
            PricePerCup = Convert.ToDouble(userPrice);
            return PricePerCup;
        }
        public void IncrementCupCount()
        {
            cupCount++;
        }
        public bool EmptyPitcher()
        {
            if (CupCount == CupsInPitcher)
            {
                cupCount = 0;
                pitcherCount++;
                return true;
            }
            return false;
        }
        public bool HaveEnoughProduct(int lemons, int sugar)
        {
            if (((lemons - lemonsUsed) > 0) && ((sugar - sugarUsed) > 0))
            {
                return true;
            }
            return false;
        }
        public int GetPitcherCount()
        {
            return pitcherCount;
        }
        public int GetCupCount()
        {
            return cupCount;
        }
    }
}