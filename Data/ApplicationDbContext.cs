using Code1st.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Code1st.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Team>? Teams { get; set; }
    public DbSet<Player>? Players { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Team>().HasData(SampleData.GetTeams());
        modelBuilder.Entity<Player>().HasData(SampleData.GetPlayers());
    }
   
}
