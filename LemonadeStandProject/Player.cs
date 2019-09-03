using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    class Player
    {
        // member variables // has a
        public string name;
        public double money;
        public PlayerInventory playerInventory = new PlayerInventory();

        // constructor
        public Player()
        {
            name = "Player One";
            money = 20.00;
        }

        // member methods // can do
        public bool CanBuy()
        {
            if (money >= PurchaseProduct())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
