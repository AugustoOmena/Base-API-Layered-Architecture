using Microsoft.EntityFrameworkCore;
using PreciseiChamei.Domain.Entities;

namespace PreciseiChamei.Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=preciseichamei.api; Username=postgres; Password=123456", 
                b => b.MigrationsAssembly("PreciseiChamei.Persistence"));
        }
    }
}
