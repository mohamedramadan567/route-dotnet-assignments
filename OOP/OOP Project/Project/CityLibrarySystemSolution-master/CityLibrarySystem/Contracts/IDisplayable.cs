namespace CityLibrarySystem.Contracts
{
    /// <summary>
    /// Contract for objects that can be formatted for display.
    /// Models return formatted strings; presentation layer handles output (SRP).
    /// </summary>
    public interface IDisplayable
    {
        string ToDisplayString();

    }
}
