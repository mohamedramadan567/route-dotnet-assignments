using EventHub.Configurations;
using EventHub.Models;
using Microsoft.EntityFrameworkCore;

namespace EventHub
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.;Database=EventHubDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        // ─── DbSets ───────────────────────────────────────────────────────────────
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ── Apply separate configuration classes ──────────────────────────────
            // Event and Registration are configured via IEntityTypeConfiguration classes
            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new RegistrationConfiguration());

            // ─────────────────────────────────────────────────────────────────────
            // ORGANIZER  →  configured via Fluent API (inline)
            // ─────────────────────────────────────────────────────────────────────
            modelBuilder.Entity<Organizer>(entity =>
            {
                entity.ToTable("Organizers");
                entity.HasKey(o => o.Id);

                entity.Property(o => o.Name)
                      .HasColumnType("nvarchar")
                      .HasMaxLength(300)
                      .IsRequired();

                entity.Property(o => o.CompanyName)
                      .HasMaxLength(300)
                      .IsRequired(false);

                entity.Property(o => o.IsVerified)
                      .HasDefaultValue(false);

                // One-to-One: Organizer -> OrganizerProfile
                // Profile cannot exist without an Organizer (dependent entity)
                entity.HasOne(o => o.Profile)
                      .WithOne(p => p.Organizer)
                      .HasForeignKey<OrganizerProfile>(p => p.OrganizerId)
                      .OnDelete(DeleteBehavior.Cascade); // delete profile when organizer is deleted
            });

            // ─────────────────────────────────────────────────────────────────────
            // BADGE  →  configured via Fluent API (inline)
            // ─────────────────────────────────────────────────────────────────────
            modelBuilder.Entity<Badge>(entity =>
            {
                entity.ToTable("Badges");
                entity.HasKey(b => b.Id);

                entity.Property(b => b.BadgeNumber)
                      .HasColumnType("varchar")
                      .HasMaxLength(50)
                      .IsRequired();

                // Each attendee has a unique badge number
                entity.HasIndex(b => b.BadgeNumber)
                      .IsUnique();

                entity.Property(b => b.IssuedDate)
                      .IsRequired();

                entity.Property(b => b.Tier)
                      .HasConversion<string>()   // store enum as "Standard" / "VIP"
                      .HasMaxLength(20)
                      .IsRequired();

                // One-to-One: Attendee -> Badge
                // Each attendee can have at most one badge
                entity.HasOne(b => b.Attendee)
                      .WithOne(a => a.Badge)
                      .HasForeignKey<Badge>(b => b.AttendeeId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
