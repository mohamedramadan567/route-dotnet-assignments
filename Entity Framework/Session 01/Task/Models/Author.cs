using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    internal class Author
    {
        //Id, Name, Country
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Country { get; set; }
    }
}
