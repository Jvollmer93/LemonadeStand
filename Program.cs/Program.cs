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
            game.DetermineDays();

            Player player = new Player();
            player.GetName();

            Inventory inventory = new Inventory();
            inventory.PlayerMoney = player.StartingMoney;

            for (int i = 0; i < game.Days; i++)
            {
                Weather weather = new Weather();
                weather.GetTemperature();
                weather.GetWeatherForecast();
                weather.DisplayTemperature();
                weather.GiveForecastValue();
                weather.DisplayForecast();

                inventory.DisplayInventory();
                inventory.BuyLemons();
                inventory.BuyIce();
                inventory.BuySugar();
                inventory.BuyCups();
                inventory.DisplayInventory();// second time around, random money being taken from user.

                Lemonade lemonade = new Lemonade();
                lemonade.HowManyLemons();
                lemonade.HowMuchIce();
                lemonade.HowMuchSugar();
                lemonade.ChoosePricePerCup();

                inventory.DecrementLemons(lemonade.LemonsUsed);
                inventory.DecrementSugar(lemonade.SugarUsed);
                for (int j = 0; j < 100; j++)
                {
                    Customer customer = new Customer();
                    customer.DetermineWillingness(customer.CustomerSatisfaction, weather.Temperature, weather.ForecastValue);
                    if (customer.DecideIfBuying())
                    {
                        lemonade.IncrementCupCount();
                        if (inventory.MakeSureNotOutOfStock())
                        {
                            inventory.DecrementCups();
                            inventory.IncrementMoney(lemonade.PricePerCup);
                            inventory.DecrementIceCubes(lemonade.IceCubesUsed);
                            if (lemonade.EmptyPitcher()&&lemonade.HaveEnoughProduct(inventory.NumLemons, inventory.NumSugar))
                            {
                                inventory.DecrementLemons(lemonade.LemonsUsed);
                                inventory.DecrementSugar(lemonade.SugarUsed);
                            }
                        }
                        else
                        {
                            inventory.OutOfStockPrompt();
                        }
                    }
                }
            }
        }
    }
}
//todo satisfaction, price relevent to cups purchased
//after, multiple players.
