using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventHub.Models
{
    // Configured via: Data Annotations
    // Owned by Organizer - cannot exist without it (one-to-one, mandatory from Organizer side)
    [Table("OrganizerProfiles")]
    internal class OrganizerProfile
    {
        // PK is also FK to Organizer (shared primary key pattern)
        [Key]
        [ForeignKey(nameof(Organizer))]
        public int OrganizerId { get; set; }

        [MaxLength(1000)]
        public string? Bio { get; set; }

        [MaxLength(500)]
        [Url]
        public string? WebsiteUrl { get; set; }

        [MaxLength(500)]
        public string? LogoUrl { get; set; }

        public Organizer Organizer { get; set; } = default!;
    }
}
