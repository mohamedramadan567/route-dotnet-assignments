using G_NET_18_EFCore02.Configurations;
using G_NET_18_EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore02
{
    internal class EventHubDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EventHubDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfile { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new RegistrationConfiguration());

            modelBuilder.Entity<Organizer>(entity =>
            {
                entity.Property(o => o.Name)
                      .HasColumnType("nvarchar")
                      .HasMaxLength(300);

                entity.Property(o => o.CompanyName)
                      .HasMaxLength(300);

                entity.Property(o => o.IsVerified)
                      .HasDefaultValue(false);

                //1 : 1 OrganizerProfile
                entity.HasOne(o => o.Profile)
                      .WithOne(p => p.Organizer)
                      .HasForeignKey<OrganizerProfile>(p => p.OrganizerId)
                      .OnDelete(DeleteBehavior.Cascade);


            });

            modelBuilder.Entity<Badge>(entity =>
            {
                entity.Property(b => b.BadgeNumber)
                      .HasColumnType("varchar")
                      .HasMaxLength(50);

                // Each attendee has a unique badge number
                entity.HasIndex(b => b.BadgeNumber)
                      .IsUnique();

                entity.Property(b => b.Tier)
                      .HasConversion<string>()   // store enum as string
                      .HasMaxLength(20);

                // One-to-One: Attendee -> Badge
                entity.HasOne(b => b.Attendee)
                      .WithOne(a => a.Badge)
                      .HasForeignKey<Badge>(b => b.AttendeeId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}
