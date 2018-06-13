using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Player player = new Player();
            game.DisplayRules();
            player.GetName();            
            game.DetermineDays();
            player.GetInitialMoney();

            for (int i = 0; i < game.Days; i++)
            {
                int[] weather = game.GetWeather();

                player.BuyInventoryPrompt();
                double price = player.MakeLemonade();
                player.MakePitcher();
                for (int j = 0; j < 20; j++)
                {
                    game.NextCustomer();
                    game.GetCustomerWillingness(weather[0], weather[1], price);
                    if ((game.CustomerDecideIfBuying()) && (player.CheckStock()))
                    {
                        player.SellCup();
                        if (player.CheckPitcher() && player.CheckProduct())
                        {
                            player.MakePitcher();
                        }
                    }
                    else if (!player.CheckStock())
                    {
                        player.OutOfStock();
                    } 
                }
                player.GetCupsSoldOneDay();
                player.RunningTotal();
                player.EndOfDayMeltIce();
            }
            game.EndGame(player.GetRunningTotal());
        }
    }
}