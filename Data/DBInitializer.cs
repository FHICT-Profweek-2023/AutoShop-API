using AutoShop_API.Models;

namespace AutoShop_API.Data;

public class DBInitializer
{
    public static void Initialize(ProductContext productContext, ControlContext controlContext)
    {
        productContext.Database.EnsureCreated();
        controlContext.Database.EnsureCreated();

        if (productContext.Products.Any() || controlContext.Controls.Any())
        {
            return;
        }

        productContext.SaveChanges();
        controlContext.SaveChanges();
    }
}