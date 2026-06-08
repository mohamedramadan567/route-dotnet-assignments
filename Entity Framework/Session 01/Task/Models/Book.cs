using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string ISBN { get; set; } = default!;
        public int PublishedYear { get; set; }
    }
}
