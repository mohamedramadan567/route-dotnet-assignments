using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventHub.Configurations
{
    // Separate configuration class for Event entity
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Title)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(300)
                   .IsRequired();

            builder.Property(e => e.Description)
                   .HasMaxLength(5000)
                   .IsRequired();

            builder.Property(e => e.StartDate)
                   .IsRequired();

            builder.Property(e => e.EndDate)
                   .IsRequired(false);

            builder.Property(e => e.MaxAttendees)
                   .IsRequired();

            // Shadow properties: never exposed publicly, managed internally by the platform
            builder.Property<DateTime>("CreatedAt")
                   .HasDefaultValueSql("GETDATE()");

            builder.Property<DateTime>("UpdatedAt")
                   .HasDefaultValueSql("GETDATE()");

            // One-to-Many: Organizer -> Events
            builder.HasOne(e => e.Organizer)
                   .WithMany(o => o.Events)
                   .HasForeignKey(e => e.OrganizerId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Self-Referencing: Parent Event -> Sessions (child events)
            // A session belongs to one parent event; a parent event can have many sessions
            builder.HasOne(e => e.ParentEvent)
                   .WithMany(e => e.Sessions)
                   .HasForeignKey(e => e.ParentEventId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
