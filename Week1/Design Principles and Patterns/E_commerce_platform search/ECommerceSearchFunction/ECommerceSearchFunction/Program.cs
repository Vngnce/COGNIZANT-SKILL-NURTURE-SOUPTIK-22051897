using System;
using System.Diagnostics;

namespace ECommerceSearchFunction
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
            {
                new Product { ProductId = 101, ProductName = "Laptop", Category = "Electronics" },
                new Product { ProductId = 205, ProductName = "Shirt", Category = "Clothing" },
                new Product { ProductId = 333, ProductName = "Watch", Category = "Accessories" },
                new Product { ProductId = 421, ProductName = "Phone", Category = "Electronics" },
                new Product { ProductId = 502, ProductName = "Shoes", Category = "Footwear" }
            };

            Array.Sort(products, (p1, p2) => p1.ProductId.CompareTo(p2.ProductId));

            Console.Write("Enter Product ID to search: ");
            int targetId;
            if (!int.TryParse(Console.ReadLine(), out targetId))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            var stopwatch = Stopwatch.StartNew();
            Product linearResult = LinearSearch(products, targetId);
            stopwatch.Stop();
            Console.WriteLine("\n--- Linear Search ---");
            if (linearResult != null)
                Console.WriteLine(linearResult.ToString());
            else
                Console.WriteLine("Product not found");
            Console.WriteLine("Time Taken: {0} ticks", stopwatch.ElapsedTicks);

            stopwatch.Restart();
            Product binaryResult = BinarySearch(products, targetId);
            stopwatch.Stop();
            Console.WriteLine("\n--- Binary Search ---");
            if (binaryResult != null)
                Console.WriteLine(binaryResult.ToString());
            else
                Console.WriteLine("Product not found");
            Console.WriteLine("Time Taken: {0} ticks", stopwatch.ElapsedTicks);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        static Product LinearSearch(Product[] products, int targetId)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].ProductId == targetId)
                    return products[i];
            }
            return null;
        }

        static Product BinarySearch(Product[] products, int targetId)
        {
            int left = 0;
            int right = products.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (products[mid].ProductId == targetId)
                    return products[mid];
                else if (products[mid].ProductId < targetId)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
    }
}
