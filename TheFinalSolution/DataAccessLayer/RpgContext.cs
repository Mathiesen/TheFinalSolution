using Microsoft.EntityFrameworkCore;
using TheFinalSolution.Entities;

namespace TheFinalSolution.DataAccessLayer;

public class RpgContext : DbContext
{
    public virtual DbSet<Character> Characters { get; set; }
    
    public RpgContext(DbContextOptions<RpgContext> options) : base(options)
    {
        
    }

    public RpgContext()
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Gitcraft");
    }
}