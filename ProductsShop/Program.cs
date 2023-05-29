using ProductsShop.Data.Data;

namespace ProductsShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using(ProductsRepo repo = new ProductsRepo())
            {
                var shops = repo.Shop;
                foreach(var shop in shops)
                {
                    Console.WriteLine($"{shop.Name} {shop.Id}");
                    foreach (var product in shop.products)
                    {
                        Console.WriteLine($"{product.Id} {product.Name} {product.Price} {product.Ammount}");
                    }
                }
            }
        }
    }
}