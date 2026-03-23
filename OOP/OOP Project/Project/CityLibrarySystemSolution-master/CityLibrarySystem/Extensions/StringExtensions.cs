namespace CityLibrarySystem.Extensions
{
    internal static class StringExtensions
    {
        public static string NormalizeID(this string value)
        {
            return value?.Trim().ToUpperInvariant() ?? string.Empty;
        }
        public static bool IsValidEmail(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            bool hasAt = false;
            bool hasDot = false;

            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == '@') hasAt = true;
                if (value[i] == '.') hasDot = true;
            }

            return hasAt && hasDot;
        }
        public static bool ContainsDigit(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                    return true;
            }
            return false;
        }
    }
}
