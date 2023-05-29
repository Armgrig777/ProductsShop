using Microsoft.EntityFrameworkCore;
using ProductsShop.Data.Context;
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

                //Eager Loading
                var shop = repo.Shop
                    .Include(b => b.products.Where(p=>p.Id == 1))
                    .ThenInclude(p=>p.Name)
                    .ToList();
                //Explicit Loading
                var Shop = repo.Shop
                    .Single(s=>s.Id == 1);

                repo.Entry(Shop)
                    .Collection(b => b.products)
                   // .Query()
                  //  .Where(p => p.Id == 1)
                    .Load();

                repo.Entry(Shop)
                    .Reference(b => b.products)
                    .Load();
                
        }
    }
}