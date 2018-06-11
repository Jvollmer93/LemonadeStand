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
            Player player = new Player();
            player.GetName();
            Game game = new Game();
            game.DetermineDays();
            player.GetInitialMoney();

            for(int i = 0; i < game.Days; i++)
            {
                game.GetProjectedWeather(i);
            }
            game.DisplayWeatherList();
            

            for (int i = 0; i < game.Days; i++)
            {
                int[] weather = game.GetWeather();

                player.BuyInventoryPrompt();
                double price = player.MakeLemonade();
                player.MakePitcher();
                for (int j = 0; j < 5; j++)
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
                player.EndOfDayMeltIce();
            }
        }
    }
}
//todo satisfaction, price relevent to cups purchased
//after, multiple players. last
//list inventory
//weekly forecast, predicted forecast/actual forecast