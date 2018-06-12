using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Player
    {
        private string name;
        private double startingMoney = 20.00;
        private double runningTotal;

        public Inventory inventory = new Inventory();
        public Lemonade lemonade;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double StartingMoney
        {
            get { return startingMoney; }
            set { startingMoney = value; }
        }
        public void GetName()
        {
            Console.WriteLine("Please enter the player's name: ");
            Name = Console.ReadLine();
        }
        public void GetInitialMoney()
        {
            inventory.PlayerMoney = StartingMoney;
        }
        public void BuyInventoryPrompt()
        {
            inventory.DisplayInventory();
            inventory.BuyLemons();
            inventory.BuyIce();
            inventory.BuySugar();
            inventory.BuyCups();
            inventory.DisplayInventory();
        }

        public double MakeLemonade()
        {
            lemonade = new Lemonade();
            lemonade.HowManyLemons();
            lemonade.HowMuchIce();
            lemonade.HowMuchSugar();
            return lemonade.ChoosePricePerCup();
        }
        public void MakePitcher()
        {
            inventory.DecrementLemons(lemonade.LemonsUsed);
            inventory.DecrementSugar(lemonade.SugarUsed);
        }
        public void SellCup()
        {
            lemonade.IncrementCupCount();
            inventory.DecrementCups();
            inventory.IncrementMoney(lemonade.PricePerCup);
            inventory.DecrementIceCubes(lemonade.IceCubesUsed);
        }
        public bool CheckStock()
        {
            return inventory.MakeSureNotOutOfStock();
        }
        public bool CheckPitcher()
        {
            return lemonade.EmptyPitcher();
        }
        public bool CheckProduct()
        {
            return lemonade.HaveEnoughProduct(inventory.NumLemons, inventory.NumSugar);
        }
        public void OutOfStock()
        {
            inventory.OutOfStockPrompt();
        }
        public void EndOfDayMeltIce()
        {
            inventory.MeltIce();
        }
        public void GetCupsSoldOneDay()
        {
            double price = lemonade.PricePerCup;
            int cupCount = lemonade.GetCupCount();
            int pitcherCount = lemonade.GetPitcherCount();
            int totalSold = cupCount + (pitcherCount * 10);
            double sales = totalSold * price;
            runningTotal += sales;
            Console.WriteLine("Sold " + totalSold + " cups of lemonade today for $" + sales + " in sales!");
            Console.WriteLine("Total spent today: $" + inventory.SpentToday);
            Console.WriteLine("Profit today: $" + (sales - inventory.SpentToday));
            inventory.ResetSpentToday();
        }
        public void RunningTotal()
        {
            Console.WriteLine("Sales to date: $" + runningTotal);
            Console.WriteLine("Total spent to date: $" + inventory.TotalSpent);
            Console.WriteLine("Profit to date: $" + (runningTotal - inventory.TotalSpent));
            Console.ReadLine();
            Console.Clear();
        }
    }
}