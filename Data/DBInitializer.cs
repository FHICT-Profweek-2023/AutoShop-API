using AutoShopAPI.Models;

namespace AutoShopAPI.Data;

public class DBInitializer
{
    public static void Initialize(ProductsContext context)
    {
        context.Database.EnsureCreated();

        if (context.Products.Any())
        {
            return;
        }

        var temperature = new Products[]
        {
            new Products { Id = 0, Name = "Kaas", Description = "Zuivel", Price = 5 },
            new Products { Id = 1, Name = "Worst", Description = "Van een koe", Price = 10 }
        };

        foreach (var t in temperature)
        {
            context.Products.Add(t);
        }

        context.SaveChanges();
    }
}