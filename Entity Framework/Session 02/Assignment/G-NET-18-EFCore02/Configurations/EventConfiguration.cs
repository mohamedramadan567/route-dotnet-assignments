using G_NET_18_EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore02.Configurations
{
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.Property(e => e.Title)
                   .HasColumnType("nvarchar")
                   .HasMaxLength(300);

            builder.Property(e => e.Description)
                   .HasMaxLength(5000);

            // Shadow properties
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
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
