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
    }
}
