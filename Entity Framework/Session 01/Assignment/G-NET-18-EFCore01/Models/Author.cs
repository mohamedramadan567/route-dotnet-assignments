using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore01.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Biography { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }

    }
}
