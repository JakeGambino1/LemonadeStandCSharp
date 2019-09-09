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
        public int dayCount;
        public List<Day> day = new List<Day>();

        public Game()
        {
            gameLength = 1;
            dayCount = 0;
        }

        // Single Responsibility #1 - BeginGame Method. This methods only responsibility is to begin the game. It displays rules, gets the game duration and interface, and then initializes the game loop. It's only job is to start the game.
        public void BeginGame()
        {
            UserInterface.DisplayRules(player);
            DurationCreation();
            GameplayLoop();
            UserInterface.InitializeInterface(player);
            Console.ReadLine();
        }
        public void DurationCreation()
        {
            gameLength = UserInterface.GetUserNumberInput("How many days would you like to play? Enter a number between 1-30");
            day = Repetitive.InstantiateDaysForGameDuration(gameLength, day);
        }
        public void GameplayLoop()
        {
            for (int i = 0; i < gameLength; i++)
            {
                UserInterface.DisplayInventory(player);

                if (gameShop.stopShopping == false)
                {
                    gameShop.ShopLoop(player);
                }
                if (player.RecipeAdjustment())
                {
                    RecipeLoop(player);
                }
                DaySalesLoop();
                SummaryLoop();
                dayCount++;
                UserInterface.DisplayDayCount(dayCount);
            }
        }
        public void RecipeLoop(Player player)
        {
            player.recipe.ChangeRecipe();
            UserInterface.DisplayCurrentRecipe(player.recipe);
        }
        public void DaySalesLoop()
        {
            player.MakeLemonadePitcher(player.recipe, player.inventory);
            for (int i = 0; i < day[dayCount].customers.Count; i++)
            {
                day[dayCount].customers[i].BuyLemonade(player, day[dayCount]);
            }
            Console.WriteLine("You have " + player.cupsOfLemonade + " cups of lemonade remaining.");
            gameShop.stopShopping = false;
        }
        public void SummaryLoop()
        {
            player.DailyInventoryAdjustment(player);
            UserInterface.DisplayForecast();
        }
    }
}