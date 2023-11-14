using AutoShop_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_API.Data;

public class CustomerContext : DbContext
{
    public CustomerContext(DbContextOptions<CustomerContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; } = null!;
}