using AutoShop_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_API.Data;

public class ProductsContext : DbContext
{
    public ProductsContext(DbContextOptions<ProductsContext> options)
        : base(options)
    {
    }

    public DbSet<Products> Products { get; set; } = null!;
}