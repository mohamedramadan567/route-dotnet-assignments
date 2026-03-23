using CityLibrarySystem.Contracts;

namespace CityLibrarySystem.Models
{
    /// <summary>
    /// Base class for library users. Member and Librarian override ToDisplayString.
    /// </summary>
    public abstract class LibraryUser : IDisplayable
    {
        public string Name { get; protected set; }
        public string Phone { get; protected set; }
        public LibraryUser(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }
        public abstract string ToDisplayString();
    }
}
