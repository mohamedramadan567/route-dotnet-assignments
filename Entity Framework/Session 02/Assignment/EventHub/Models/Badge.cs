namespace EventHub.Models
{
    // Configured via: Fluent API (inline in OnModelCreating)
    public enum BadgeTier
    {
        Standard,
        VIP
    }

    internal class Badge
    {
        public int Id { get; set; }

        // Unique badge number per attendee
        public string BadgeNumber { get; set; } = default!;

        public DateTime IssuedDate { get; set; }

        public BadgeTier Tier { get; set; }

        // FK to Attendee (one-to-one)
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = default!;
    }
}
