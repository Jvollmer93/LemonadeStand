using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Game
    {
        private int days;
        public int Days
        {
            get { return days; }
            set { days = value; }
        }
        public int DetermineDays()
        {
            string daysString;
            int x;
            do
            {
                do
                {
                    Console.WriteLine("How many days would you like the game to be? At least 7.");
                    daysString = Console.ReadLine();
                } while (!(int.TryParse(daysString, out x)));
            } while (Int32.Parse(daysString) < 7);
            days = Int32.Parse(daysString);
            return days;
        }
    }
}
