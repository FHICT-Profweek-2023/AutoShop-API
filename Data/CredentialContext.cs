using AutoShop_API.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoShop_API.Data;

public class CredentialContext : DbContext
{
    public CredentialContext(DbContextOptions<CredentialContext> options)
        : base(options)
    {
    }

    public DbSet<Credential> Credentials { get; init; } = null!;
}