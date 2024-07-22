using Microsoft.EntityFrameworkCore;
using PreciseiChamei.Domain.Entities;

namespace PreciseiChamei.Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {}
    public DbSet<User> Users { get; set; }
}