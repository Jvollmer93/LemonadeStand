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
            inventory.DisplayInventory();// second time around, random money being taken from user.
        }

        public void MakeLemonade()
        {
            lemonade = new Lemonade();
            lemonade.HowManyLemons();
            lemonade.HowMuchIce();
            lemonade.HowMuchSugar();
            lemonade.ChoosePricePerCup();
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
    }
}