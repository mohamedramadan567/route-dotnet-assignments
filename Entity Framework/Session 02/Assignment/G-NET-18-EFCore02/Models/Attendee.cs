using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore02.Models
{
    //Data Annotations
    public class Attendee
    {
        public int Id { get; set; }

        [MaxLength(200)]
        public string FullName { get; set; } = default!;

        [MaxLength(320)]
        [EmailAddress]
        public string Email { get; set; } = default!;

        // Owned type(Address(Street, City, Country, PostalCode))
        [MaxLength(300)]
        public string Street { get; set; } = default!;

        [MaxLength(100)]
        public string City { get; set; } = default!;

        [MaxLength(100)]
        public string Country { get; set; } = default!;

        [MaxLength(20)]
        public string PostalCode { get; set; } = default!;

        // Many-to-Many: Attendee <-> Event Registration table
        public ICollection<Registration> Registrations { get; set; } = new HashSet<Registration>();

        // One-to-One: Attendee -> Badge 
        public Badge? Badge { get; set; }
    }
}
