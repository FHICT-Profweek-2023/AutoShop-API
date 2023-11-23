using AutoShop_API.Data;

namespace AutoShop_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var productContext = services.GetRequiredService<ProductContext>();
                    var controlContext = services.GetRequiredService<ControlContext>();
                    var customerContext = services.GetRequiredService<CustomerContext>();
                    DbInitializer.Initialize(productContext, controlContext, customerContext);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the db.");
                }
            }

            host.Run();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
        }
    }
}

