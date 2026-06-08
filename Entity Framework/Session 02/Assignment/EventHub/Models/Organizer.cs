namespace EventHub.Models
{
    // Configured via: Fluent API (inline in OnModelCreating)
    internal class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }

        // One-to-One: Organizer -> OrganizerProfile (Dependent)
        public OrganizerProfile? Profile { get; set; }

        // One-to-Many: Organizer -> Events
        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
