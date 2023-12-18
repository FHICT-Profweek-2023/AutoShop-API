using AutoShop_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace AutoShop_API;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    private IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "AutoShop", Version = "v1" });
        });

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
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AutoShop v1"));
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