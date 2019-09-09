using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandProject
{
    public class Game
    {
        public Player player = new Player();
        public SupplyShop shop = new SupplyShop();
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
            UI.DisplayRules(player);
            DurationCreation();
            GameplayLoop();
            UI.InitializeInterface(player);
            Console.ReadLine();
        }
        public void DurationCreation()
        {
            gameLength = UI.GetUserNumberInput("How many days would you like to play? Enter a number between 1-30");
            day = Repetitive.InstantiateDaysForGameDuration(gameLength, day);
        }
        public void GameplayLoop()
        {
            for (int i = 0; i < gameLength; i++)
            {
                UI.DisplayInventory(player);
                if (shop.stopShopping == false)
                {
                    shop.ShopLoop(player);
                }
                if (player.AdjustRecipe())
                {
                    RecipeLoop(player);
                }
                DaySalesLoop();
                SummaryLoop();
                dayCount++;
                UI.ShowInformation($"Welcome to Day {dayCount}.");
            }
        }
        public void RecipeLoop(Player player)
        {
            player.recipe.ChangeRecipe();
            UI.ShowInformation($"Your current lemonade mixture is {player.recipe.numberOfLemons} lemons, { player.recipe.amountOfIceCubes } ice cubes, and { player.recipe.amountOfSugar } cups of sugar. The recommended/starting sale price is ${player.recipe.price}.");
        }
        public void DaySalesLoop()
        {
            player.MakeLemonadePitcher(player.recipe, player.inventory);
            for (int i = 0; i < day[dayCount].customers.Count; i++)
            {
                day[dayCount].customers[i].BuyLemonade(player, day[dayCount]);
            }
            UI.ShowInformation($"You have {player.cupsOfLemonade} cups of lemonade remaining.");
            shop.stopShopping = false;
        }
        public void SummaryLoop()
        {
            player.DailyInventoryAdjustment(player);
            UI.DisplayForecast();
        }
    }
}