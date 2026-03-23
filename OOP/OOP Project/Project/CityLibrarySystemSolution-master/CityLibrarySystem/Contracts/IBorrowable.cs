using CityLibrarySystem.Models;

namespace CityLibrarySystem.Contracts
{
    /// <summary>
    /// Contract for borrowable items. Methods throw InvalidOperationException on failure.
    /// </summary>
    public interface IBorrowable
    {
        void Borrow(Member member, int loanDays = 14);
        decimal Return();
        bool IsAvailable();
    }
}
