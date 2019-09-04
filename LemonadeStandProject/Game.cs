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

        // constructor
        public Game()
        {
            gameLength = 1;
        }

        //member methods // can do
        public void BeginGame()
        {
            GameDuration();
            UserInterface.InitializeInterface(player);
            GameLoop();
            Console.ReadLine();
        }
        public void GameDuration()
        {
            Console.WriteLine("How many days would you like to play? Enter a number between 1-30");
            gameLength = Convert.ToInt32(Console.ReadLine());
        }
        public void GameLoop()
        {
            gameShop.InitializeShop(player);
            GameLoop();
        }
    }
}