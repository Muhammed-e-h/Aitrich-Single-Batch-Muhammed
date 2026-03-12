

using System;

namespace ShoppingCart
{
    public abstract class Product
    {
        public decimal Price { get; set; }
        public string Item { get; set; }

        public Product(string item, decimal price)
        {
            Item = item;
            Price = price;
        }

        public abstract void DisplayInfo();
    }

    public class ElectronicProduct : Product
    {
        public int WarrantyPeriod { get; set; }

        public ElectronicProduct(string item, decimal price, int warrantyPeriod) : base(item, price)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"The item is {Item}, price is {Price:C}");
            Console.WriteLine($"The Warranty period is {WarrantyPeriod} months");
        }
    }

    public class GroceryProduct : Product
    {
        public DateOnly ExpiryDate { get; set; }

        public GroceryProduct(string item, decimal price, DateOnly expiryDate) : base(item, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"The item is {Item}, price is {Price:C}");
            Console.WriteLine($"The Expiry date of {Item} is {ExpiryDate}");
        }
    }

    public class ShoppingCart1
    {
        public Product[] products = new Product[10];
        public int ProductCount = 0;
        public decimal Total = 0;

        public void AddProduct(Product product)
        {
            if (ProductCount >= products.Length)
            {
                Console.WriteLine("Cart is full. Cannot add anything more.");
                return;
            }

            products[ProductCount++] = product;
            Console.WriteLine($"Added: {product.Item} :-{product.Price}");
        }

        public void RemoveProduct(int index)
        {
            if (index < 0 || index >= ProductCount)
            {
                Console.WriteLine("Invalid product index");
                return;
            }

            // Shift products left
            for (int i = index; i < ProductCount - 1; i++)
            {
                products[i] = products[i + 1];
            }

            products[--ProductCount] = null; // Clear the last product
            Console.WriteLine($"Product at index {index} removed successfully.");
        }

        public void CalculateTotalPrice()
        {
            Total = 0;
            for (int i = 0; i < ProductCount; i++)
            {
                Total += products[i].Price;
            }
            Console.WriteLine($"Total: {Total:C}");
        }

        public void DisplayCartContent()
        {
            if (ProductCount == 0)
            {
                Console.WriteLine("The cart is empty.");
                return;
            }

            Console.WriteLine("\nCart Content:");
            for (int i = 0; i < ProductCount; i++)
            {
                products[i].DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
