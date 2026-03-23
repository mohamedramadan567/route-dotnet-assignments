using System.Text;

namespace CityLibrarySystem.Models
{
    public class Member : LibraryUser
    {
        private static int _counter = 1;
        // Shared Across all Members [Static]
        public string MembershipId { get; private set; }
        public DateOnly? DateOfBirth { get; private set; }
        public string? Email { get; private set; }
        public DateOnly MembershipDate { get; private set; }

        private readonly List<BorrowTransaction> _transactions = new();
        public IReadOnlyList<BorrowTransaction> Transactions => _transactions;

        public Member(string name, DateOnly? dob, string? email, string phone, DateOnly membershipDate) : base(name, phone)
        {
            MembershipId = $"MEM-{_counter++:D3}";
            DateOfBirth = dob;
            Email = email;
            MembershipDate = membershipDate;
        }
        public Member(string name, string phone) : this(name, null, null, phone, DateOnly.FromDateTime(DateTime.Today))
        {

        }

        public void AddTransaction(BorrowTransaction tran) => _transactions.Add(tran);

        public override string ToDisplayString() => $@"ID      : {MembershipId}
Name    : {Name}
Phone   : {Phone}
Email   : {Email ?? "N/A"}
Joined  : {MembershipDate:dd/MM/yyyy}
Borrows : {Transactions.Count}";

        public string GetHistoryDisplayString()
        {
            if (Transactions.Count == 0)
                return "  No transactions found";

            var sb = new StringBuilder();
            for (int i = 0; i < Transactions.Count; i++)
            {
                sb.AppendLine(Transactions[i].ToDisplayString());
            }
            return sb.ToString();
        }
    }
}
