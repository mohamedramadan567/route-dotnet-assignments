namespace EventHub.Models
{
    // Configured via: Separate IEntityTypeConfiguration class (RegistrationConfiguration.cs)
    // Join entity for Many-to-Many between Attendee and Event
    internal class Registration
    {
        // Composite PK: AttendeeId + EventId
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = default!;

        public int EventId { get; set; }
        public Event Event { get; set; } = default!;

        // Optional note from attendee to organizer
        public string? Note { get; set; }

        // Auto-recorded by platform
        public DateTime RegisteredAt { get; set; }
    }
}
