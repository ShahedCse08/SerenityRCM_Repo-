using SerenityRCM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace SerenityRCM.Persistence.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}