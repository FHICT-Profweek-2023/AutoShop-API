namespace AutoShop_API.Data;

public abstract class DbInitializer
{
    public static void Initialize(ProductContext productContext, ControlContext controlContext, CustomerContext customerContext)
    {
        productContext.Database.EnsureCreated();
        controlContext.Database.EnsureCreated();
        customerContext.Database.EnsureCreated();   

        if (productContext.Products.Any() || controlContext.Controls.Any() || customerContext.Customers.Any())
        {
            return;
        }

        productContext.SaveChanges();
        controlContext.SaveChanges();
        customerContext.SaveChanges();
    }
}