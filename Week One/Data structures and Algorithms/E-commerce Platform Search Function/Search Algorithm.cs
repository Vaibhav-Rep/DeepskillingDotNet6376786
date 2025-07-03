namespace EcommercePlatformSearchFunction
{
    public static class SearchAlgorithms
    {
        public static Product LinearSearch(Product[] products, string keyword)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(keyword, StringComparison.OrdinalIgnoreCase))
                    return product;
            }
            return null;
        }


        public static Product BinarySearch(Product[] products, string keyword)
        {
            int left = 0, right = products.Length - 1;


            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(products[mid].ProductName, keyword, true);


                if (comparison == 0)
