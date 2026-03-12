using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart;

namespace ECommerce
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var eItem = new ElectronicProduct("Washing Machine", 350, 6);
            var expiryDate = new DateOnly(2025, 1, 20);
            var gItem = new GroceryProduct("Tea Powder", 150, expiryDate);

            var cart = new ShoppingCart1();
            cart.AddProduct(eItem);
            cart.AddProduct(gItem);
            cart.DisplayCartContent();
            cart.CalculateTotalPrice();

            cart.RemoveProduct(1);
            cart.DisplayCartContent();
        }
    }
}

