using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandProject
{
    public class Game
    {
        public Player player = new Player();
        public SupplyShop gameShop = new SupplyShop();
        public int gameLength;
        public static int dayCount;
        public List<Weather> weatherList = new List<Weather>();
        public List<Customer> customers = new List<Customer>();

        public Game()
        {
            gameLength = 1;
            dayCount = 1;
        }

        // Single Responsibility #1 - BeginGame Method. This methods only responsibility is to begin the game. It displays rules, gets the game duration and interface, and then initializes the game loop. It's only job is to start the game.
        public void BeginGame()
        {
            UserInterface.DisplayRules(player);
            GameDuration();
            UserInterface.InitializeInterface(player, weatherList);
            GameplayLoop();
            Console.ReadLine();
        }
        
        public void GameDuration()
        {
            Console.WriteLine("How many days would you like to play? Enter a number between 1-30");
            gameLength = Convert.ToInt32(Console.ReadLine());
            InstantiateWeather(gameLength);
        }
        public void InstantiateWeather(int numberOfDays)
        {
            for (int i = 0; i < numberOfDays; i++)
            {
                weatherList.Add(new Weather(i, RandomGenerator.BoolGenerator(), RandomGenerator.IntegerGenerator()));
            }
        }
        public void GameplayLoop()
        {
            for (int i = 0; i < gameLength; i++)
            {
                if (gameShop.stopShopping == false)
                {
                    gameShop.ShopLoop(player);
                }
                if (player.RecipeAdjustment())
                {
                    RecipeLoop(player);
                }
                DaySalesLoop(weatherList);
                SummaryLoop();
                dayCount++;
                UserInterface.DisplayDayCount();
            }
        }

        public void RecipeLoop(Player player)
        {
            player.recipe.ChangeRecipe();
            UserInterface.DisplayCurrentRecipe(player.recipe);
        }
        public void DaySalesLoop(List<Weather> weather)
        {
            player.MakeLemonadePitcher(player.recipe, player.inventory);

            if (weather.First().temperature <= 50)
            {
                for (int i = 0; i < 15; i++)
                {
                    customers.Add(new Customer(RandomGenerator.PriceGenerator(), RandomGenerator.IntegerGenerator()));
                }
            }
            else if (weather.First().temperature > 50 && weather.First().temperature <= 80)
            {
                for (int i = 0; i < 25; i++)
                {
                    customers.Add(new Customer(RandomGenerator.PriceGenerator(), RandomGenerator.IntegerGenerator()));
                }
            }
            else if (weather.First().temperature > 80 && weather.First().temperature <= 100)
            {
                for (int i = 0; i < 50; i++)
                {
                    customers.Add(new Customer(RandomGenerator.PriceGenerator(), RandomGenerator.IntegerGenerator()));
                }
            }
            else if (weather.First().temperature > 100)
            {
                for (int i = 0; i < 100; i++)
                {
                    customers.Add(new Customer(RandomGenerator.PriceGenerator(), RandomGenerator.IntegerGenerator()));
                }
            }
            for (int i = customers.Count - 1; i >= 0; i--)
            {
                customers.Last().BuyLemonade(player, weather.First());
                customers.RemoveAt(i);
            }
            weather.RemoveAt(0);
            Console.WriteLine("You have " + player.cupsOfLemonade + " cups of lemonade remaining.");
            gameShop.stopShopping = false;
            customers.Clear();
        }
        public void SummaryLoop()
        {
            player.DailyInventoryAdjustment(player);
            UserInterface.DisplayForecast(weatherList);
        }
        public void RepeatList(int howManyTimes, List<float> multiplyList)
        {
            for (int i = 0; i < howManyTimes; i++)
            {
                multiplyList.Add(new float());
            }
        }
    }
}