using AutoShop_API.Models;

namespace AutoShop_API.Data;

public class DBInitializer
{
    public static void Initialize(ProductContext context)
    {
        context.Database.EnsureCreated();

        if (context.Products.Any())
        {
            return;
        }

        var temperature = new Product[]
        {
            new Product { Id = 0, Name = "Kaas", Description = "Zuivel", Price = 5 },
            new Product { Id = 1, Name = "Worst", Description = "Van een koe", Price = 10 }
        };

        foreach (var t in temperature)
        {
            context.Products.Add(t);
        }

        context.SaveChanges();
    }
}