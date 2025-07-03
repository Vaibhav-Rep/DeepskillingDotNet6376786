namespace EcommercePlatformSearchFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // using default array of products
            Product[] products = new Product[]
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Shoes", "Fashion"),
                new Product(604, "Watch", "Accessories"),
                new Product(399, "Smartphone", "Electronics"),
                new Product(182, "T-shirt", "Fashion"),
            };




            Console.Write("Enter search keyword: ");
            string keyword = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(keyword))
            {
                Console.WriteLine("Keyword cannot be empty. Exiting...");
                return;
            }


            Console.WriteLine($"Performing Linear Search for {keyword}");
            var result1 = SearchAlgorithms.LinearSearch(products, keyword);
            Console.WriteLine(result1 != null ? $"Found: {result1}" : "Not Found");




            Console.WriteLine($"\n Performing Binary Search for {keyword}");
            var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
            var result2 = SearchAlgorithms.BinarySearch(sortedProducts, keyword);
            Console.WriteLine(result2 != null ? $"Found: {result2}" : "Not Found");
        }
    }
}
