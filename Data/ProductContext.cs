using AutoShop_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_API.Data;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; init; } = null!;
}