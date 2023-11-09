using AutoShopAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShopAPI.Data;

public class ProductsContext : DbContext
{
    public ProductsContext(DbContextOptions<ProductsContext> options)
        : base(options)
    {
    }

    public DbSet<Products> Products { get; set; } = null!;
}