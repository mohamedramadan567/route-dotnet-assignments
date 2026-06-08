using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore02.Models
{
    //Fluent API
    public enum BadgeTier
    {
        Standard,
        VIP
    }

    public class Badge
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
