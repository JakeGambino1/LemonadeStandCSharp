﻿using System;
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
        public Customer customer = new Customer();
        public int dayCount;
        public Weather weather = new Weather();

        // constructor
        public Game()
        {
            gameLength = 1;
            dayCount = 1;
        }

        //member methods // can do
        public void DisplayRules()
        {
            Console.WriteLine("You are an aspiring Lemonade Stand Tycoon. The Jeff Bezos of Lemonade Sales. But you need to work your way up.\n\n Let's start with the basics:\n\nYou start with $" + player.money + ". You need to purchase ice, sugar, and lemons. Afterwards, create a recipe for your lemonade. Colonel Sanders had a special recipe for his chicken. Get that magic number for your lemonade.\n\nThings that affect sales:\n\nCustomers have purchase preferences including temperature, precipitation, and their maximum budget for lemonade.\n\n");
        }
        public void BeginGame()
        {
            DisplayRules();
            GameDuration();
            UserInterface.InitializeInterface(player);
            GameplayLoop();
            Console.ReadLine();
        }
        public void GameDuration()
        {
            // ADD TRY CATCH EXCEPTION HERE
            Console.WriteLine("How many days would you like to play? Enter a number between 1-30");
            gameLength = Convert.ToInt32(Console.ReadLine());
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
                DayLoop(weather);
                SummaryLoop();
            }
        }

        public void RecipeLoop()
        {
            player.recipe.DisplayCurrentRecipe();
            player.recipe.ChangeRecipe();
            player.recipe.DisplayCurrentRecipe();
            Console.ReadLine();
        }
        public void DayLoop(Weather weather)
        {
            dayCount++;
            Console.WriteLine("You are now on Day " + dayCount);
            // customer goes to shop
            customer.BuyLemonade(player, weather);
            gameShop.stopShopping = false;

            // sees if mixture/weather is to their liking
            // makes a purchase (or doesn't)
            // adjust available inventory
        }
        public void SummaryLoop()
        {

        }
    }
}