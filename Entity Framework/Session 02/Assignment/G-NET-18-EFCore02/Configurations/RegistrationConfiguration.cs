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
    internal class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasKey(r => new { r.AttendeeId, r.EventId });

            builder.Property(r => r.Note)
                   .HasMaxLength(1000);

            // Platform auto-records the registration timestamp
            builder.Property(r => r.RegisteredAt)
                   .HasDefaultValueSql("GETDATE()");

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
