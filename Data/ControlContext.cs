using AutoShop_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_API.Data;

public class ControlContext : DbContext
{
    public ControlContext(DbContextOptions<ControlContext> options)
        : base(options)
    {
    }

    public DbSet<Control> Controls { get; set; } = null!;
}
