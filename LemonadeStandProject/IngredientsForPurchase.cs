using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class IngredientsForPurchase
    {
        public double price;
        public string name;
        public int ingredientAmount;
        public double totalPurchasePrice;
        
        public IngredientsForPurchase()
        {

        }

        public int BuyXUnits(IngredientsForPurchase ingredientChoice)
        {
            Console.WriteLine("How many would you like to buy?");
            ingredientAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ingredientAmount + " " + ingredientChoice.name + " purchased.");
            return ingredientAmount;
        }
        public double CalculateTotalCost(IngredientsForPurchase ingredientChoice) // Player player
        {
            totalPurchasePrice = ingredientAmount * ingredientChoice.price;
            Console.WriteLine("The total cost of this purchase is $" + totalPurchasePrice);
            return totalPurchasePrice;
        }
    }
}
