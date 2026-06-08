using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_18_EFCore01.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string ISBN { get; set; } = default!;
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int Year { get; set; }
        public bool IsInStock { get; set; }

        public Category BookCategory { get; set; } = default!;
        public int CategoryId { get; set; } //FK
    }
}
