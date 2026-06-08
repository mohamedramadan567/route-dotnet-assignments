using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore02.Models
{
    [Table("OrganizerProfiles")]
    public class OrganizerProfile
    {
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
