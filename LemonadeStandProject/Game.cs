using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandProject
{
    public class Game
    {
        // member variables // has a
        public Player player = new Player();
        public SupplyShop gameShop = new SupplyShop();
        public int gameLength;
        public int dayCount;
        public List<Weather> weatherList = new List<Weather>();
        public List<Customer> customers = new List<Customer>();
        //public Weather weather = new Weather(1, false, 60);

        // constructor
        public Game()
        {
            gameLength = 1;
            dayCount = 1;
        }

        //member methods // can do
        // Single Responsibility #1 - BeginGame Method. This methods only responsibility is to begin the game. It displays rules, gets the game duration and interface, and then initializes the game loop. It's only job is to start the game.
        public void BeginGame()
        {
            DisplayRules();
            GameDuration();
            UserInterface.InitializeInterface(player);
            GameplayLoop();
            Console.ReadLine();
        }
        public void DisplayRules()
        {
            Console.WriteLine("You are an aspiring Lemonade Stand Tycoon. The Jeff Bezos of Lemonade Sales. But you need to work your way up.\n\n Let's start with the basics:\n\nYou start with $" + player.money + ". You need to purchase ice, sugar, and lemons. Afterwards, create a recipe for your lemonade. Colonel Sanders had a special recipe for his chicken. Get that magic number for your lemonade.\n\nThings that affect sales:\n\nCustomers have purchase preferences including temperature, precipitation, and their maximum budget for lemonade.\n\n");
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
                    RecipeLoop();
                }
                Console.Write("\n" + weatherList.First().temperature + "\n");
                DaySalesLoop(weatherList);
                SummaryLoop();
                dayCount++;
                Console.WriteLine("Welcome to Day " + dayCount);
            }
        }

        public void RecipeLoop()
        {
            player.recipe.ChangeRecipe();
            player.recipe.DisplayCurrentRecipe();
            Console.ReadLine();
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

            for (int i = 0; i < customers.Count(); i++)
            {
                customers.First().BuyLemonade(player, weather.First());
                customers.RemoveAt(0);
            }
            weather.RemoveAt(0);
            Console.WriteLine("You have " + player.cupsOfLemonade + " cups of lemonade remaining.");
            gameShop.stopShopping = false;
            customers.Clear();
        }
        public void SummaryLoop()
        {
            player.DailyInventoryAdjustment();
            UserInterface.DisplayForecast();
            UserInterface.DisplayRemainingDays();
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