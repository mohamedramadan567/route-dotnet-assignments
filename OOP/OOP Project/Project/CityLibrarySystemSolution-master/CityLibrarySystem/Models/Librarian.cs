namespace CityLibrarySystem.Models
{
    public class Librarian : LibraryUser
    {
        public string LibrarianId { get; private set; } = null!;
        public decimal Salary { get; private set; }
        public DateOnly HireDate { get; private set; }

        public Librarian(string librarianId, string name, string phone, decimal salary, DateOnly hireDate) : base(name, phone)
        {
            LibrarianId = librarianId;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToDisplayString()
        {
            // verbatim interpolated string
            return $@"ID      : {LibrarianId}
Name    : {Name}
Phone   : {Phone}
Salary  : {Salary:C}
Hired   : {HireDate:dd/MM/yyyy}";
        }
    }
}
