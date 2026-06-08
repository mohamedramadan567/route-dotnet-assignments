namespace EventHub.Models
{
    // Configured via: Separate IEntityTypeConfiguration class (EventConfiguration.cs)
    internal class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }

        // Shadow properties: CreatedAt, UpdatedAt (never shown publicly, managed by EF)

        // FK to Organizer
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = default!;

        // Self-referencing: an event can be a session under a parent event
        public int? ParentEventId { get; set; }
        public Event? ParentEvent { get; set; }
        public ICollection<Event> Sessions { get; set; } = new HashSet<Event>();

        // Many-to-Many: Event <-> Attendee via Registration join entity
        public ICollection<Registration> Registrations { get; set; } = new HashSet<Registration>();
    }
}
