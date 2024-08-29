using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsEventManager.Models;

namespace SportsEventManager.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Event> Events { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Venue> Venues { get; set; }
    public DbSet<EventPlayer> EventPlayers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<EventPlayer>()
            .HasKey(ep => new { ep.EventId, ep.PlayerId });

        modelBuilder.Entity<EventPlayer>()
            .HasOne(ep => ep.Event)
            .WithMany(e => e.EventPlayers)
            .HasForeignKey(ep => ep.EventId);

        modelBuilder.Entity<EventPlayer>()
            .HasOne(ep => ep.Player)
            .WithMany(p => p.EventPlayers)
            .HasForeignKey(ep => ep.PlayerId);
    }
}