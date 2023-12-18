namespace AutoShop_API.Data;

public abstract class DbInitializer
{
    public static void Initialize(ProductContext productContext, ControlContext controlContext, CustomerContext customerContext, CredentialContext credentialContext)
    {
        productContext.Database.EnsureCreated();
        controlContext.Database.EnsureCreated();
        customerContext.Database.EnsureCreated();  
        credentialContext.Database.EnsureCreated();
        

        if (productContext.Products.Any() || controlContext.Controls.Any() || customerContext.Customers.Any() || credentialContext.Credentials.Any())
        {
            return;
        }

        productContext.SaveChanges();
        controlContext.SaveChanges();
        customerContext.SaveChanges();
        credentialContext.SaveChanges();
    }
}