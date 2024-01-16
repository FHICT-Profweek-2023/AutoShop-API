using AutoShop_API.Data;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_API;

public class Startup(IConfiguration configuration)
{
    private IConfiguration Configuration { get; } = configuration;

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddDbContext<ProductContext>(options =>
        {
            options.UseMySQL(Configuration.GetConnectionString("DBConnection") ?? throw new InvalidOperationException());
        });

        services.AddDbContext<ControlContext>(options =>
        {
            options.UseMySQL(Configuration.GetConnectionString("DBConnection") ?? throw new InvalidOperationException());
        });

        services.AddDbContext<CustomerContext>(options =>
        {
            options.UseMySQL(Configuration.GetConnectionString("DBConnection") ?? throw new InvalidOperationException());
        });

        services.AddDbContext<CredentialContext>(options =>
        {
            options.UseMySQL(Configuration.GetConnectionString("DBConnection") ?? throw new InvalidOperationException());
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}