using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class IngredientsForPurchase
    {
        // member variables
        public double price;
        public string name;
        public int amountOfIngredient;
        public double totalPurchasePrice;
        // constructor
        public IngredientsForPurchase()
        {
        }
        public int BuyXUnits(IngredientsForPurchase ingredientSelected)
        {
            Console.WriteLine("How many would you like to buy?");
            amountOfIngredient = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(amountOfIngredient + " " + ingredientSelected.name + " purchased.");
            return amountOfIngredient;
        }
        public double CalculateTotalCost(IngredientsForPurchase ingredientSelected) // Player player
        {
            totalPurchasePrice = amountOfIngredient * ingredientSelected.price;
            Console.WriteLine("The total cost of this purchase is $" + totalPurchasePrice);
            //player.money -= totalPurchasePrice;
            //Console.WriteLine(player.name + " has $" + player.money + " remaining to spend.");
            //Console.ReadLine();
            return totalPurchasePrice;
        }
    }
}
