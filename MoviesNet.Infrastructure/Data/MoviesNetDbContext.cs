using Microsoft.EntityFrameworkCore;

namespace MoviesNet.Infrastructure.Data;

public sealed class MoviesNetDbContext(DbContextOptions<MoviesNetDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
