using CityLibrarySystem.Contracts;

namespace CityLibrarySystem.Models
{
    public class Book : IDisplayable
    {
        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public string AuthorName { get; private set; }
        public string Category { get; private set; }
        public int PublicationYear { get; private set; }

        // Constructor 1 — full details
        public Book(string isbn, string title, string authorName, string category, int publicationYear)
        {
            ISBN = isbn;
            Title = title;
            AuthorName = authorName;
            Category = category;
            PublicationYear = publicationYear;
        }
        // Constructor 2 — minimal

        public Book(string isbn, string title) : this(isbn, title, "Unknown", "General", 0)
        {
        }
        public string ToDisplayString() => $"[{ISBN}] \"{Title}\" by {AuthorName} ({PublicationYear}) — {Category}";
    }
}
