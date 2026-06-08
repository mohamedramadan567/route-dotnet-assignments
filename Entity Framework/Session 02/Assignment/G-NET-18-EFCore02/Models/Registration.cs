using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore02.Models
{
    //Separate IEntityTypeConfiguration class
    public class Registration
    {
        // Composite PK(AttendeeId + EventId)
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = default!;

        public int EventId { get; set; }
        public Event Event { get; set; } = default!;

        public string? Note { get; set; }

        // Auto-recorded
        public DateTime RegisteredAt { get; set; }
    }
}
