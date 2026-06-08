using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventHub.Models
{
    // Configured via: Data Annotations
    [Table("Attendees")]
    internal class Attendee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string FullName { get; set; } = default!;

        [Required]
        [MaxLength(320)]
        [EmailAddress]
        public string Email { get; set; } = default!;

        // Owned type: Address (stored in same table as Attendee)
        [Required]
        [MaxLength(300)]
        [Column("Street")]
        public string Street { get; set; } = default!;

        [Required]
        [MaxLength(100)]
        [Column("City")]
        public string City { get; set; } = default!;

        [Required]
        [MaxLength(100)]
        [Column("Country")]
        public string Country { get; set; } = default!;

        [Required]
        [MaxLength(20)]
        [Column("PostalCode")]
        public string PostalCode { get; set; } = default!;

        // One-to-One: Attendee -> Badge (optional until they register for at least one event)
        public Badge? Badge { get; set; }

        // Many-to-Many: Attendee <-> Event via Registration join entity
        public ICollection<Registration> Registrations { get; set; } = new HashSet<Registration>();
    }
}
