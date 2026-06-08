using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub.Configurations
{
    // Separate configuration class for Registration entity (Many-to-Many join table)
    internal class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.ToTable("Registrations");

            // Composite Primary Key
            builder.HasKey(r => new { r.AttendeeId, r.EventId });

            builder.Property(r => r.Note)
                   .HasMaxLength(1000)
                   .IsRequired(false);

            // Platform auto-records the registration timestamp
            builder.Property(r => r.RegisteredAt)
                   .HasDefaultValueSql("GETDATE()")
                   .IsRequired();

            // Many-to-Many: Attendee <-> Event
            builder.HasOne(r => r.Attendee)
                   .WithMany(a => a.Registrations)
                   .HasForeignKey(r => r.AttendeeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(r => r.Event)
                   .WithMany(e => e.Registrations)
                   .HasForeignKey(r => r.EventId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
