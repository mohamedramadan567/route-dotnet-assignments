using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore02.Models
{
    //Convention and Fluent API
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }

        // One-to-One: Organizer -> OrganizerProfile
        public OrganizerProfile? Profile { get; set; }

        // One-to-Many: Organizer -> Events
        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }
}
