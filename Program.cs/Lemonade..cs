﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Lemonade
    {
        private int lemonsUsed;
        private int iceCubesUsed;
        private int sugarUsed;
        private int cupsInPitcher = 10;
        private int cupCount = 0;
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
                Console.WriteLine("How many lemons would you like to use per pitcher today?");
                lemonsUsedString = Console.ReadLine();
            } while (!(int.TryParse(lemonsUsedString, out x)));
            lemonsUsed = Int32.Parse(lemonsUsedString);
        }
        public void HowMuchSugar()
        {
            int x;
            string sugarUsedString;
            do
            {
                Console.WriteLine("How many cups of sugar would you like to use per pitcher today?");
                sugarUsedString = Console.ReadLine();
            } while (!(int.TryParse(sugarUsedString, out x)));
            sugarUsed = Int32.Parse(sugarUsedString);
        }
        public void HowMuchIce()
        {
            int x;
            string iceUsedString;
            do
            {
                Console.WriteLine("How many ice cubes would you like to use per cup today?");
                iceUsedString = Console.ReadLine();
            } while (!(int.TryParse(iceUsedString, out x)));
            iceCubesUsed = Int32.Parse(iceUsedString);
        }
        public void ChoosePricePerCup()
        {
            double x;
            string userPrice;
            do
            {
                Console.WriteLine("How much would you like to charge per cup of lemonade today? $.$$");
                userPrice = Console.ReadLine();//to double
            } while (!double.TryParse(userPrice, out x));
            PricePerCup = Convert.ToDouble(userPrice);
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
                return true;
            }
            return false;
        }
        public bool HaveEnoughProduct(int lemons, int sugar)
        {
            if(((lemonsUsed-lemons)>0)&&((sugarUsed-sugar)>0))
            {
                return true;
            }
            return false;
        }
    }
}