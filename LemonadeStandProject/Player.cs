using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Player
    {
        // member variables // has a
        public string name;
        public double money;
        public PlayerInventory inventory = new PlayerInventory();
        public bool canBuy;

        // constructor
        public Player()
        {
            Console.WriteLine("what would you like the player name to be?");
            name = Console.ReadLine();
            money = 20;
            canBuy = false;
        }

        // member methods // can do
        public bool CanBuy(double totalCost)
        {
            if (money >= totalCost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AdjustMoney(double amountSpent, Player player)
        {
            money -= amountSpent;
            Console.WriteLine(money);
            UserInterface.InitializeInterface(player);
        }
    }
}
