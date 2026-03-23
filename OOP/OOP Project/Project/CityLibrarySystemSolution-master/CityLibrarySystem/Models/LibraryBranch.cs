using CityLibrarySystem.Contracts;
using CityLibrarySystem.Extensions;

namespace CityLibrarySystem.Models
{
    public class LibraryBranch : IDisplayable
    {
        public string BranchId { get; private set; } = null!;
        public string BranchName { get; private set; } = null!;
        public string Address { get; private set; } = null!;
        public string Phone { get; private set; } = null!;
        public string OpeningHours { get; private set; } = null!;
        public Librarian Manager { get; private set; } = null!;

        private readonly List<BookCopy> _copies = new();
        private readonly List<Member> _members = new();
        public IReadOnlyList<BookCopy> Copies => _copies;
        public IReadOnlyList<Member> Members => _members;

        // Returns all users (manager + members) as a single read-only list.
        public IReadOnlyList<LibraryUser> Users
        {
            get
            {
                List<LibraryUser> users = new();
                users.Add(Manager);
                for (int i = 0; i < _members.Count; i++)
                {
                    users.Add(_members[i]);
                }
                return users;
            }
        }
        public LibraryBranch(string branchId, string name, string address, string phone, string openingHours, Librarian manager)
        {
            BranchId = branchId;
            BranchName = name;
            Address = address;
            Phone = phone;
            OpeningHours = openingHours;
            Manager = manager;
        }
        public Member RegisterMember(string name, string phone)
        {
            var member = new Member(name, phone);
            _members.Add(member);
            return member;
        }

        public Member RegisterMember(string name, DateOnly? dob, string? email, string phone, DateOnly membershipDate)
        {
            var member = new Member(name, dob, email, phone, membershipDate);
            _members.Add(member);
            return member;
        }

        public Member FindMember(string membershipId)
        {
            string normalized = membershipId.NormalizeID();
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].MembershipId == normalized)
                    return _members[i];
            }
            throw new InvalidOperationException("Member not found.");
        }

        public BookCopy FindCopy(string copyId)
        {
            string normalized = copyId.NormalizeID();
            for (int i = 0; i < _copies.Count; i++)
            {
                if (_copies[i].CopyId == normalized)
                    return _copies[i];
            }
            throw new InvalidOperationException("Book copy not found.");
        }

        public void AddBookCopy(BookCopy copy)
        {
            _copies.Add(copy);
        }
        public List<BookCopy> GetAvailableCopies()
        {
            List<BookCopy> availableCopies = new();
            for (int i = 0; i < _copies.Count; i++)
            {
                if (_copies[i].IsAvailable())
                    availableCopies.Add(_copies[i]);
            }
            return availableCopies;
        }

        public string ToDisplayString() => $@"ID : {BranchId}
Name : {BranchName}
Address : {Address}
Phone : {Phone}
Opening Hours : {OpeningHours}
Manager : {Manager.Name}
Total Members : {_members.Count}
Total Book Copies : {_copies.Count}";
    }

}
