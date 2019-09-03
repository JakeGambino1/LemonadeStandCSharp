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
        public UserInterface gameState = new UserInterface();
        public IngredientsForPurchase gameShop = new IngredientsForPurchase();
        public int gameLength;

        // constructor
        public Game()
        {
            gameLength = 1;
        }

        //member methods // can do
        public void BeginGame()
        {
            GameDuration();
            gameState.InitializeInterface(player);
            GameLoop();
        }
        public void GameDuration()
        {
            Console.WriteLine("How many days would you like to play? Enter a number between 1-30");
            gameLength = Convert.ToInt32(Console.ReadLine());
        }
        public void GameLoop()
        {
            gameShop.BuyXUnits();
        }
    }
}