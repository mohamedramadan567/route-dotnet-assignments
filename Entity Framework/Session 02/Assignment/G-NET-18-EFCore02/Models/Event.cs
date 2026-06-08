using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore02.Models
{
    //Separate IEntityTypeConfiguration class
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxAttendees { get; set; }


        // FK to Organizer
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; } = default!;


        // Many-to-Many: Event <-> Attendee Registration table
        public ICollection<Registration> Registrations { get; set; } = new HashSet<Registration>();

        // Self-referencing: an event can be a session under a parent event
        public int? ParentEventId { get; set; }
        public Event? ParentEvent { get; set; }
        public ICollection<Event> Sessions { get; set; } = new HashSet<Event>();
    }
}
