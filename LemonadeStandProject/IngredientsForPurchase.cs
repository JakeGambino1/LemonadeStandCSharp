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
        public double totalPurchasePrice;
        // constructor
        public IngredientsForPurchase()
        {

        }
        public IngredientsForPurchase IngredientToPurchase()
        {

        }
        public double BuyXUnits()
        {
            Console.WriteLine("How many would you like to buy?");
            double unitsPurchased = Convert.ToInt32(Console.ReadLine());
            IngredientsForPurchase product = new IngredientsForPurchase();
            Console.WriteLine(totalPurchasePrice);
            return totalPurchasePrice = unitsPurchased * Convert.ToInt32(product.price);
        }
    }
}
